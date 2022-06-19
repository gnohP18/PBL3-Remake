using PBL3_Remake.Properties;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using System;

namespace GUI.frmGUISeller
{
    public partial class TableForOrdering : UserControl
    {
        public frmMainSeller.Mydel d;
        public TableForOrdering(Ban ban)
        {
            InitializeComponent();
            this.ban = ban;
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
            frmOrder frm = new frmOrder(ban.ID_Ban);
            frm.d = d;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {
            frmPay frm = new frmPay(ban.ID_Ban);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
