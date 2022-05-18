using System;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class WareHouseUC : UserControl
    {
        public WareHouseUC()
        {
            InitializeComponent();
        }

        private void btnMoreInfor_Click(object sender, EventArgs e)
        {
            frmGUIUserControl.InfoFood frm = new frmGUIUserControl.InfoFood();
            frm.Show();
        }

        private void btnAddNewManuFacturer_Click(object sender, EventArgs e)
        {
            frmGUIUserControl.AddNewManufacturer frm = new frmGUIUserControl.AddNewManufacturer();
            frm.Show();
        }
    }
}
