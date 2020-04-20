namespace honyaku
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TranslateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReTranslateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.翻訳コンテナToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LateralSplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalitySplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientPanel = new System.Windows.Forms.Panel();
            this.TranslatorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SourceLanguageLabel = new System.Windows.Forms.Label();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.TargetLanguageLabel = new System.Windows.Forms.Label();
            this.TargetTextBox = new System.Windows.Forms.TextBox();
            this.StealthModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranslatorSplitContainer)).BeginInit();
            this.TranslatorSplitContainer.Panel1.SuspendLayout();
            this.TranslatorSplitContainer.Panel2.SuspendLayout();
            this.TranslatorSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem,
            this.TranslateToolStripMenuItem,
            this.ReTranslateToolStripMenuItem,
            this.表示VToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BackToolStripMenuItem.Image")));
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.BackToolStripMenuItem.Text = "戻る";
            this.BackToolStripMenuItem.Visible = false;
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // TranslateToolStripMenuItem
            // 
            this.TranslateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TranslateToolStripMenuItem.Image")));
            this.TranslateToolStripMenuItem.Name = "TranslateToolStripMenuItem";
            this.TranslateToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.TranslateToolStripMenuItem.Text = "キャプチャ+翻訳";
            this.TranslateToolStripMenuItem.Click += new System.EventHandler(this.TranslateToolStripMenuItem_Click);
            // 
            // ReTranslateToolStripMenuItem
            // 
            this.ReTranslateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReTranslateToolStripMenuItem.Image")));
            this.ReTranslateToolStripMenuItem.Name = "ReTranslateToolStripMenuItem";
            this.ReTranslateToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ReTranslateToolStripMenuItem.Text = "再翻訳";
            this.ReTranslateToolStripMenuItem.Visible = false;
            this.ReTranslateToolStripMenuItem.Click += new System.EventHandler(this.ReTranslateToolStripMenuItem_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StealthModeToolStripMenuItem,
            this.翻訳コンテナToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.表示VToolStripMenuItem.Text = "表示(&V)";
            // 
            // 翻訳コンテナToolStripMenuItem
            // 
            this.翻訳コンテナToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LateralSplitToolStripMenuItem,
            this.VerticalitySplitToolStripMenuItem});
            this.翻訳コンテナToolStripMenuItem.Name = "翻訳コンテナToolStripMenuItem";
            this.翻訳コンテナToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.翻訳コンテナToolStripMenuItem.Text = "翻訳コンテナ";
            // 
            // LateralSplitToolStripMenuItem
            // 
            this.LateralSplitToolStripMenuItem.Checked = true;
            this.LateralSplitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LateralSplitToolStripMenuItem.Name = "LateralSplitToolStripMenuItem";
            this.LateralSplitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.LateralSplitToolStripMenuItem.Text = "左右に分割";
            this.LateralSplitToolStripMenuItem.Click += new System.EventHandler(this.LateralSplitToolStripMenuItem_Click);
            // 
            // VerticalitySplitToolStripMenuItem
            // 
            this.VerticalitySplitToolStripMenuItem.Name = "VerticalitySplitToolStripMenuItem";
            this.VerticalitySplitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.VerticalitySplitToolStripMenuItem.Text = "上下に分割";
            this.VerticalitySplitToolStripMenuItem.Click += new System.EventHandler(this.VerticalitySplitToolStripMenuItem_Click);
            // 
            // ClientPanel
            // 
            this.ClientPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientPanel.Location = new System.Drawing.Point(6, 24);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(490, 312);
            this.ClientPanel.TabIndex = 2;
            // 
            // TranslatorSplitContainer
            // 
            this.TranslatorSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TranslatorSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.TranslatorSplitContainer.Name = "TranslatorSplitContainer";
            // 
            // TranslatorSplitContainer.Panel1
            // 
            this.TranslatorSplitContainer.Panel1.Controls.Add(this.SourceLanguageLabel);
            this.TranslatorSplitContainer.Panel1.Controls.Add(this.SourceTextBox);
            this.TranslatorSplitContainer.Panel1MinSize = 0;
            // 
            // TranslatorSplitContainer.Panel2
            // 
            this.TranslatorSplitContainer.Panel2.Controls.Add(this.TargetLanguageLabel);
            this.TranslatorSplitContainer.Panel2.Controls.Add(this.TargetTextBox);
            this.TranslatorSplitContainer.Panel2MinSize = 0;
            this.TranslatorSplitContainer.Size = new System.Drawing.Size(502, 318);
            this.TranslatorSplitContainer.SplitterDistance = 250;
            this.TranslatorSplitContainer.SplitterWidth = 2;
            this.TranslatorSplitContainer.TabIndex = 3;
            this.TranslatorSplitContainer.Visible = false;
            // 
            // SourceLanguageLabel
            // 
            this.SourceLanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SourceLanguageLabel.AutoSize = true;
            this.SourceLanguageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SourceLanguageLabel.Location = new System.Drawing.Point(3, 301);
            this.SourceLanguageLabel.Name = "SourceLanguageLabel";
            this.SourceLanguageLabel.Size = new System.Drawing.Size(44, 14);
            this.SourceLanguageLabel.TabIndex = 2;
            this.SourceLanguageLabel.Text = "English";
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SourceTextBox.Location = new System.Drawing.Point(0, 0);
            this.SourceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SourceTextBox.MaxLength = 1000;
            this.SourceTextBox.Multiline = true;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(250, 318);
            this.SourceTextBox.TabIndex = 1;
            // 
            // TargetLanguageLabel
            // 
            this.TargetLanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TargetLanguageLabel.AutoSize = true;
            this.TargetLanguageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TargetLanguageLabel.Location = new System.Drawing.Point(3, 301);
            this.TargetLanguageLabel.Name = "TargetLanguageLabel";
            this.TargetLanguageLabel.Size = new System.Drawing.Size(43, 14);
            this.TargetLanguageLabel.TabIndex = 3;
            this.TargetLanguageLabel.Text = "日本語";
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TargetTextBox.Location = new System.Drawing.Point(0, 0);
            this.TargetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TargetTextBox.Multiline = true;
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.ReadOnly = true;
            this.TargetTextBox.Size = new System.Drawing.Size(250, 318);
            this.TargetTextBox.TabIndex = 1;
            // 
            // StealthModeToolStripMenuItem
            // 
            this.StealthModeToolStripMenuItem.CheckOnClick = true;
            this.StealthModeToolStripMenuItem.Name = "StealthModeToolStripMenuItem";
            this.StealthModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StealthModeToolStripMenuItem.Text = "ステルスモード";
            this.StealthModeToolStripMenuItem.Click += new System.EventHandler(this.StealthModeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 342);
            this.Controls.Add(this.TranslatorSplitContainer);
            this.Controls.Add(this.ClientPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(200, 88);
            this.Name = "MainForm";
            this.Text = "Honyaku";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ControlDark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TranslatorSplitContainer.Panel1.ResumeLayout(false);
            this.TranslatorSplitContainer.Panel1.PerformLayout();
            this.TranslatorSplitContainer.Panel2.ResumeLayout(false);
            this.TranslatorSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranslatorSplitContainer)).EndInit();
            this.TranslatorSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel ClientPanel;
        private System.Windows.Forms.ToolStripMenuItem TranslateToolStripMenuItem;
        private System.Windows.Forms.SplitContainer TranslatorSplitContainer;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox TargetTextBox;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReTranslateToolStripMenuItem;
        private System.Windows.Forms.Label SourceLanguageLabel;
        private System.Windows.Forms.Label TargetLanguageLabel;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 翻訳コンテナToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LateralSplitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerticalitySplitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StealthModeToolStripMenuItem;
    }
}

