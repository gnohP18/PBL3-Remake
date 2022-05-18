using System;
using System.Windows.Forms;
using GUI.frmGUIManager;
using GUI.frmGUISeller;
namespace GUI.frmGUILogin
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
                frmMainSeller frm = new frmMainSeller();
                frm.Show();
            }
            else
            {
                frmMainManager frm = new frmMainManager();
                frm.Show();
            }
        }
    }
}
