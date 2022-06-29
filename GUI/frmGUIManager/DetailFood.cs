using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using System.Linq;
namespace GUI.frmGUIManager
{
    public partial class DetailFood : Form
    {
        List<ChiTietMonAn_View> ListChiTietMonAnView;
        private int ID_MonAn { get; set; }
        public DetailFood(int ID_MonAn)
        {
            this.ID_MonAn = ID_MonAn;
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            cbbKindOfIngredinet.Items.AddRange(NguyenLieuBLL.Instance.GetAllLoaiNguyenLieu().ToArray());
            cbbKindOfFood.Items.AddRange(MonAnBLL.Instance.GetAllLoaiMonAn().ToArray());
            MonAn i = MonAnBLL.Instance.GetMonAnByID(ID_MonAn);
            if(i != null)
            {
                ListChiTietMonAnView = MonAnBLL.Instance.GetChiTietMonAnViewByIDMonAn(i.ID_MonAn);
                pBFood.Image = ExtensionBLL.Instance.byteArrayToImage(i.AnhMonAn);
                pBFood.SizeMode = PictureBoxSizeMode.StretchImage;
                lblIDFood.Text = i.ID_MonAn.ToString();
                txtNameFood.Text = i.TenMonAn;
                cbbKindOfFood.SelectedIndex = cbbKindOfFood.FindStringExact(i.LoaiMonAn.TenLoaiMonAn);
                txtThanhTien.Text = i.ThanhTien.ToString();
            }
            else
            {
                lblIDFood.Text = MonAnBLL.Instance.GetNewIDMonAn() + "";
                ListChiTietMonAnView = new List<ChiTietMonAn_View>();
            }
            LoadDgv();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void DetailFood_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnImportImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string direct = System.IO.Path.GetFileName(ofd.FileName);
                pBFood.Image = Image.FromFile(ofd.FileName);
                pBFood.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbIngrendients.SelectedIndex != -1 && cbbKindOfIngredinet.SelectedIndex != -1 && txtAmount.Text != "")
            {
                NguyenLieu nl = ((NguyenLieu)cbbIngrendients.SelectedItem);
                foreach(ChiTietMonAn_View i in ListChiTietMonAnView)
                {
                    if (i.ID_NguyenLieu == nl.ID_NguyenLieu)
                    {
                        NoticeBox box = new NoticeBox("This ingrendient is existed in this food!!");
                        box.ShowDialog();
                        return;
                    }
                }
                ListChiTietMonAnView.Add(new ChiTietMonAn_View
                {
                    ID_NguyenLieu = nl.ID_NguyenLieu,
                    TenNguyenLieu = nl.TenNguyenLieu,
                    Luong = Convert.ToInt32(txtAmount.Text)
                });
                LoadDgv();
            }
            else
            {
                NoticeBox box = new NoticeBox("Please fill enough information!!");
                box.ShowDialog();
            }
        }

        private void LoadDgv()
        {
            dgvMaterial.DataSource = ListChiTietMonAnView.OrderBy(s=>s.ID_NguyenLieu).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNameFood.Text = "";
            txtThanhTien.Text = "";
            txtAmount.Text = "";
            cbbKindOfFood.SelectedIndex = -1;
            cbbKindOfIngredinet.SelectedIndex = -1;
            cbbIngrendients.SelectedIndex = -1;
            pBFood.Image = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNameFood.Text != "" && txtThanhTien.Text != "" && pBFood.Image != null && cbbKindOfFood.SelectedIndex != -1 && ListChiTietMonAnView.Count > 0)
            {
                MonAn mon = new MonAn
                {
                    ID_MonAn = Convert.ToInt32(lblIDFood.Text),
                    ID_LoaiMonAn = ((LoaiMonAn)cbbKindOfFood.SelectedItem).ID_LoaiMonAnh,
                    TenMonAn = txtNameFood.Text,
                    ThanhTien = Convert.ToInt32(txtThanhTien.Text),
                    AnhMonAn = ExtensionBLL.Instance.ImgToByte(pBFood.Image),
                    TrangThai = 1
                };
                MonAnBLL.Instance.ExecuteMonAn(mon);
                MonAnBLL.Instance.SetChiTietMonAn(mon.ID_MonAn,ListChiTietMonAnView);
                this.Close();
            }
            else
            {
                NoticeBox box = new NoticeBox("Please fill enough information!!");
                box.ShowDialog();
                return;
            }
        }

        private void cbbKindOfIIngredinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKindOfIngredinet.SelectedIndex != -1)
            {
                cbbIngrendients.Items.Clear();
                int ID_LoaiNguyenLieu = ((LoaiNguyenLieu)(cbbKindOfIngredinet.SelectedItem)).ID_LoaiNguyenLieu;
                cbbIngrendients.Items.AddRange(NguyenLieuBLL.Instance.GetAllNguyenLieuByIdLoaiNguyenLieu(ID_LoaiNguyenLieu).ToArray());
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvMaterial.SelectedRows.Count == 1)
            {
                int ID_NguyenLieu = Convert.ToInt32(dgvMaterial.SelectedRows[0].Cells["ID_NguyenLieu"].Value);
                ListChiTietMonAnView.Remove(ListChiTietMonAnView.Where(s => s.ID_NguyenLieu == ID_NguyenLieu).FirstOrDefault());
                LoadDgv();
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            NoticeBox frm = new NoticeBox("Are you sure delete this food ?");
            frm.Show();
        }
    }
}

