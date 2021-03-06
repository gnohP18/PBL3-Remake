using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI.frmGUISeller
{
    public partial class frmPay : Form
    {
        public frmPay(int idban, int idNhanVien)
        {
            InitializeComponent();
            IDTable = idban;
            IDNhanVien = idNhanVien;
        }
        #region Local Variable
        public frmMainSeller.Mydel deleFrmMainSeller;
        List<MonAn_View> listMonAnViewDaDat;
        public delegate void Mydel();
        public Mydel d;
        public int IDTable { get; set; }
        public int IDNhanVien { get; set; }
        List<string> Voucher = new List<string>();
        List<string> PhoneNumber = new List<string>();
        public KhachHang _Guest { get; set; }
        int guestmoney;
        int bill = 0;
        int tax;
        int TienQuyDoiTuDiemTichLuy;
        string MaVoucher;
        #endregion
        #region Function
        private void AddVoucher()
        {
            foreach (Voucher i in BLL.VoucherBLL.Instance.GetAllVoucher())
            {
                Voucher.Add(i.MaVoucher);
            }
        }
        private void AddPhoneNumber()
        {
            foreach (KhachHang i in KhachHangBLL.Instance.GetAllGuest())
            {
                PhoneNumber.Add(i.SDT);
            }
        }
        private bool CheckVoucherOrPhoneNumber(List<string> list, string check)
        {
            bool dk = false;
            foreach (string s in list)
                if (s == check) dk = true;
            return dk;
        }

        private void LoadDataGridView(List<MonAn_View> lt)
        {
            if (lt != null)
            {
                dgvPayment.Columns[0].Visible = false;
                dgvPayment.Columns[1].HeaderText = "Name dish";
                dgvPayment.Columns[2].HeaderText = "Number";
                dgvPayment.Columns[3].HeaderText = "Total";
                dgvPayment.DataSource = lt;
                Load_Total();
            }
        }

        private void Load_Total()
        {

            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                bill += Convert.ToInt32(row.Cells[3].Value.ToString());
            }
            lblBill.Text = bill.ToString();
            if (txtGuestMoney.Text.Length > 0)
            {
                guestmoney = Convert.ToInt32(txtGuestMoney.ToString());
            }
            tax = bill / 100 * 5;
            lblTax.Text = tax.ToString();
        }
        private void LoadGuest()
        {
            _Guest = BLL.KhachHangBLL.Instance.GetGuestByGuestPhoneNumber(txtGuestPhone.Text);
            lblNameGuest.Text = _Guest.TenKhachHang;
            lblPoint.Text = _Guest.DiemTichLuy.ToString();
        }
        private void LoadTextBox()
        {
            AddVoucher();
            AddPhoneNumber();
            AutoCompleteStringCollection autoVoucher = new AutoCompleteStringCollection();
            AutoCompleteStringCollection autoPhoneNumberGuest = new AutoCompleteStringCollection();
            txtVoucher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtVoucher.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGuestPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtGuestPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (string i in Voucher)
            {
                autoVoucher.Add(i);
            }
            foreach (string i in PhoneNumber)
            {
                autoPhoneNumberGuest.Add(i);
            }
            txtVoucher.AutoCompleteCustomSource = autoVoucher;
            txtGuestPhone.AutoCompleteCustomSource = autoPhoneNumberGuest;
        }
        #endregion
        #region Event Form
        private void frmPay_Load(object sender, EventArgs e)
        {
            listMonAnViewDaDat = MonAnBLL.Instance.GetListMonAnByIDBan(IDTable);
            dgvPayment.DataSource = listMonAnViewDaDat;
            LoadDataGridView(listMonAnViewDaDat);
            LoadTextBox();
            lblTotal.Text = (bill + tax).ToString();
        }
        private void txtVoucher_TextChanged(object sender, EventArgs e)
        {
            if (CheckVoucherOrPhoneNumber(Voucher, txtVoucher.Text))
            {
                pBVoucher.Image = Properties.Resources.checkedGreen;
            }
            else pBVoucher.Image = Properties.Resources.uncheckedRed;
        }

        private void txtGuestMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtGuestMoney.Text.Length != 0)
                guestmoney = Convert.ToInt32(txtGuestMoney.Text);
            if (guestmoney > (bill + tax))
            {
                pBGuestMoney.Image = Properties.Resources.checkedGreen;
            }
            else pBGuestMoney.Image = Properties.Resources.uncheckedRed;
            lblChangeMoney.Text = (bill + tax - guestmoney).ToString();
        }

        private void btnVoucherConfirm_Click(object sender, EventArgs e)
        {
            Voucher vc = VoucherBLL.Instance.GetVoucherByMa(txtVoucher.Text);
            if (vc != null)
            {
                this.MaVoucher = vc.MaVoucher;
                string s = vc.GiaTriVoucher;
                if (vc.GiaTriVoucher.Contains("%"))
                {
                    s = "";
                    foreach (char i in vc.GiaTriVoucher)
                    {
                        if (i != '%') s += i;
                    }
                    bill -= Convert.ToInt32(s) * bill / 100;
                }
                else if (vc.GiaTriVoucher.Contains("N"))
                {

                }
                else
                {
                    bill -= Convert.ToInt32(s);
                }
                lblTotal.Text = (bill + tax).ToString();
                txtVoucher.Text = "- " + vc.GiaTriVoucher;
                txtVoucher.Enabled = false;
                pBVoucher.Image = null;
            }
        }

        private void btnPayReceipt_Click(object sender, EventArgs e)
        {
            if (txtGuestMoney.Text != "" && txtGuestPhone.Text != "" && txtVoucher.Text != "")
            {
                int total = Convert.ToInt32(lblTotal.Text);
                HoaDon invoice = new HoaDon()
                {
                    ID_HoaDon = HoaDonBLL.Instance.GetNewIDHoaDon(),
                    ID_User = IDNhanVien,
                    TongTien = total,
                    ID_KhachHang = _Guest.ID_KhachHang,
                    TienQuyDoiTuDiemTichLuy = this.TienQuyDoiTuDiemTichLuy,
                    MaVoucher = MaVoucher,
                    NgayLap = DateTime.Now,
                };
                HoaDonBLL.Instance.AddNewInvoice(invoice, listMonAnViewDaDat);
                BanBLL.Instance.ClearAllMonOfBan(IDTable);
                BanBLL.Instance.SetEmptyBan(IDTable);
                deleFrmMainSeller(0, 1);
                if (d != null) d();
                frmReceipt frm = new frmReceipt(IDTable, invoice.ID_HoaDon);
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                NoticeBox box = new NoticeBox("Please fill all information");
                box.Show();
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtGuestPhone.Text == "")
            {
                GuestInformation frm = new GuestInformation(-1);
                frm.d = new GuestInformation.DeleReLoad(LoadTextBox);
                frm.Show();
            }
            else
            {
                GuestInformation frm = new GuestInformation(BLL.KhachHangBLL.Instance.GetGuestByGuestPhoneNumber(txtGuestPhone.Text).ID_KhachHang);
                frm.Show();
            }
        }


        private void txtGuestPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtGuestPhone.Text == "new")
            {
                pBCheckGuest.Image = Properties.Resources.uncheckedRed;
            }
            else if (CheckVoucherOrPhoneNumber(PhoneNumber, txtGuestPhone.Text))
            {
                pBCheckGuest.Image = Properties.Resources.checkedGreen;
                LoadGuest();
            }
        }
        private void cbUsePoint_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUsePoint.Checked == true) TienQuyDoiTuDiemTichLuy = HoaDonBLL.Instance.GetTienFromDiemTichLuy(Convert.ToInt32(lblPoint.Text));
            else TienQuyDoiTuDiemTichLuy = 0;
            int tempBill = bill;
            tempBill -= TienQuyDoiTuDiemTichLuy;
            lblTotal.Text = (tempBill + tax).ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
