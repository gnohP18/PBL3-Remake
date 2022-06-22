using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmPay : Form
    {
        public frmPay(int idban)
        {
            IDTable = idban;
            InitializeComponent();
        }
        #region Local Variable
        List<MonAn_View> listMonAnViewDaDat;
        public delegate void Mydel();
        public Mydel d;
        public int IDTable { get; set; }
        List<string> Voucher = new List<string>();
        List<string> PhoneNumber = new List<string>();
        public KhachHang _Guest { get; set; }
        int guestmoney;
        int sum = 0;
        int tax;
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
                sum += Convert.ToInt32(row.Cells[3].Value.ToString());
            }
            lblBill.Text = sum.ToString();
            if (txtGuestMoney.Text.Length > 0)
            {
                guestmoney = Convert.ToInt32(txtGuestMoney.ToString());
            }
            tax = sum / 100 * 5;
            lblTax.Text = tax.ToString();
        }
        private void LoadGuest()
        {
            _Guest = BLL.KhachHangBLL.Instance.GetGuestByGuestPhoneNumber(txtGuestPhone.Text);
            lblNameGuest.Text = _Guest.TenKhachHang;
            lblPoint.Text = _Guest.DiemTichLuy.ToString();
        }
        #endregion
        #region Event Form
        private void frmPay_Load(object sender, EventArgs e)
        {
            listMonAnViewDaDat = MonAnBLL.Instance.GetListMonAnByIDBan(IDTable);
            dgvPayment.DataSource = listMonAnViewDaDat;
            LoadDataGridView(listMonAnViewDaDat);
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
            lblTotal.Text = (sum + tax).ToString();
        }
        private void txtVoucher_TextChanged(object sender, EventArgs e)
        {
            if (CheckVoucherOrPhoneNumber(Voucher, txtVoucher.Text))
            {
                pBVoucher.Image = PBL3_Remake.Properties.Resources.checkedGreen;
            }
            else pBVoucher.Image = PBL3_Remake.Properties.Resources.uncheckedRed;
        }

        private void txtGuestMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtGuestMoney.Text.Length != 0)
                guestmoney = Convert.ToInt32(txtGuestMoney.Text);
            if (guestmoney > (sum + tax))
            {
                pBGuestMoney.Image = PBL3_Remake.Properties.Resources.checkedGreen;
            }
            else pBGuestMoney.Image = PBL3_Remake.Properties.Resources.uncheckedRed;
        }

        private void btnVoucherConfirm_Click(object sender, EventArgs e)
        {
            sum -= 50000;
            lblTotal.Text = (sum + tax).ToString();
            txtVoucher.Text = "";
            pBVoucher.Image = null;
        }

        private void btnPayReceipt_Click(object sender, EventArgs e)
        {
            //BLL.HoaDonBLL.Instance.AddNewInvoice();
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            d();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBCheckGuest_Click(object sender, EventArgs e)
        {
            if (txtGuestPhone.Text == "new")
            {
                GuestInformation frm = new GuestInformation(-1);
                frm.Show();
            }
            else if (CheckVoucherOrPhoneNumber(PhoneNumber, txtGuestPhone.Text))
            {
                GuestInformation frm = new GuestInformation(BLL.KhachHangBLL.Instance.GetGuestByGuestPhoneNumber(txtGuestPhone.Text).ID_KhachHang);
                frm.Show();
            }

        }
        private void txtGuestPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtGuestPhone.Text == "new")
            {
                pBCheckGuest.Image = PBL3_Remake.Properties.Resources.uncheckedRed;
            }
            else if (CheckVoucherOrPhoneNumber(PhoneNumber, txtGuestPhone.Text))
            {
                pBCheckGuest.Image = PBL3_Remake.Properties.Resources.checkedGreen;
                LoadGuest();
            }
        }
        #endregion
    }
}
