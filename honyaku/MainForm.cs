using System;
using System.Collections.Generic;
using System.Drawing;
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
        /// 翻訳中かどうか
        /// </summary>
        private bool IsWork = false;

        /// <summary>
        /// ステルスモード
        /// </summary>
        private bool StealthMode = false;

        /// <summary>
        /// 配置データの配列
        /// </summary>
        private Place[] Places;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームの初期化
        /// </summary>
        private void Initialize()
        {
            this.LanguageToolStripMenuItem.Text = DataProperty.Languages[Setting.SourceLanguage].JapaneseName + " -> " + DataProperty.Languages[Setting.TargetLanguage].JapaneseName;

            // キャプチャ領域を設定
            this.CaptureRegionPanel.Size = new Size(this.TranslatorSplitContainer.Width - Setting.CaptureRegionMargin * 2, this.TranslatorSplitContainer.Height - Setting.CaptureRegionMargin);
            this.CaptureRegionPanel.Location = new Point(Setting.CaptureRegionMargin, 24);

            // 
            if (Setting.BackPlace)
            {
                this.Location = Setting.BackPlaceLocation;
                this.Size = Setting.BackPlaceSize;
            }

            // 領域線の描画
            if (Setting.CaptureRegionVisible)
            {
                this.DrawCaptureLine();
                this.Resize += (object sender, EventArgs e) => { this.DrawCaptureLine(); };
            }

            // 結果のテキストのフォントを変更
            this.SourceTextBox.Font = Setting.ResultFont;
            this.TargetTextBox.Font = Setting.ResultFont;

            // 配置データを読み込む
            this.UpdatePlaces();
        }

        /// <summary>
        /// 配置データを読み込んでメニューに追加する
        /// </summary>
        private void UpdatePlaces()
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer =
                    new System.Xml.Serialization.XmlSerializer(typeof(Place[]));
                System.IO.StreamReader sr = new System.IO.StreamReader(DataProperty.PlacesFile, new System.Text.UTF8Encoding(false));
                this.Places = (Place[])serializer.Deserialize(sr);
                sr.Close();

                this.PlaceManagementToolStripMenuItem.DropDownItems.Clear();
                ToolStripMenuItem[] items = new ToolStripMenuItem[this.Places.Length];
                for (int i = 0; i < this.Places.Length; i++)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Name = "PlaceToolStripMenuItem_" + i;
                    item.Text = this.Places[i].Name;
                    item.Click += this.PlaceToolStripMenuItem_Click;
                    items[i] = item;
                }
                this.PlaceManagementToolStripMenuItem.DropDownItems.AddRange(items);
            }
            catch { }
        }

        /// <summary>
        /// リクエストのロックを操作する
        /// </summary>
        /// <param name="message"></param>
        private void RequestLock(bool isWork)
        {
            this.IsWork = isWork;
            if(isWork)this.Text = "Honyaku - 翻訳中";
            else this.Text = "Honyaku";
        }
        
        /// <summary>
        /// キャプチャ領域線を描画する
        /// </summary>
        private void DrawCaptureLine()
        {
            try
            {
                Bitmap canvas = new Bitmap(this.CaptureRegionPanel.Width, this.CaptureRegionPanel.Height);
                Graphics g = Graphics.FromImage(canvas);
                g.DrawRectangle(new Pen(Setting.CaptureRegionColor, 1), 0, 0, this.CaptureRegionPanel.Width - 1, this.CaptureRegionPanel.Height - 1);
                g.Dispose();
                this.CaptureRegionPanel.BackgroundImage = canvas;
            }
            catch { }
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
            else if (appMode == AppMode.Translate)
            {
                this.TranslateToolStripMenuItem.Visible = false;
                this.BackToolStripMenuItem.Visible = true;
                this.ReTranslateToolStripMenuItem.Visible = true;
                this.TranslatorSplitContainer.Visible = true;

                if (this.StealthMode) this.Opacity = 1;
            }

            // フォーカスを後ろのアプリケーションに渡す
            if (Setting.ReturnFocus)
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
            if (flag)
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
        /// フォームのロードイベント
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Setting.Load();
            this.Initialize();
        }

        /// <summary>
        /// フォームの終了イベント
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Setting.BackPlace)
            {
                Dictionary<string, object> settings = new Dictionary<string, object>()
                {
                    { "BackPlaceLocation", this.Location },
                    { "BackPlaceSize", this.Size },
                };
                Setting.Save(settings);
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
            this.RequestLock(true);

            Bitmap image = new Bitmap(this.CaptureRegionPanel.Width - 2, this.CaptureRegionPanel.Height - 2);
            Graphics g = Graphics.FromImage(image);
            Point ClientPanelPoint = this.CaptureRegionPanel.PointToScreen(new Point(0, 0));
            g.CopyFromScreen(new Point(ClientPanelPoint.X + 1, ClientPanelPoint.Y + 1), new Point(0, 0), image.Size);
            g.Dispose();

            // キャプチャ画像の保存
            if(Setting.CaptureSave)
            {
                if (!System.IO.Directory.Exists("captures")) System.IO.Directory.CreateDirectory("captures");
                image.Save("captures/" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + ".jpg");
            }

            if (!DataProperty.ExistTessData(DataProperty.Languages[Setting.SourceLanguage].ISO639_2))
            {
                MessageBox.Show("言語学習データが見つかりませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto end;
            }

            try
            {
                this.SourceTextBox.Text = await Task.Run(() => image.ToOcrString(DataProperty.Languages[Setting.SourceLanguage].ISO639_2));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto end;
            }

            this.TargetTextBox.Text = "";

            if (this.SourceTextBox.Text.Length == 0)
            {
                MessageBox.Show("文字列を認識できませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.TargetTextBox.Text = await Translator.Run(this.SourceTextBox.Text, DataProperty.Languages[Setting.SourceLanguage].ISO639_1, DataProperty.Languages[Setting.TargetLanguage].ISO639_1);
                this.ChangeMode(AppMode.Translate);
            }

            end: this.RequestLock(false);
        }

        /// <summary>
        /// 再翻訳ボタンのクリックイベント
        /// </summary>
        private async void ReTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsWork) return;
            this.RequestLock(true);

            this.SourceTextBox.Text = this.SourceTextBox.Text.Trim();
            this.TargetTextBox.Text = "";

            if (this.SourceTextBox.Text.Length > 0)
            {
                this.TargetTextBox.Text = await Translator.Run(this.SourceTextBox.Text, DataProperty.Languages[Setting.SourceLanguage].ISO639_1, DataProperty.Languages[Setting.TargetLanguage].ISO639_1);
            }

            this.RequestLock(false);
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
        /// エクスプローラーボタンのクリックイベント
        /// </summary>
        private void ExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", Environment.CurrentDirectory);
        }

        /// <summary>
        /// 簡易キャプチャー+翻訳ボタンのクリックイベント
        /// </summary>
        private async void QuickTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsWork) return;
            this.RequestLock(true);

            QuickCaptureForm f = new QuickCaptureForm();
            f.ShowDialog();
            if (f.ResultImage != null)
            {
                // キャプチャ画像の保存
                if (Setting.CaptureSave)
                {
                    if (!System.IO.Directory.Exists("captures")) System.IO.Directory.CreateDirectory("captures");
                    f.ResultImage.Save("captures/" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + ".jpg");
                }

                if (!DataProperty.ExistTessData(DataProperty.Languages[Setting.SourceLanguage].ISO639_2))
                {
                    MessageBox.Show("言語学習データが見つかりませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto end;
                }

                try
                {
                    this.SourceTextBox.Text = await Task.Run(() => f.ResultImage.ToOcrString(DataProperty.Languages[Setting.SourceLanguage].ISO639_2));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto end;
                }

                this.TargetTextBox.Text = "";

                if (this.SourceTextBox.Text.Length == 0)
                {
                    MessageBox.Show("文字列を認識できませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.TargetTextBox.Text = await Translator.Run(this.SourceTextBox.Text, DataProperty.Languages[Setting.SourceLanguage].ISO639_1, DataProperty.Languages[Setting.TargetLanguage].ISO639_1);
                    this.ChangeMode(AppMode.Translate);
                }
            }

            end: this.RequestLock(false);
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
            if(f.IsEdit) this.UpdatePlaces();
        }

        /// <summary>
        /// 配置ボタンのクリックイベント
        /// </summary>
        private void PlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int index = int.Parse(item.Name.Remove(0, item.Name.IndexOf("_") + 1));
            this.Location = this.Places[index].Location;
            this.Size = this.Places[index].Size;
        }

        /// <summary>
        /// 設定ボタンのクリックイベント
        /// </summary>
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm f = new SettingForm();
            f.Location = new Point(
                this.Location.X + (this.Width - f.Width) / 2,
                this.Location.Y + (this.Height - f.Height) / 2);
            f.ShowDialog();
            if (f.IsApply) Application.Restart();
        }
    }
}
