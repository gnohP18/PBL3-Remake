using Entity;
using PBL3_Remake.frmGUISeller;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmOrder : Form
    {
        public int IDTable { get; set; }
        private int IDLoaiMonAn = 2;
        public frmOrder(int id)
        {
            IDTable = id;
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            lblIDTable.Text = BLL.BLLNVNH.Instance.GetBanByID_Ban(IDTable).ID_Ban.ToString();
            lblNameTable.Text = BLL.BLLNVNH.Instance.GetBanByID_Ban(IDTable).TenBan;
            pnDish.AutoScroll = true;
            GetDishByKind(IDLoaiMonAn);
        }
        private void SetDish(Panel pn, DishForOrdering dsh, int idmonan, int idloaimonan, string tenmonan, int cost, Image img)
        {
            dsh.ID_MonAn = idmonan;
            dsh.ID_LoaiMonAn = idloaimonan;
            dsh.TenMonAn = tenmonan;
            dsh.Cost = cost;
            dsh.imgDish = img;
            dsh.Width = 180;
            dsh.Height = 180;
            pn.Controls.Add(dsh);
            dsh.GUIForDish();
        }
        private void RemoveDish()
        {
            pnDish.Controls.Clear();
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private void GetDishByKind(int idloaimonan)
        {
            int somon = BLL.BLLNVNH.Instance.NumberOfKindDish(idloaimonan);
            DishForOrdering[] dsh = new DishForOrdering[somon];
            int dem1 = 0;
            foreach (MonAn i in BLL.BLLNVNH.Instance.GetAllDishByIDKindOfDish(idloaimonan))
            {
                dsh[dem1] = new DishForOrdering();
                dsh[dem1].ID_MonAn = i.ID_MonAn;
                dsh[dem1].ID_LoaiMonAn = i.ID_LoaiMonAn;
                dsh[dem1].TenMonAn = i.TenMonAn;
                dsh[dem1].Cost = i.ThanhTien;
                dsh[dem1].imgDish = byteArrayToImage(i.AnhMonAn);
                dem1++;
            }
            if (somon != 0)
            {
                for (int i = 0; i < dsh.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 4 == 0) Lx = 25;
                    else if (i % 4 == 1)
                    {
                        Lx = 235;
                    }
                    else if (i % 4 == 2)
                    {
                        Lx = 440;
                    }
                    else if (i % 4 == 3)
                    {
                        Lx = 645;
                    }
                    int thuong = Convert.ToInt32(i / 4);
                    Ly = 25 + 230 * thuong;
                    dsh[i].SetLocation(Lx, Ly);
                    SetDish(pnDish, dsh[i], dsh[i].ID_MonAn, dsh[i].ID_LoaiMonAn, dsh[i].TenMonAn, dsh[i].Cost, dsh[i].imgDish);
                }
            }

        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 1;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }

        private void btnMainDish_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 2;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 3;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 4;
            RemoveDish();
            GetDishByKind(IDLoaiMonAn);
        }
        private void Order_Dish(object sender, EventArgs e)
        {

        }
    }
}
