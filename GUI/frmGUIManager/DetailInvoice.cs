using System;
using System.Windows.Forms;
using BLL;
namespace GUI.frmGUIManager
{
    public partial class DetailInvoice : Form
    {
        private DateTime dateStart,dateEnd;
        public DetailInvoice(DateTime dtStart,DateTime dtEnd)
        {
            dateStart = dtStart;
            dateEnd = dtEnd;
            InitializeComponent();
            SetupDatagridView();
        }
        private void SetupDatagridView()
        {
            dgvDanhSachHoaDon.DataSource = HoaDonBLL.Instance.GetHoaDonByFromDatetoDate(dateStart,dateEnd);
        }

        private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachHoaDon.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvDanhSachHoaDon.SelectedRows[0].Cells[0].Value.ToString());
                Invoice inc = new Invoice(id);
                inc.Show();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
