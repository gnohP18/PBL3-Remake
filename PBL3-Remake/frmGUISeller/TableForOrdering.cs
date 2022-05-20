using PBL3_Remake.Properties;
using System.Drawing;
using System.Windows.Forms;


namespace GUI.frmGUISeller
{
    public partial class TableForOrdering : UserControl
    {
        public TableForOrdering()
        {
            InitializeComponent();
        }
        public int IDTable { get; set; }
        public string NameTable { get; set; }
        public int Floor { get; set; }
        public bool statusTable { get; set; }
        Bitmap pGreen = Resources.checkedGreen;
        Bitmap pRed = Resources.uncheckedRed;
        public void GUITable()
        {
            lblFloorNumber.Text = Floor.ToString();
            lblNameTable.Text = NameTable.ToString();
            lblIDTable.Text = IDTable.ToString();
            if (statusTable)
            {
                pBStatusTable.Image = Resources.checkedGreen;
            }
            else if (statusTable == false)
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
            frmOrder frm = new frmOrder();
            frm.Show();
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {
            frmPay frm = new frmPay();
            frm.Show();
        }
    }
}
