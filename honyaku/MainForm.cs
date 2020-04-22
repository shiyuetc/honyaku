using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace honyaku
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// アプリケーションの状態
        /// </summary>
        private AppMode AppMode = AppMode.Capture;

        /// <summary>
        /// 
        /// </summary>
        private bool IsWork = false;

        /// <summary>
        /// ステルスモード
        /// </summary>
        private bool StealthMode = false;

        /// <summary>
        /// 
        /// </summary>
        public int CaptureRegionMargin { get; set; } = 6;

        /// <summary>
        /// 
        /// </summary>
        private bool CaptureRegionVisible { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        private Color CaptureRegionColor { get; set; } = Color.Red;

        /// <summary>
        /// 
        /// </summary>
        private bool ReturnFocus { get; set; } = true;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 設定情報のロード
        /// </summary>
        private void LoadSetting()
        {
            this.CaptureRegionMargin = (int)Properties.Settings.Default["capture_region_margin"];
            this.CaptureRegionPanel.Size = new Size(this.TranslatorSplitContainer.Width - this.CaptureRegionMargin * 2, this.TranslatorSplitContainer.Height - this.CaptureRegionMargin);
            this.CaptureRegionPanel.Location = new Point(this.CaptureRegionMargin, 24);
            this.CaptureRegionVisible = (bool)Properties.Settings.Default["capture_region_visible"];
            this.CaptureRegionColor = (Color)Properties.Settings.Default["capture_region_color"];
            this.ReturnFocus = (bool)Properties.Settings.Default["return_focus"];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        private void UpdateTitleMessage(string message = "")
        {
            if (message.Length == 0) this.Text = "Honyaku";
            else this.Text = "Honyaku - " + message;
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LoadSetting();

            this.TargetTextBox.BackColor = Color.White;
            this.DrawCaptureLine();
        }

        /// <summary>
        /// フォームのリサイズイベント
        /// </summary>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.DrawCaptureLine();
        }

        /// <summary>
        /// キャプチャ領域線を描画する
        /// </summary>
        private void DrawCaptureLine()
        {
            if (this.CaptureRegionVisible)
            {
                try
                {
                    Bitmap canvas = new Bitmap(this.CaptureRegionPanel.Width, this.CaptureRegionPanel.Height);
                    Graphics g = Graphics.FromImage(canvas);
                    g.DrawRectangle(new Pen(this.CaptureRegionColor, 1), 0, 0, this.CaptureRegionPanel.Width - 1, this.CaptureRegionPanel.Height - 1);
                    g.Dispose();
                    this.CaptureRegionPanel.BackgroundImage = canvas;
                }
                catch { }
            }
        }

        /// <summary>
        /// アプリケーションの状態を変更する
        /// </summary>
        /// <param name="appMode">変更したいモード</param>
        private void ChangeMode(AppMode appMode)
        {
            this.AppMode = appMode;
            if (appMode == AppMode.Capture)
            {
                this.TranslateToolStripMenuItem.Visible = true;
                this.BackToolStripMenuItem.Visible = false;
                this.ReTranslateToolStripMenuItem.Visible = false;
                this.TranslatorSplitContainer.Visible = false;
            }
            else if(appMode == AppMode.Translate)
            {
                this.TranslateToolStripMenuItem.Visible = false;
                this.BackToolStripMenuItem.Visible = true;
                this.ReTranslateToolStripMenuItem.Visible = true;
                this.TranslatorSplitContainer.Visible = true;

                if(this.StealthMode) this.Opacity = 1;
            }

            // フォーカスを後ろのアプリケーションに渡す
            if (this.ReturnFocus)
            {
                Point location = this.Location;
                this.Location = new Point(-this.Width, -this.Height);
                IntPtr handle = WindowsAPI.WindowFromPoint(Control.MousePosition);
                this.Location = location;
                if (handle != IntPtr.Zero && Control.FromHandle(handle) == null)
                    WindowsAPI.SetForegroundWindow(handle);
            }
        }

        /// <summary>
        /// ステルスモードへの変更
        /// </summary>
        /// <param name="flag">真が偽か</param>
        private void Stealth(bool flag)
        {
            if(flag)
            {
                for (int i = 10; i >= 3; i--)
                {
                    this.Opacity = 0.1 * i;
                    System.Threading.Thread.Sleep(10);
                }
            }
            else
            {
                for (int i = 2; i <= 10; i++)
                {
                    this.Opacity = 0.1 * i;
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        /// <summary>
        /// メニューストリップのマウスエンターイベント
        /// </summary>
        private void MenuStrip1_MouseEnter(object sender, EventArgs e)
        {
            if (this.AppMode == AppMode.Capture && StealthMode) this.Stealth(false);
        }

        /// <summary>
        /// メニューストリップのマウスリーブイベント
        /// </summary>
        private void MenuStrip1_MouseLeave(object sender, EventArgs e)
        {
            if (this.AppMode == AppMode.Capture && StealthMode) this.Stealth(true);
        }

        /// <summary>
        /// 戻るボタンのクリックイベント
        /// </summary>
        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeMode(AppMode.Capture);
        }

        /// <summary>
        /// キャプチャ+翻訳ボタンのクリックイベント
        /// </summary>
        private async void TranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsWork) return;
            this.IsWork = true;
            this.UpdateTitleMessage("翻訳中");

            Bitmap image = new Bitmap(this.CaptureRegionPanel.Width - 2, this.CaptureRegionPanel.Height - 2);
            Graphics g = Graphics.FromImage(image);
            Point ClientPanelPoint = this.CaptureRegionPanel.PointToScreen(new Point(0, 0));
            g.CopyFromScreen(new Point(ClientPanelPoint.X + 1, ClientPanelPoint.Y + 1), new Point(0, 0), image.Size);
            g.Dispose();


            this.SourceTextBox.Text = await Task.Run(() => image.ToOcrString());
            this.TargetTextBox.Text = "";

            if (this.SourceTextBox.Text.Length == 0)
            {
                MessageBox.Show("文字列を認識できませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.TargetTextBox.Text = await Translator.Run(this.SourceTextBox.Text);
                this.ChangeMode(AppMode.Translate);
            }

            this.UpdateTitleMessage();
            this.IsWork = false;
        }

        /// <summary>
        /// 再翻訳ボタンのクリックイベント
        /// </summary>
        private async void ReTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsWork) return;
            this.IsWork = true;
            this.UpdateTitleMessage("翻訳中");

            this.SourceTextBox.Text = this.SourceTextBox.Text.Trim();
            this.TargetTextBox.Text = "";

            if (this.SourceTextBox.Text.Length > 0)
            {
                this.TargetTextBox.Text = await Translator.Run(this.SourceTextBox.Text);
            }

            this.UpdateTitleMessage();
            this.IsWork = false;
        }

        /// <summary>
        /// ステルスモードボタンのクリックイベント
        /// </summary>
        private void StealthModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StealthMode = this.StealthModeToolStripMenuItem.Checked;
            if (this.AppMode == AppMode.Capture) this.Stealth(this.StealthMode);
        }

        /// <summary>
        /// 左右に分割ボタンのクリックイベント
        /// </summary>
        private void LateralSplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LateralSplitToolStripMenuItem.Checked = true;
            this.VerticalitySplitToolStripMenuItem.Checked = false;
            this.TranslatorSplitContainer.Orientation = Orientation.Vertical;
            if (!this.HideSourceTextToolStripMenuItem.Checked)
                this.TranslatorSplitContainer.SplitterDistance = this.TranslatorSplitContainer.Width / 2;
        }

        /// <summary>
        /// 上下に分割ボタンのクリックイベント
        /// </summary>
        private void VerticalitySplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LateralSplitToolStripMenuItem.Checked = false;
            this.VerticalitySplitToolStripMenuItem.Checked = true;
            this.TranslatorSplitContainer.Orientation = Orientation.Horizontal;
            if(!this.HideSourceTextToolStripMenuItem.Checked)
                this.TranslatorSplitContainer.SplitterDistance = this.TranslatorSplitContainer.Height / 2;
        }

        /// <summary>
        /// 翻訳前のテキストを隠すボタンのクリックイベント
        /// </summary>
        private void HideSourceTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TranslatorSplitContainer.IsSplitterFixed = this.HideSourceTextToolStripMenuItem.Checked;
            if (this.HideSourceTextToolStripMenuItem.Checked)
                this.TranslatorSplitContainer.SplitterDistance = 0;
            else
            {
                if(this.TranslatorSplitContainer.Orientation == Orientation.Vertical)
                    this.TranslatorSplitContainer.SplitterDistance = this.TranslatorSplitContainer.Width / 2;
                else
                    this.TranslatorSplitContainer.SplitterDistance = this.TranslatorSplitContainer.Height / 2;
            }
        }

        /// <summary>
        /// 簡易キャプチャー+翻訳ボタンのクリックイベント
        /// </summary>
        private async void QuickTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsWork) return;
            this.IsWork = true;

            QuickCaptureForm f = new QuickCaptureForm();
            f.ShowDialog();
            if (f.ResultImage != null)
            {
                this.UpdateTitleMessage("翻訳中");
                this.SourceTextBox.Text = await Task.Run(() => f.ResultImage.ToOcrString());
                this.TargetTextBox.Text = "";

                if (this.SourceTextBox.Text.Length == 0)
                {
                    MessageBox.Show("文字列を認識できませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.TargetTextBox.Text = await Translator.Run(this.SourceTextBox.Text);
                    this.ChangeMode(AppMode.Translate);
                }
            }

            this.UpdateTitleMessage();
            this.IsWork = false;
        }

        /// <summary>
        /// ウィンドウ配置管理ボタンのクリックイベント
        /// </summary>
        private void PlaceManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceManagementForm f = new PlaceManagementForm(this);
            f.Location = new Point(
                this.Location.X + (this.Width - f.Width) / 2,
                this.Location.Y + (this.Height - f.Height) / 2);
            f.ShowDialog();
        }

        /// <summary>
        /// 設定ボタンのクリックイベント
        /// </summary>
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
