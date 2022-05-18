using System;
using System.Windows.Forms;

namespace PBL3_Remake.GUI.frmGUILogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnectToDataBase_Click(object sender, EventArgs e)
        {
            frmDataBase frm = new frmDataBase();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radEmployee.Checked)
            {
                frmGUISeller.frmMainSeller frm = new frmGUISeller.frmMainSeller();
                frm.Show();
            }
            else
            {
                frmGUIManager.frmMainManager frm = new frmGUIManager.frmMainManager();
                frm.Show();
            }
        }
    }
}
