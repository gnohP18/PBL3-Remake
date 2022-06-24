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
            /*frmDataBase frm = new frmDataBase();
            frm.Show();*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radEmployee.Checked)
            {
                int CheckLogin = NhanVienBLL.Instance.checkLogin(txtUsername.Text, txtPassword.Text, true);
                NoticeBox box;
                if (CheckLogin == -1)
                {
                    box = new NoticeBox("Don't find this account , please check again!!");
                    box.ShowDialog();
                    return;
                }
                if (CheckLogin == 0)
                {
                    box = new NoticeBox("This time is not your work shift!!");
                    box.ShowDialog();
                    return;
                }
                if (CheckLogin == 1)
                {
                    frmMainSeller frm = new frmMainSeller(NhanVienBLL.Instance.GetNhanVienByUserName(txtUsername.Text).ID_User);
                    frm.Show();
                    frm.Owner = this;
                    this.Hide();
                }
            }
            else if (radManager.Checked)
            {
                int CheckLogin = NhanVienBLL.Instance.checkLogin(txtUsername.Text, txtPassword.Text, false);
                NoticeBox box;
                if (CheckLogin != 1)
                {
                    box = new NoticeBox("Don't find this account , please check again!!");
                    box.ShowDialog();
                    return;
                }
                if (CheckLogin == 1)
                {
                    frmMainManager frm = new frmMainManager();
                    frm.Show();
                    frm.Owner = this;
                    this.Hide();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Vui long ...");
            }
        }
    }
}
