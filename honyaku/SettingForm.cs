using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace honyaku
{
    public partial class SettingForm : Form
    {
        /// <summary>
        /// 設定を変更したかどうか
        /// </summary>
        public bool IsEdit { get; private set; } = false;

        /// <summary>
        /// 設定の更新を反映したかどうか
        /// </summary>
        public bool IsApply { get; private set; } = false;

        /// <summary>
        /// 
        /// </summary>
        private Font TempResultFont { get; set; }
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SettingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
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


        /// <summary>
        /// フォームの終了イベント
        /// </summary>
        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.IsEdit)
            {
                DialogResult result = MessageBox.Show("変更した設定を保存しますか?", "質問", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if ((result == DialogResult.Yes && !this.Apply()) || result == DialogResult.Cancel) e.Cancel = true;
            }
        }

        /// <summary>
        /// 更新内容の反映
        /// </summary>
        private bool Apply()
        {
            string sourceLanguage = DataProperty.Languages.FirstOrDefault(c => c.Value.JapaneseName == this.SourceLanguageComboBox.SelectedItem.ToString()).Key;
            string targetLanguage = DataProperty.Languages.FirstOrDefault(c => c.Value.JapaneseName == this.TargetLanguageComboBox.SelectedItem.ToString()).Key;
            if (sourceLanguage == targetLanguage)
            {
                MessageBox.Show("キャプチャする元の言語と翻訳後の言語はそれぞれ別の言語に設定する必要があります。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Setting.SourceLanguage = sourceLanguage;
            Setting.TargetLanguage = targetLanguage;

            Setting.ReturnFocus = this.ReturnFocusCheckBox.Checked;
            Setting.BackPlace = this.BackPlaceCheckBox.Checked;

            Setting.CaptureRegionMargin = (int)this.CaptureRegionMarginNumericUpDown.Value;
            Setting.CaptureRegionVisible = this.CaptureRegionVisibleCheckBox.Checked;
            Setting.CaptureRegionColor = this.CaptureRegionColorButton.BackColor;
            Setting.CaptureSave = this.CaptureSaveCheckBox.Checked;

            Setting.ResultFont = this.TempResultFont;

            Setting.Save();
            this.IsEdit = false;
            this.IsApply = true;
            return true;
        }

        /// <summary>
        /// 設定初期化ボタンのクリックイベント
        /// </summary>
        private void DefaultSettingButton_Click(object sender, EventArgs e)
        {
            this.SourceLanguageComboBox.Text = "英語";
            this.TargetLanguageComboBox.Text = "日本語";

            this.CaptureRegionMarginNumericUpDown.Value = 6;
            this.CaptureRegionVisibleCheckBox.Checked = true;
            this.CaptureRegionColorButton.Text = "#FF0000";
            this.CaptureRegionColorButton.BackColor = Color.Red;
            this.CaptureSaveCheckBox.Checked = false;

            this.TempResultFont = new Font("ＭＳ ゴシック", 12);
            this.ResultFontTextBox.Text = this.TempResultFont.ToString();
            this.IsEdit = true;
        }

        /// <summary>
        /// 適用ボタンのクリックイベント
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.Apply();
        }

        /// <summary>
        /// キャンセルボタンのクリックイベント
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SourceLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void TargetLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }

        /// <summary>
        /// 起動時に前回の位置に配置するチェックボックスの値変更イベント
        /// </summary>
        private void BackPlaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }
        
        /// <summary>
        /// 翻訳完了時に後ろのアプリケーションをアクティブにするチェックボックスの値変更イベント
        /// </summary>
        private void ReturnFocusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CaptureRegionMarginNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.IsEdit = true;
        }

        /// <summary>
        /// 領域線を表示するチェックボックスの値変更イベント
        /// </summary>
        private void CaptureRegionVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Enabled = this.CaptureRegionVisibleCheckBox.Checked;
            this.CaptureRegionColorButton.Enabled = this.CaptureRegionVisibleCheckBox.Checked;
            this.IsEdit = true;
        }

        /// <summary>
        /// 領域枠の色ボタンのクリックイベント
        /// </summary>
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

        /// <summary>
        /// 書式変更ボタンのクリックイベント
        /// </summary>
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
    }
}
