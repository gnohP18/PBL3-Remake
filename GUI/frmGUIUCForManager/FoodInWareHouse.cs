using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GUI.frmGUIManager;
using Entity;
namespace GUI.frmGUIUCForManager
{
    public partial class FoodInWareHouse : UserControl
    {
        public DetailFood.Mydel d;
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
            DetailFood frm = new DetailFood(mon.ID_MonAn);
            frm.d = d;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        private void CoursesInWareHouse_Load(object sender, EventArgs e)
        {
            lblNameFood.Text = mon.TenMonAn;
            pBFood.Image = BLL.ExtensionBLL.Instance.byteArrayToImage(mon.AnhMonAn);
            pBFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
