using Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class FoodInWareHouse : UserControl
    {
        public MonAn mon { get; set; }
        public FoodInWareHouse(MonAn m)
        {
            mon = m;
            InitializeComponent();
        }
        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void FoodInWareHouse_Load(object sender, EventArgs e)
        {
            lblNameFood.Text = mon.TenMonAn;
        }
    }
}
