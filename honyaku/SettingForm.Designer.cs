namespace honyaku
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaptureRegionMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CaptureRegionVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SourceLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.TargetLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CaptureRegionColorButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BackPlaceCheckBox = new System.Windows.Forms.CheckBox();
            this.ReturnFocusCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CaptureSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.HotAltKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HotKeysComboBox = new System.Windows.Forms.ComboBox();
            this.HotCtrlKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.HotShiftKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ResultFontTextBox = new System.Windows.Forms.TextBox();
            this.ChangeResultFontButton = new System.Windows.Forms.Button();
            this.DefaultSettingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureRegionMarginNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "翻訳後の言語：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "キャプチャする元の言語：";
            // 
            // CaptureRegionMarginNumericUpDown
            // 
            this.CaptureRegionMarginNumericUpDown.Location = new System.Drawing.Point(94, 89);
            this.CaptureRegionMarginNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.CaptureRegionMarginNumericUpDown.Name = "CaptureRegionMarginNumericUpDown";
            this.CaptureRegionMarginNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.CaptureRegionMarginNumericUpDown.TabIndex = 3;
            this.CaptureRegionMarginNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // CaptureRegionVisibleCheckBox
            // 
            this.CaptureRegionVisibleCheckBox.AutoSize = true;
            this.CaptureRegionVisibleCheckBox.Checked = true;
            this.CaptureRegionVisibleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CaptureRegionVisibleCheckBox.Location = new System.Drawing.Point(17, 27);
            this.CaptureRegionVisibleCheckBox.Name = "CaptureRegionVisibleCheckBox";
            this.CaptureRegionVisibleCheckBox.Size = new System.Drawing.Size(112, 16);
            this.CaptureRegionVisibleCheckBox.TabIndex = 2;
            this.CaptureRegionVisibleCheckBox.Text = "領域線を表示する";
            this.CaptureRegionVisibleCheckBox.UseVisualStyleBackColor = true;
            this.CaptureRegionVisibleCheckBox.CheckedChanged += new System.EventHandler(this.CaptureRegionVisibleCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "領域線カラー：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "領域マージン：";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(237, 326);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "キャンセル(&C)";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(156, 326);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "適用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SourceLanguageComboBox
            // 
            this.SourceLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceLanguageComboBox.FormattingEnabled = true;
            this.SourceLanguageComboBox.Location = new System.Drawing.Point(17, 42);
            this.SourceLanguageComboBox.Name = "SourceLanguageComboBox";
            this.SourceLanguageComboBox.Size = new System.Drawing.Size(121, 20);
            this.SourceLanguageComboBox.TabIndex = 3;
            // 
            // TargetLanguageComboBox
            // 
            this.TargetLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetLanguageComboBox.FormattingEnabled = true;
            this.TargetLanguageComboBox.Location = new System.Drawing.Point(165, 42);
            this.TargetLanguageComboBox.Name = "TargetLanguageComboBox";
            this.TargetLanguageComboBox.Size = new System.Drawing.Size(121, 20);
            this.TargetLanguageComboBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TargetLanguageComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SourceLanguageComboBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "翻訳言語";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "→";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CaptureRegionColorButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CaptureRegionMarginNumericUpDown);
            this.groupBox2.Controls.Add(this.CaptureRegionVisibleCheckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "領域枠";
            // 
            // CaptureRegionColorButton
            // 
            this.CaptureRegionColorButton.Location = new System.Drawing.Point(110, 46);
            this.CaptureRegionColorButton.Name = "CaptureRegionColorButton";
            this.CaptureRegionColorButton.Size = new System.Drawing.Size(75, 23);
            this.CaptureRegionColorButton.TabIndex = 5;
            this.CaptureRegionColorButton.Text = "#FF0000";
            this.CaptureRegionColorButton.UseVisualStyleBackColor = true;
            this.CaptureRegionColorButton.Click += new System.EventHandler(this.CaptureRegionColorButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 308);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BackPlaceCheckBox);
            this.groupBox4.Controls.Add(this.ReturnFocusCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 102);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "その他";
            // 
            // BackPlaceCheckBox
            // 
            this.BackPlaceCheckBox.AutoSize = true;
            this.BackPlaceCheckBox.Location = new System.Drawing.Point(17, 72);
            this.BackPlaceCheckBox.Name = "BackPlaceCheckBox";
            this.BackPlaceCheckBox.Size = new System.Drawing.Size(179, 16);
            this.BackPlaceCheckBox.TabIndex = 12;
            this.BackPlaceCheckBox.Text = "起動時に前回の位置に配置する";
            this.BackPlaceCheckBox.UseVisualStyleBackColor = true;
            this.BackPlaceCheckBox.CheckedChanged += new System.EventHandler(this.BackPlaceCheckBox_CheckedChanged);
            // 
            // ReturnFocusCheckBox
            // 
            this.ReturnFocusCheckBox.AutoSize = true;
            this.ReturnFocusCheckBox.Checked = true;
            this.ReturnFocusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReturnFocusCheckBox.Location = new System.Drawing.Point(17, 50);
            this.ReturnFocusCheckBox.Name = "ReturnFocusCheckBox";
            this.ReturnFocusCheckBox.Size = new System.Drawing.Size(272, 16);
            this.ReturnFocusCheckBox.TabIndex = 6;
            this.ReturnFocusCheckBox.Text = "翻訳完了時に後ろのアプリケーションをアクティブにする";
            this.ReturnFocusCheckBox.UseVisualStyleBackColor = true;
            this.ReturnFocusCheckBox.CheckedChanged += new System.EventHandler(this.ReturnFocusCheckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "キャプチャ設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CaptureSaveCheckBox);
            this.groupBox6.Location = new System.Drawing.Point(7, 236);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 40);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "その他";
            // 
            // CaptureSaveCheckBox
            // 
            this.CaptureSaveCheckBox.AutoSize = true;
            this.CaptureSaveCheckBox.Location = new System.Drawing.Point(16, 18);
            this.CaptureSaveCheckBox.Name = "CaptureSaveCheckBox";
            this.CaptureSaveCheckBox.Size = new System.Drawing.Size(162, 16);
            this.CaptureSaveCheckBox.TabIndex = 14;
            this.CaptureSaveCheckBox.Text = "キャプチャした画像を保存する";
            this.CaptureSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.HotAltKeyCheckBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.HotKeysComboBox);
            this.groupBox5.Controls.Add(this.HotCtrlKeyCheckBox);
            this.groupBox5.Controls.Add(this.HotShiftKeyCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 99);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "キャプチャショートカット";
            // 
            // HotAltKeyCheckBox
            // 
            this.HotAltKeyCheckBox.AutoSize = true;
            this.HotAltKeyCheckBox.Location = new System.Drawing.Point(121, 38);
            this.HotAltKeyCheckBox.Name = "HotAltKeyCheckBox";
            this.HotAltKeyCheckBox.Size = new System.Drawing.Size(39, 16);
            this.HotAltKeyCheckBox.TabIndex = 9;
            this.HotAltKeyCheckBox.Text = "Alt";
            this.HotAltKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "ホットキー：";
            // 
            // HotKeysComboBox
            // 
            this.HotKeysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotKeysComboBox.FormattingEnabled = true;
            this.HotKeysComboBox.Location = new System.Drawing.Point(18, 60);
            this.HotKeysComboBox.Name = "HotKeysComboBox";
            this.HotKeysComboBox.Size = new System.Drawing.Size(75, 20);
            this.HotKeysComboBox.TabIndex = 10;
            // 
            // HotCtrlKeyCheckBox
            // 
            this.HotCtrlKeyCheckBox.AutoSize = true;
            this.HotCtrlKeyCheckBox.Location = new System.Drawing.Point(18, 38);
            this.HotCtrlKeyCheckBox.Name = "HotCtrlKeyCheckBox";
            this.HotCtrlKeyCheckBox.Size = new System.Drawing.Size(43, 16);
            this.HotCtrlKeyCheckBox.TabIndex = 7;
            this.HotCtrlKeyCheckBox.Text = "Ctrl";
            this.HotCtrlKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HotShiftKeyCheckBox
            // 
            this.HotShiftKeyCheckBox.AutoSize = true;
            this.HotShiftKeyCheckBox.Location = new System.Drawing.Point(67, 38);
            this.HotShiftKeyCheckBox.Name = "HotShiftKeyCheckBox";
            this.HotShiftKeyCheckBox.Size = new System.Drawing.Size(48, 16);
            this.HotShiftKeyCheckBox.TabIndex = 8;
            this.HotShiftKeyCheckBox.Text = "Shift";
            this.HotShiftKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(317, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "翻訳コンテナ設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ResultFontTextBox);
            this.groupBox3.Controls.Add(this.ChangeResultFontButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 82);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "書式";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "フォント：";
            // 
            // ResultFontTextBox
            // 
            this.ResultFontTextBox.BackColor = System.Drawing.Color.White;
            this.ResultFontTextBox.Location = new System.Drawing.Point(17, 42);
            this.ResultFontTextBox.Name = "ResultFontTextBox";
            this.ResultFontTextBox.ReadOnly = true;
            this.ResultFontTextBox.Size = new System.Drawing.Size(192, 19);
            this.ResultFontTextBox.TabIndex = 2;
            // 
            // ChangeResultFontButton
            // 
            this.ChangeResultFontButton.Location = new System.Drawing.Point(212, 40);
            this.ChangeResultFontButton.Name = "ChangeResultFontButton";
            this.ChangeResultFontButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeResultFontButton.TabIndex = 0;
            this.ChangeResultFontButton.Text = "変更";
            this.ChangeResultFontButton.UseVisualStyleBackColor = true;
            this.ChangeResultFontButton.Click += new System.EventHandler(this.ChangeResultFontButton_Click);
            // 
            // DefaultSettingButton
            // 
            this.DefaultSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultSettingButton.Location = new System.Drawing.Point(50, 326);
            this.DefaultSettingButton.Name = "DefaultSettingButton";
            this.DefaultSettingButton.Size = new System.Drawing.Size(100, 23);
            this.DefaultSettingButton.TabIndex = 8;
            this.DefaultSettingButton.Text = "設定初期化";
            this.DefaultSettingButton.UseVisualStyleBackColor = true;
            this.DefaultSettingButton.Click += new System.EventHandler(this.DefaultSettingButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 361);
            this.Controls.Add(this.DefaultSettingButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "設定";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptureRegionMarginNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.NumericUpDown CaptureRegionMarginNumericUpDown;
        private System.Windows.Forms.CheckBox CaptureRegionVisibleCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TargetLanguageComboBox;
        private System.Windows.Forms.ComboBox SourceLanguageComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ReturnFocusCheckBox;
        private System.Windows.Forms.Button DefaultSettingButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChangeResultFontButton;
        private System.Windows.Forms.TextBox ResultFontTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox BackPlaceCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox HotAltKeyCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HotKeysComboBox;
        private System.Windows.Forms.CheckBox HotCtrlKeyCheckBox;
        private System.Windows.Forms.CheckBox HotShiftKeyCheckBox;
        private System.Windows.Forms.Button CaptureRegionColorButton;
        private System.Windows.Forms.CheckBox CaptureSaveCheckBox;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}