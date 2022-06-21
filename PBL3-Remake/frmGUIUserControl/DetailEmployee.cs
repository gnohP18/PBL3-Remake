using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class DetailEmployee : Form
    {
        #region Local variable
        public delegate void Mydel();
        public Mydel d { get; set; }
        private User _ID_User { get; set; }
        private int flag { get; set; }
        private Image img;
        private List<string> ListNamePosition = new List<string>();
        #endregion
        public DetailEmployee(int ID_User)
        {
            if (ID_User != -1)
            {
                _ID_User = BLL.NhanVienBLL.Instance.GetNhanVienByID(ID_User);
                flag = 0;
            }
            else if (ID_User == -1)
            {
                flag = 1;
            }
            else if (ID_User == 0)
            {
                flag = 2;
                btnRefresh.Visible = true;
            }
            InitializeComponent();
            GUI();
        }
        #region Function
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private byte[] ImgToByte(System.Drawing.Image img)
        {
            var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] imgbyte = ms.ToArray();
            return imgbyte;
        }
        private void AddNamePosition()
        {
            foreach (ChucVu i in BLL.NhanVienBLL.Instance.GetAllPosition())
            {
                ListNamePosition.Add(i.TenChucVu);
                cbbPosition.Items.Add(i.TenChucVu);
            }
            AutoCompleteStringCollection autoNamePosition = new AutoCompleteStringCollection();
            cbbPosition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPosition.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (string i in ListNamePosition)
            {
                autoNamePosition.Add(i);
            }
            cbbPosition.AutoCompleteCustomSource = autoNamePosition;
        }
        private void GUI()
        {
            if (flag == 0)
            {
                txtIDEmployee.Text = _ID_User.ID_User.ToString();
                txtCIEmployee.Text = _ID_User.CMND_CCCD.ToString();
                txtNameEmployee.Text = _ID_User.TenUser;
                dtpDayOfBirth.Value = _ID_User.NgaySinh;
                dtpDayStartWork.Value = _ID_User.NgayBatDauLam;
                dtpDayStartWork.Enabled = false;
                txtPhonenumber.Text = _ID_User.SDT;
                lblNumberOfDayWork.Text = BLL.NhanVienBLL.Instance.GetNumberOfDayWorkByID_User(_ID_User.ID_User).ToString();
                pBUser.Image = byteArrayToImage(_ID_User.AnhUser);
                cbbPosition.Text = _ID_User.ChucVu.TenChucVu;
                txtUserNameLogin.Text = _ID_User.Username;
                txtPasswordLogin.Text = _ID_User.Password;
            }
            if (flag == 1)
            {
                txtIDEmployee.Text = (BLL.NhanVienBLL.Instance.GetAllUser().Count + 1).ToString();
                txtCIEmployee.Text = "";
                txtPasswordLogin.Text = "";
                txtUserNameLogin.Text = "";
                txtNameEmployee.Text = "";
                dtpDayOfBirth.Value = DateTime.Now;
                dtpDayStartWork.Value = DateTime.Now.AddDays(1);
                txtPhonenumber.Text = "";
                lblNumberOfDayWork.Text = "0";
                txtCIEmployee.Enabled = true;
                txtNameEmployee.Enabled = true;
                txtPasswordLogin.Enabled = true;
                txtUserNameLogin.Enabled = true;
                btnChangePicUser.Enabled = true;
                dtpDayOfBirth.Enabled = true;
                cbbPosition.Enabled = true;
            }
        }
        #endregion
        #region Event UC function
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailEmployee_Load(object sender, EventArgs e)
        {
            txtCIEmployee.Enabled = false;
            txtIDEmployee.Enabled = false;
            txtNameEmployee.Enabled = false;
            cbbPosition.Enabled = false;
            btnChangePicUser.Enabled = false;
            dtpDayOfBirth.Enabled = false;
            AddNamePosition();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCIEmployee.Enabled = true;
            txtNameEmployee.Enabled = true;
            cbbPosition.Enabled = true;
            dtpDayOfBirth.Enabled = true;
            btnChangePicUser.Enabled = true;
        }

        private void btnChangePicUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string direct = System.IO.Path.GetFileName(ofd.FileName);
                img = Image.FromFile(ofd.FileName);
                pBUser.Image = img;
                pBUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            txtIDEmployee.Text = (BLL.NhanVienBLL.Instance.GetAllUser().Count + 1).ToString();
            newuser.ID_User = BLL.NhanVienBLL.Instance.GetAllUser().Count + 1;
            newuser.TenUser = txtNameEmployee.Text;
            newuser.ID_ChucVu = cbbPosition.SelectedIndex + 1;
            newuser.CMND_CCCD = txtCIEmployee.Text;
            newuser.Username = txtUserNameLogin.Text;
            newuser.Password = txtPasswordLogin.Text;
            newuser.NgaySinh = dtpDayOfBirth.Value;
            newuser.NgayBatDauLam = DateTime.Now;
            newuser.AnhUser = ImgToByte(pBUser.Image);
            BLL.NhanVienBLL.Instance.AddNewEmployee(newuser);
            d();
            this.Close();
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
            lblNumberOfDayWork.Text = "0";
            txtCIEmployee.Enabled = true;
            txtNameEmployee.Enabled = true;
            txtPasswordLogin.Enabled = true;
            txtUserNameLogin.Enabled = true;
            btnChangePicUser.Enabled = true;
            dtpDayOfBirth.Enabled = true;
            cbbPosition.Enabled = true;
        }
        #endregion


    }
}