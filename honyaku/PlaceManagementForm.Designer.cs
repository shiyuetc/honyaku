namespace honyaku
{
    partial class PlaceManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceManagementForm));
            this.PlaceListDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationXColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationYColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeWidthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeHeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置項目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeletePlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceListDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaceListDataGridView
            // 
            this.PlaceListDataGridView.AllowUserToAddRows = false;
            this.PlaceListDataGridView.AllowUserToDeleteRows = false;
            this.PlaceListDataGridView.AllowUserToResizeRows = false;
            this.PlaceListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PlaceListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlaceListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PlaceListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaceListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LocationColumn,
            this.SizeColumn,
            this.LocationXColumn,
            this.LocationYColumn,
            this.SizeWidthColumn,
            this.SizeHeightColumn});
            this.PlaceListDataGridView.Location = new System.Drawing.Point(12, 38);
            this.PlaceListDataGridView.MultiSelect = false;
            this.PlaceListDataGridView.Name = "PlaceListDataGridView";
            this.PlaceListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PlaceListDataGridView.RowHeadersVisible = false;
            this.PlaceListDataGridView.RowTemplate.Height = 21;
            this.PlaceListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlaceListDataGridView.Size = new System.Drawing.Size(380, 291);
            this.PlaceListDataGridView.TabIndex = 2;
            this.PlaceListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlaceListDataGridView_CellDoubleClick);
            this.PlaceListDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.PlaceListDataGridView_CellValidating);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "名前";
            this.NameColumn.MinimumWidth = 100;
            this.NameColumn.Name = "NameColumn";
            // 
            // LocationColumn
            // 
            this.LocationColumn.HeaderText = "座標位置";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            this.LocationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SizeColumn
            // 
            this.SizeColumn.HeaderText = "ウィンドウ幅";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            this.SizeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SizeColumn.Width = 150;
            // 
            // LocationXColumn
            // 
            this.LocationXColumn.HeaderText = "Location-X";
            this.LocationXColumn.Name = "LocationXColumn";
            this.LocationXColumn.Visible = false;
            // 
            // LocationYColumn
            // 
            this.LocationYColumn.HeaderText = "Location-Y";
            this.LocationYColumn.Name = "LocationYColumn";
            this.LocationYColumn.Visible = false;
            // 
            // SizeWidthColumn
            // 
            this.SizeWidthColumn.HeaderText = "Size-Width";
            this.SizeWidthColumn.Name = "SizeWidthColumn";
            this.SizeWidthColumn.Visible = false;
            // 
            // SizeHeightColumn
            // 
            this.SizeHeightColumn.HeaderText = "Size-Height";
            this.SizeHeightColumn.Name = "SizeHeightColumn";
            this.SizeHeightColumn.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置項目ToolStripMenuItem,
            this.SetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 配置項目ToolStripMenuItem
            // 
            this.配置項目ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPlaceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.DeletePlaceToolStripMenuItem});
            this.配置項目ToolStripMenuItem.Name = "配置項目ToolStripMenuItem";
            this.配置項目ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.配置項目ToolStripMenuItem.Text = "項目の編集(&E)";
            // 
            // AddPlaceToolStripMenuItem
            // 
            this.AddPlaceToolStripMenuItem.Name = "AddPlaceToolStripMenuItem";
            this.AddPlaceToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.AddPlaceToolStripMenuItem.Text = "現在の配置を記憶(&N)";
            this.AddPlaceToolStripMenuItem.Click += new System.EventHandler(this.AddPlaceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // DeletePlaceToolStripMenuItem
            // 
            this.DeletePlaceToolStripMenuItem.Name = "DeletePlaceToolStripMenuItem";
            this.DeletePlaceToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.DeletePlaceToolStripMenuItem.Text = "選択項目を削除(&D)";
            this.DeletePlaceToolStripMenuItem.Click += new System.EventHandler(this.DeletePlaceToolStripMenuItem_Click);
            // 
            // SetToolStripMenuItem
            // 
            this.SetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SetToolStripMenuItem.Image")));
            this.SetToolStripMenuItem.Name = "SetToolStripMenuItem";
            this.SetToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.SetToolStripMenuItem.Text = "配置(&P)";
            this.SetToolStripMenuItem.Click += new System.EventHandler(this.SetToolStripMenuItem_Click);
            // 
            // PlaceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 341);
            this.Controls.Add(this.PlaceListDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlaceManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ウィンドウ配置管理";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaceManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.PlaceManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlaceListDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PlaceListDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配置項目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeletePlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationXColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationYColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeWidthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeHeightColumn;
    }
}