using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmPay : Form
    {
        List<MonAn_View> listMonAnViewDaDat;
        public int IDTable { get; set; }
        public frmPay(int idban)
        {
            IDTable = idban;
            InitializeComponent();
        }
        List<string> Voucher = new List<string>();
        private void AddVoucher()
        {
            Voucher.Add("Voucher123");
            Voucher.Add("KM50%");
            Voucher.Add("KM20%");
            Voucher.Add("Giam50k");
        }
        private void frmPay_Load(object sender, System.EventArgs e)
        {
            listMonAnViewDaDat = BLLNVNH.Instance.GetListMonAnByIDBan(IDTable);
            dgvPayment.DataSource = listMonAnViewDaDat;
            LoadDataGridView(listMonAnViewDaDat);
            AddVoucher();
            AutoCompleteStringCollection autoVoucher = new AutoCompleteStringCollection();
            txtVoucher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtVoucher.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (string i in Voucher)
            {
                autoVoucher.Add(i);
            }
            txtVoucher.AutoCompleteCustomSource = autoVoucher;
            lblTotal.Text = (sum + tax).ToString();
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
        private void LoadListDishOrdered()
        {
            dgvPayment.DataSource = listMonAnViewDaDat;
        }
        int guestmoney;
        int sum = 0;
        int tax;
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

        private void txtVoucher_TextChanged(object sender, EventArgs e)
        {
            if (txtVoucher.Text == "Voucher123" || txtVoucher.Text == "km123" || txtVoucher.Text == "QLNH111")
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
            this.Close();
        }
    }
}
