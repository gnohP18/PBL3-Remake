using BLL;
using Entity;
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

        private void frmPay_Load(object sender, System.EventArgs e)
        {
            listMonAnViewDaDat = BLLNVNH.Instance.GetListMonAnByIDBan(IDTable);
            dgvPayment.DataSource = listMonAnViewDaDat;
            LoadDataGridView(listMonAnViewDaDat);
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
            }
        }
        private void LoadListDishOrdered()
        {
            dgvPayment.DataSource = listMonAnViewDaDat;
        }
    }
}
