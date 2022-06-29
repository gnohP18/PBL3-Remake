using System;
using System.Windows.Forms;
using BLL;
namespace GUI.frmGUIManager
{
    public partial class Invoice : Form
    {
        private int ID_HoaDon { get; set; }
        public Invoice(int idhd)
        {
            ID_HoaDon = idhd;
            InitializeComponent();
            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            dgvHoaDon.DataSource = HoaDonBLL.Instance.GetChiTietHoaDonByIDHoaDon(ID_HoaDon);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
