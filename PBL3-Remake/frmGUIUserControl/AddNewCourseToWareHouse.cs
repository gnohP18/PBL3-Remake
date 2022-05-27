using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class AddNewCourseToWareHouse : Form
    {
        List<ChiTietNhapMonAn_View> listNguyenLieuDangThem = new List<ChiTietNhapMonAn_View>();
        List<string> ListIngredient = new List<string>();
        private int ID_LoaiMonAn { get; set; }
        Image img;
        public AddNewCourseToWareHouse()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetCBB()
        {
            cbbIngrendients.Items.Clear();
            cbbKindOfIngredinet.Items.Clear();
            cbbLoaiMonAn.Items.Add("Appetizer");
            cbbLoaiMonAn.Items.Add("MainDish");
            cbbLoaiMonAn.Items.Add("Dessert");
            cbbLoaiMonAn.Items.Add("Drink");
            cbbKindOfIngredinet.Items.Add("FreshFood");
            cbbKindOfIngredinet.Items.Add("Vegetable");
            cbbKindOfIngredinet.Items.Add("DriedFood");
            cbbKindOfIngredinet.Items.Add("Drinking");
            foreach (NguyenLieu i in BLL.BLLQLNH.Instance.GetAllNguyenLieu())
            {
                if (i.ID_LoaiNguyenLieu == (cbbKindOfIngredinet.SelectedIndex + 1))
                {
                    ListIngredient.Add(i.TenNguyenLieu);
                    cbbIngrendients.Items.Add(i.TenNguyenLieu);
                }
                //else if (cbbIngrendients.SelectedIndex == 0)
                //{
                //    ListIngredient.Add(i.TenNguyenLieu);
                //    cbbIngrendients.Items.Add(i.TenNguyenLieu);
                //}
            }
        }
        private byte[] ImgToByte(System.Drawing.Image img)
        {
            var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            byte[] imgbyte = ms.ToArray();
            return imgbyte;
        }
        private void SetCBBIngredient()
        {
            cbbIngrendients.Items.Clear();
            foreach (NguyenLieu i in BLL.BLLQLNH.Instance.GetAllNguyenLieu())
            {
                if (i.ID_LoaiNguyenLieu == (cbbKindOfIngredinet.SelectedIndex + 1))
                {
                    ListIngredient.Add(i.TenNguyenLieu);
                    cbbIngrendients.Items.Add(i.TenNguyenLieu);
                }
            }
        }
        private void GUI()
        {
            SetCBB();
            int id = BLL.BLLNVNH.Instance.GetAllMonAn().Count;
            id++;
            lblIDCourse.Text = id.ToString();
            AutoCompleteStringCollection autoSearchIngredients = new AutoCompleteStringCollection();
            cbbIngrendients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbIngrendients.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (string i in ListIngredient)
            {
                autoSearchIngredients.Add(i);
            }
            cbbIngrendients.AutoCompleteCustomSource = autoSearchIngredients;
        }

        private void AddNewCourseToWareHouse_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            GUI();
        }

        private void btnImportImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string direct = System.IO.Path.GetFileName(ofd.FileName);
                img = Image.FromFile(ofd.FileName);
                pBCourse.Image = img;
                pBCourse.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void SetDataGridView()
        {
            foreach (ChiTietNhapMonAn_View i in listNguyenLieuDangThem)
            {
                Console.WriteLine(i.ID_NguyenLieu + " " + i.TenNguyenLieu + " " + i.Luong);
            }
            dgvMaterial.DataSource = listNguyenLieuDangThem.ToArray();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool CheckExisted = false;
            int dem = listNguyenLieuDangThem.Count;
            dem++;
            ChiTietNhapMonAn_View nhap = new ChiTietNhapMonAn_View();
            nhap.TenMonAn = txtNameCourse.Text;
            nhap.ID_NguyenLieu = BLL.BLLQLNH.Instance.GetNguyenLieuByTenNguyenLieu(cbbIngrendients.SelectedItem.ToString()).ID_NguyenLieu;
            nhap.Luong = (float)(Convert.ToDouble(txtAmount.Text));
            nhap.ID_MonAn = Convert.ToInt32(lblIDCourse.Text);
            nhap.TenNguyenLieu = cbbIngrendients.SelectedItem.ToString();
            foreach (ChiTietNhapMonAn_View i in listNguyenLieuDangThem)
            {
                if (i.TenNguyenLieu == nhap.TenNguyenLieu)
                {
                    i.Luong += nhap.Luong;
                    CheckExisted = true;
                }
            }
            if (CheckExisted == false)
                listNguyenLieuDangThem.Add(nhap);
            //dgvMaterial.DataSource = listNguyenLieuDangThem;
            SetDataGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNameCourse.Text = "";
            txtThanhTien.Text = "";
            txtAmount.Text = "";
            cbbLoaiMonAn.SelectedIndex = -1;
            cbbKindOfIngredinet.SelectedIndex = -1;
            cbbIngrendients.SelectedIndex = -1;
            pBCourse.Image = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLL.BLLQLNH.Instance.AddNewMonAn(listNguyenLieuDangThem, txtNameCourse.Text, ID_LoaiMonAn, Convert.ToInt32(txtThanhTien.Text), ImgToByte(img));
            Console.WriteLine(txtNameCourse.Text);
            Console.WriteLine(txtThanhTien.Text);
            Console.WriteLine(txtAmount.Text);
            Console.WriteLine(cbbIngrendients.SelectedItem.ToString());
            Console.WriteLine(cbbKindOfIngredinet.SelectedItem.ToString());
            Console.WriteLine((cbbLoaiMonAn.SelectedIndex + 1).ToString());
            foreach (ChiTietNhapMonAn_View i in listNguyenLieuDangThem)
            {
                Console.WriteLine("mon " + i.ID_MonAn + "ID_NguyenLieu" + i.ID_NguyenLieu + " Luong" + i.Luong);
            }
            this.Close();
        }

        private void cbbKindOfIIngredinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCBBIngredient();
        }

        private void cbbIngrendients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbIngrendients.SelectedItem.ToString());
        }

        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_LoaiMonAn = cbbLoaiMonAn.SelectedIndex + 1;
        }
    }
}

