using System;
using System.Windows.Forms;

namespace PBL3_Remake.GUI.frmGUIUserControl
{
    public partial class DetailEmployee : Form
    {
        public DetailEmployee()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailEmployee_Load(object sender, EventArgs e)
        {
            txtCIEmployee.Enabled = false;
            txtIDEmployee.Enabled = false;
            txtNameEmployee.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCIEmployee.Enabled = true;
            txtIDEmployee.Enabled = true;
            txtNameEmployee.Enabled = true;
        }
    }
}
