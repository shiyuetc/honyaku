using System;
using System.Windows.Forms;

namespace honyaku
{
    public partial class SettingForm : Form
    {


        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.CaptureRegionMarginNumericUpDown.Value = (int)Properties.Settings.Default["capture_region_margin"];
            this.CaptureRegionVisibleCheckBox.Checked = (bool)Properties.Settings.Default["capture_region_visible"];
            //this.CaptureRegionColor = (Color)Properties.Settings.Default["capture_region_color"];
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
