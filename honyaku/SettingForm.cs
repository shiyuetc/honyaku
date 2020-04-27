using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace honyaku
{
    public partial class SettingForm : Form
    {
        public bool IsEdit { get; private set; } = false;

        public bool IsApply { get; private set; } = false;

        private Font TempResultFont { get; set; }

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            // 言語設定
            foreach (KeyValuePair<string, Language> language in DataProperty.Languages)
            {
                this.SourceLanguageComboBox.Items.Add(language.Value.JapaneseName);
                this.TargetLanguageComboBox.Items.Add(language.Value.JapaneseName);
            }
            this.SourceLanguageComboBox.SelectedIndex = -1;
            this.TargetLanguageComboBox.SelectedIndex = -1;
            this.SourceLanguageComboBox.Text = DataProperty.Languages[Setting.SourceLanguage].JapaneseName;
            this.TargetLanguageComboBox.Text = DataProperty.Languages[Setting.TargetLanguage].JapaneseName;

            this.BackPlaceCheckBox.Checked = Setting.BackPlace;
            this.ReturnFocusCheckBox.Checked = Setting.ReturnFocus;

            // キャプチャ領域枠
            this.CaptureRegionMarginNumericUpDown.Value = Setting.CaptureRegionMargin;
            this.CaptureRegionVisibleCheckBox.Checked = Setting.CaptureRegionVisible;
            this.CaptureRegionColorButton.Text = String.Format("#{0:X2}{1:X2}{2:X2}", Setting.CaptureRegionColor.R, Setting.CaptureRegionColor.G, Setting.CaptureRegionColor.B);
            this.CaptureRegionColorButton.BackColor = Setting.CaptureRegionColor;

            this.CaptureSaveCheckBox.Checked = Setting.CaptureSave;

            // 書式
            this.TempResultFont = Setting.ResultFont;
            this.ResultFontTextBox.Text = Setting.ResultFont.ToString();

            this.IsEdit = false;
        }

        private void Apply()
        {
            Setting.CaptureRegionVisible = this.CaptureRegionVisibleCheckBox.Checked;
            Setting.CaptureRegionColor = this.CaptureRegionColorButton.BackColor;
            Setting.CaptureRegionMargin = (int)this.CaptureRegionMarginNumericUpDown.Value;
            Setting.CaptureSave = this.CaptureSaveCheckBox.Checked;
            Setting.ResultFont = this.TempResultFont;
            Setting.Save();
            this.IsEdit = false;
            this.IsApply = true;
        }

        private void DefaultSettingButton_Click(object sender, EventArgs e)
        {
            this.SourceLanguageComboBox.Text = "英語";
            this.TargetLanguageComboBox.Text = "日本語";
            this.CaptureRegionVisibleCheckBox.Checked = true;
            this.CaptureRegionColorButton.Text = "#FF0000";
            this.CaptureRegionColorButton.BackColor = Color.Red;
            this.CaptureRegionMarginNumericUpDown.Value = 6;
            this.CaptureSaveCheckBox.Checked = false;
            this.TempResultFont = new Font("ＭＳ ゴシック", 12);
            this.ResultFontTextBox.Text = this.TempResultFont.ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if(this.IsEdit)
            {
                DialogResult result = MessageBox.Show("変更した設定を保存しますか?", "質問", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) this.Apply();
                else if (result == DialogResult.Cancel) return;
            }
            this.Close();
        }

        private void CaptureRegionColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.CaptureRegionColorButton.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.CaptureRegionColorButton.Text = String.Format("#{0:X2}{1:X2}{2:X2}", cd.Color.R, cd.Color.G, cd.Color.B);
                this.CaptureRegionColorButton.BackColor = cd.Color;
                this.IsEdit = true;
            }
        }

        private void ChangeResultFontButton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = Setting.ResultFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.TempResultFont = fd.Font;
                this.ResultFontTextBox.Text = fd.Font.ToString();
                this.IsEdit = true;
            }
        }

        private void ReturnFocusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }

        private void BackPlaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }

        private void CaptureRegionVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }
    }
}
