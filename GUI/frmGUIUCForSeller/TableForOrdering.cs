using GUI.Properties;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using System;
using GUI.frmGUISeller;
using Entity;
namespace GUI.frmGUIUCForSeller
{
    public partial class TableForOrdering : UserControl
    {
        public frmMainSeller.Mydel d;
        int ID_NhanVien;
        public TableForOrdering(Ban ban,int ID_NhanVien)
        {
            InitializeComponent();
            this.ban = ban;
            this.ID_NhanVien = ID_NhanVien;
            GUITable();
        }
        Ban ban;
        Bitmap pGreen = Resources.checkedGreen;
        Bitmap pRed = Resources.uncheckedRed;
        public void GUITable()
        {
            lblFloorNumber.Text = ban.Tang.ToString();
            lblNameTable.Text = ban.TenBan;
            lblIDTable.Text = ban.ID_Ban.ToString();
            if (ban.TinhTrangBan == 0)
            {
                pBStatusTable.Image = Resources.checkedGreen;
            }
            else 
            {
                pBStatusTable.Image = Resources.uncheckedRed;
            }
        }
        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }

        private void btnMenuOrder_Click(object sender, System.EventArgs e)
        {
            frmOrder frm = new frmOrder(ban.ID_Ban,ID_NhanVien);
            frm.d = d;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {
            frmPay frm = new frmPay(ban.ID_Ban,ID_NhanVien);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
