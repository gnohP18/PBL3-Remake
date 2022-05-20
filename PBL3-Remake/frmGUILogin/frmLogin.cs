using BLL;
using GUI.frmGUIManager;
using GUI.frmGUISeller;
using System;
using System.Windows.Forms;
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
                //this.Close();
            }
            else if (radManager.Checked)
            {
                if (BLLQLNH.Instance.checkLoginManager(txtUsername.Text, txtPassword.Text) == false)
                {
                    MessageBox.Show("Login information is not correct!!");
                    return;
                }
                //this.Visible = false;
                frmMainManager frm = new frmMainManager();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Vui long ...");
            }
        }
    }
}
