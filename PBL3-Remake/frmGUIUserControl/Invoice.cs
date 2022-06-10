using System;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
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
            dgvHoaDon.DataSource = BLL.BLLNVNH.Instance.GetChiTietHoaDonByIDHoaDon(ID_HoaDon);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
