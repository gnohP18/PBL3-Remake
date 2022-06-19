using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class CoursesInWareHouse : UserControl
    {
        public MonAn mon { get; set; }
        public CoursesInWareHouse(MonAn m)
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
            AddNewCourseToWareHouse frm = new AddNewCourseToWareHouse(mon.ID_MonAn);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void CoursesInWareHouse_Load(object sender, EventArgs e)
        {
            lblNameFood.Text = mon.TenMonAn;
            pBFood.Image = byteArrayToImage(mon.AnhMonAn);
            pBFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
