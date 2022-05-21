using System.Drawing;
using System.Windows.Forms;

namespace PBL3_Remake.frmGUISeller
{
    public partial class DishForOrdering : UserControl
    {
        public DishForOrdering()
        {
            InitializeComponent();
        }
        public int ID_MonAn { get; set; }
        public int ID_LoaiMonAn { get; set; }
        public string TenMonAn { get; set; }
        public Image imgDish { get; set; }
        public int Cost { get; set; }
        public void GUIForDish()
        {
            lblNameDish.Text = TenMonAn.ToString();
            pBDish.Image = imgDish;
            lblCost.Text = Cost.ToString();
        }
        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }
    }
}
