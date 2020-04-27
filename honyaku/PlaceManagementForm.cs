using System;
using System.Drawing;
using System.Windows.Forms;

namespace honyaku
{
    /// <summary>
    /// ウィンドウ配置管理フォーム
    /// </summary>
    public partial class PlaceManagementForm : Form
    {
        /// <summary>
        /// メインのフォーム
        /// </summary>
        private MainForm MainForm;

        /// <summary>
        /// 編集フラグ
        /// </summary>
        public bool IsEdit { get; private set; } = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mainForm">メインのフォーム</param>
        public PlaceManagementForm(MainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void PlaceManagementForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(DataProperty.PlacesFile))
            {
                try
                {
                    System.Xml.Serialization.XmlSerializer serializer =
                        new System.Xml.Serialization.XmlSerializer(typeof(Place[]));
                    System.IO.StreamReader sr = new System.IO.StreamReader(DataProperty.PlacesFile, new System.Text.UTF8Encoding(false));
                    Place[] places = (Place[])serializer.Deserialize(sr);
                    sr.Close();

                    DataGridViewRow[] rows = new DataGridViewRow[places.Length];
                    for (int i = 0; i < places.Length; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(this.PlaceListDataGridView);
                        row.SetValues(places[i].Name, places[i].Location.ToString(), places[i].Size.ToString(),
                            places[i].Location.X, places[i].Location.Y, places[i].Size.Width, places[i].Size.Height);
                        rows[i] = row;
                    }
                    this.PlaceListDataGridView.Rows.AddRange(rows);
                }
                catch
                {
                    MessageBox.Show("配置データの読み込みに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// フォームの終了イベント
        /// </summary>
        private void PlaceManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.IsEdit)
            {
                try
                {
                    Place[] places = new Place[this.PlaceListDataGridView.Rows.Count];
                    for (int i = 0; i < this.PlaceListDataGridView.Rows.Count; i++)
                    {
                        DataGridViewRow row = this.PlaceListDataGridView.Rows[i];
                        places[i] = new Place(row.Cells["NameColumn"].Value.ToString(),
                            new Point((int)row.Cells["LocationXColumn"].Value, (int)row.Cells["LocationYColumn"].Value),
                            new Size((int)row.Cells["SizeWidthColumn"].Value, (int)row.Cells["SizeHeightColumn"].Value));
                    }

                    System.Xml.Serialization.XmlSerializer serializer =
                        new System.Xml.Serialization.XmlSerializer(typeof(Place[]));
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(DataProperty.PlacesFile, false, new System.Text.UTF8Encoding(false));
                    serializer.Serialize(sw, places);
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("配置データの書き込みに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 現在の配置を記憶ボタンのクリックイベント
        /// </summary>
        private void AddPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PlaceListDataGridView.Rows.Add("配置" + (this.PlaceListDataGridView.Rows.Count + 1), this.MainForm.Location.ToString(), this.MainForm.Size.ToString(),
            this.MainForm.Location.X, this.MainForm.Location.Y, this.MainForm.Size.Width, this.MainForm.Size.Height);
            this.IsEdit = true;
        }

        /// <summary>
        /// 選択項目を削除ボタンのクリックイベント
        /// </summary>
        private void DeletePlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.PlaceListDataGridView.SelectedRows.Count == 1)
            {
                this.PlaceListDataGridView.Rows.Remove(this.PlaceListDataGridView.SelectedRows[0]);
                this.IsEdit = true;
            }
        }

        /// <summary>
        /// 配置ボタンのクリックイベント
        /// </summary>
        private void SetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.PlaceListDataGridView.SelectedRows.Count == 1)
            {
                var row = this.PlaceListDataGridView.SelectedRows[0];
                this.MainForm.Location = new Point((int)row.Cells["LocationXColumn"].Value, (int)row.Cells["LocationYColumn"].Value);
                this.MainForm.Size = new Size((int)row.Cells["SizeWidthColumn"].Value, (int)row.Cells["SizeHeightColumn"].Value);
            }
        }

        /// <summary>
        /// セルの値変更イベント
        /// </summary>
        private void PlaceListDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            this.IsEdit = true;
        }

        /// <summary>
        /// セルのダブルクリックイベント
        /// </summary>
        private void PlaceListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.PlaceListDataGridView.Rows[e.RowIndex];
                this.MainForm.Location = new Point((int)row.Cells["LocationXColumn"].Value, (int)row.Cells["LocationYColumn"].Value);
                this.MainForm.Size = new Size((int)row.Cells["SizeWidthColumn"].Value, (int)row.Cells["SizeHeightColumn"].Value);
            }
        }
    }
}
