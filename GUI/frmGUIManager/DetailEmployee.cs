using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUIManager
{
    public partial class DetailEmployee : Form
    {
        #region Local variable
        public delegate void Mydel();
        public Mydel d { get; set; }
        int ID_User;
        bool isADD;
        #endregion
        public DetailEmployee(int ID_User)
        {
            InitializeComponent();
            this.ID_User = ID_User;
            cbbPosition.Items.AddRange(BLL.NhanVienBLL.Instance.GetAllPosition().ToArray());
            GUI();
        }
        #region Function
        private void GUI()
        {
            User user = BLL.NhanVienBLL.Instance.GetNhanVienByID(ID_User);
            if (user != null)
            {
                isADD = false;
                txtIDEmployee.Text = user.ID_User.ToString();
                txtCIEmployee.Text = user.CMND_CCCD.ToString();
                txtNameEmployee.Text = user.TenUser;
                dtpDayOfBirth.Value = user.NgaySinh;
                dtpDayStartWork.Value = user.NgayBatDauLam;
                dtpDayStartWork.Enabled = false;
                txtPhonenumber.Text = user.SDT;
                pBUser.Image = BLL.ExtensionBLL.Instance.byteArrayToImage(user.AnhUser);
                pBUser.SizeMode = PictureBoxSizeMode.StretchImage;
                cbbPosition.SelectedIndex = cbbPosition.FindStringExact(user.ChucVu.TenChucVu);
                txtUserNameLogin.Text = user.Username;
                txtPasswordLogin.Text = user.Password;
            }
            else
            {
                isADD = true;
                txtIDEmployee.Text = BLL.NhanVienBLL.Instance.GetNewIDUser() + "";
                btnShift.Visible = false;
            }
        }
        #endregion
        #region Event UC function
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isADD == true && BLL.NhanVienBLL.Instance.checkExistUsername(txtUserNameLogin.Text) == true)
            {
                NoticeBox box = new NoticeBox("Username is existed, please input other username!!");
                box.ShowDialog();
                return;
            }
            User user = new User()
            {
                ID_User = this.ID_User,
                TenUser = txtNameEmployee.Text,
                ID_ChucVu = ((ChucVu)(cbbPosition.SelectedItem)).ID_ChucVu,
                CMND_CCCD = txtCIEmployee.Text,
                Username = txtUserNameLogin.Text,
                SDT = txtPhonenumber.Text,
                Password = txtPasswordLogin.Text,
                NgaySinh = dtpDayOfBirth.Value,
                NgayBatDauLam = DateTime.Now,
                AnhUser = BLL.ExtensionBLL.Instance.ImgToByte(pBUser.Image),
            };
            BLL.NhanVienBLL.Instance.Execute(user);
            if (isADD == true)
            {
                frmShift frm = new frmShift(user.ID_User);
                frm.ShowDialog();
            }
            d();
            this.Close();
        }

        private void DetailEmployee_Load(object sender, EventArgs e)
        {

        }
        private void btnChangePicUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBUser.Image = Image.FromFile(ofd.FileName);
                pBUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCIEmployee.Text = "";
            txtPasswordLogin.Text = "";
            txtUserNameLogin.Text = "";
            txtNameEmployee.Text = "";
            dtpDayOfBirth.Value = DateTime.Now;
            dtpDayStartWork.Value = DateTime.Now.AddDays(1);
            txtPhonenumber.Text = "";
            txtCIEmployee.Enabled = true;
            txtNameEmployee.Enabled = true;
            txtPasswordLogin.Enabled = true;
            txtUserNameLogin.Enabled = true;
            btnChangePicUser.Enabled = true;
            dtpDayOfBirth.Enabled = true;
            cbbPosition.Enabled = true;
        }
        #endregion

        private void btnShift_Click(object sender, EventArgs e)
        {
            frmGUIManager.frmShift frm = new frmGUIManager.frmShift(ID_User);
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}