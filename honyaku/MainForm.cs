using System;
using System.Drawing;
using System.Windows.Forms;

namespace honyaku
{
    public partial class MainForm : Form
    {
        private AppMode AppMode = AppMode.Capture;

        private bool StealthMode = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TargetTextBox.BackColor = Color.White;
            this.DrawCaptureLine();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.DrawCaptureLine();
        }

        private void DrawCaptureLine()
        {
            try
            {
                Bitmap canvas = new Bitmap(this.ClientPanel.Width, this.ClientPanel.Height);
                Graphics g = Graphics.FromImage(canvas);
                g.DrawRectangle(new Pen(Color.Red, 1), 0, 0, this.ClientPanel.Width - 1, this.ClientPanel.Height - 1);
                g.Dispose();
                this.ClientPanel.BackgroundImage = canvas;
            }
            catch { }
        }

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

                if(this.StealthMode)
                {
                    this.Opacity = 1;
                }
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeMode(AppMode.Capture);
        }

        private void TranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TranslateToolStripMenuItem.Enabled = false;

            Bitmap image = new Bitmap(this.ClientPanel.Width - 2, this.ClientPanel.Height - 2);
            Graphics g = Graphics.FromImage(image);
            Point ClientPanelPoint = this.ClientPanel.PointToScreen(new Point(0, 0));
            g.CopyFromScreen(new Point(ClientPanelPoint.X + 1, ClientPanelPoint.Y + 1), new Point(0, 0), image.Size);
            g.Dispose();

            using (var tesseract = new Tesseract.TesseractEngine(@"tessdata", "eng"))
            {
                this.SourceTextBox.Text = tesseract.Process(image).GetText().Trim();
                this.TargetTextBox.Text = "";

                if (this.SourceTextBox.Text.Length == 0)
                {
                    MessageBox.Show("文字列が認識されませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto end;
                }

                string str = Translator.Run(this.SourceTextBox.Text);
                if (str == null)
                {
                    MessageBox.Show("翻訳時にエラーが発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto end;
                }

                this.TargetTextBox.Text = str;
                this.ChangeMode(AppMode.Translate);
            }

            end:
            this.TranslateToolStripMenuItem.Enabled = true;
        }

        private void ReTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ReTranslateToolStripMenuItem.Enabled = false;

            this.SourceTextBox.Text = this.SourceTextBox.Text.Trim();
            this.TargetTextBox.Text = "";

            if (this.SourceTextBox.Text.Length == 0) goto end;

            string str = Translator.Run(this.SourceTextBox.Text);
            if (str == null)
            {
                MessageBox.Show("翻訳時にエラーが発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto end;
            }

            this.TargetTextBox.Text = str;

            end:
            this.ReTranslateToolStripMenuItem.Enabled = true;
        }

        private void LateralSplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LateralSplitToolStripMenuItem.Checked = true;
            this.VerticalitySplitToolStripMenuItem.Checked = false;
            this.TranslatorSplitContainer.Orientation = Orientation.Vertical;
            this.TranslatorSplitContainer.SplitterDistance = this.TranslatorSplitContainer.Width / 2;
        }

        private void VerticalitySplitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.LateralSplitToolStripMenuItem.Checked = false;
            this.VerticalitySplitToolStripMenuItem.Checked = true;
            this.TranslatorSplitContainer.Orientation = Orientation.Horizontal;
            this.TranslatorSplitContainer.SplitterDistance = this.TranslatorSplitContainer.Height / 2;
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            if (this.AppMode == AppMode.Capture && StealthMode)
            {
                for (int i = 2; i <= 10; i++)
                {
                    this.Opacity = 0.1 * i;
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            if (this.AppMode == AppMode.Capture && StealthMode)
            {
                for (int i = 10; i >= 3; i--)
                {
                    this.Opacity = 0.1 * i;
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        private void StealthModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StealthMode = this.StealthModeToolStripMenuItem.Checked;
            if (this.AppMode == AppMode.Capture)
            {
                if (this.StealthMode)
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
        }
    }
}
