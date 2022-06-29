using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DTO;
using GUI;
using Entity;
namespace GUI.frmGUIUCForSeller
{
    public partial class DishForOrdering : UserControl
    {
        public delegate void Mydel(MonAn monAn);
        public Mydel d;
        public DishForOrdering(MonAn monAn)
        {
            InitializeComponent();
            this.MonAn = monAn;
            GUIForDish();
        }
        public MonAn MonAn { get; set; }
        public void GUIForDish()
        {
            lblNameDish.Text = MonAn.TenMonAn.ToString();
            pBDish.Image = byteArrayToImage(MonAn.AnhMonAn);
            pBDish.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCost.Text = MonAn.ThanhTien.ToString();
        }
        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private void pBDish_Click(object sender, System.EventArgs e)
        {
            if (MonAn.TrangThai == 0)
            {
                NoticeBox frm = new NoticeBox("Món ăn đã hết!!!");
                frm.Show();
                return;
            }
            d(MonAn);
        }
    }
}
