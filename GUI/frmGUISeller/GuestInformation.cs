using DTO;
using System;
using System.Windows.Forms;
namespace GUI.frmGUISeller
{
    public partial class GuestInformation : Form
    {
        public KhachHang khachhang { get; set; }
        private int ID_KhachHang { get; set; }
        public GuestInformation(int ID_KhachHang)
        {
            this.ID_KhachHang = ID_KhachHang;
            if (this.ID_KhachHang != -1)
            {
                khachhang = BLL.KhachHangBLL.Instance.GetGuestByIDGuest(ID_KhachHang);
            }
            InitializeComponent();
            GUI();
        }
        private void SetupDataGridView()
        {
            dgvHistoryReceipt.DataSource = BLL.HoaDonBLL.Instance.GetAllHoaDonByIDKhachHang(ID_KhachHang);
            dgvHistoryReceipt.Columns[7].Visible = false;
            dgvHistoryReceipt.Columns[8].Visible = false;
            dgvHistoryReceipt.Columns[10].Visible = false;
            dgvHistoryReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void GUI()
        {
            if (ID_KhachHang != -1)
            {
                lblIDGuest.Text = khachhang.ID_KhachHang.ToString();
                txtGuestName.Text = khachhang.TenKhachHang;
                txtGuestPhone.Text = khachhang.SDT;
                txtGuestPoint.Text = khachhang.DiemTichLuy.ToString();
                txtGuestAddress.Text = khachhang.DiaChi;
                lblRegistDay.Text = khachhang.NgayDangKy.ToShortDateString();
                if (khachhang.GioiTinh)
                {
                    radMale.Checked = true;
                }
                else
                {
                    radFemale.Checked = true;
                }
                SetupDataGridView();
            }
            else
            {
                lblIDGuest.Text = (BLL.KhachHangBLL.Instance.GetAllGuest().Count + 1).ToString();
                lblRegistDay.Text = DateTime.Now.ToShortDateString();
                txtGuestPoint.Text = "0";
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BLL.KhachHangBLL.Instance.DeleteKhachHangByIDKhachHang(ID_KhachHang);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtGuestAddress.Text == "" || txtGuestName.Text == "" || txtGuestPhone.Text == "")
            {
                NoticeBox box = new NoticeBox("Please fill all information");
                box.Show();
            }
            else
            {
                bool gender = false;
                if (radMale.Checked)
                    gender = true;
                BLL.KhachHangBLL.Instance.AddNewKhachHang(txtGuestName.Text, txtGuestPhone.Text, txtGuestAddress.Text, gender, 0);
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
