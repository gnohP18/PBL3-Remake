using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class DetailMaterial : Form
    {
        public int IDNguyenLieu { get; set; }
        public delegate void MyDel(int IDLoaiNguyenLieu);
        public MyDel d { get; set; }
        public DetailMaterial(int ID)
        {
            IDNguyenLieu = ID;
            InitializeComponent();
            SetCBB();
            GUI();
        }
        public void SetCBB()
        {
            cbbKindOfMaterial.Items.AddRange(NguyenLieuBLL.Instance.GetAllLoaiNguyenLieu().ToArray());
        }
        void GUI()
        {
            txtID.Enabled = false;
            NguyenLieu nl = NguyenLieuBLL.Instance.GetNguyenLieuByIDNguyenLieu(IDNguyenLieu);
            if (nl != null)
            {
                lbTienDe.Text = "Update Material";
                txtID.Text = nl.ID_NguyenLieu.ToString();
                txtInputMaterialName.Text = nl.TenNguyenLieu.ToString();
                txtUnit.Text = nl.DonViTinh.ToString();
                txtExpiry.Text = nl.HSD.ToString();
                cbbKindOfMaterial.SelectedItem = nl.LoaiNguyenLieu;
            }
            else
            {
                lbTienDe.Text = "Add New Material";
                txtID.Text = NguyenLieuBLL.Instance.GetNewIDNguyenLieu().ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoaiNguyenLieu lnl = (LoaiNguyenLieu)(cbbKindOfMaterial.SelectedItem);
            NguyenLieu nl = new NguyenLieu
            {
                ID_NguyenLieu = Convert.ToInt32(txtID.Text),
                TenNguyenLieu = txtInputMaterialName.Text,
                DonViTinh = txtUnit.Text,
                HSD = Convert.ToInt32(txtExpiry.Text),
                ID_LoaiNguyenLieu = lnl.ID_LoaiNguyenLieu
            };
            if(NguyenLieuBLL.Instance.checkAddorUpdate(nl.ID_NguyenLieu))
            {
                NguyenLieuBLL.Instance.ExcuteUpdate(nl);
                NoticeBox box = new NoticeBox("Update material performed");
                box.Show();
            }
            else
            {
                if(NguyenLieuBLL.Instance.checkTrungTenNL(nl.TenNguyenLieu))
                {
                    NoticeBox box = new NoticeBox("Material's name have already exist");
                    box.Show();
                }
                else
                {
                    NguyenLieuBLL.Instance.ExcuteAdd(nl);
                    NoticeBox box = new NoticeBox("Add material performed");
                    box.Show();
                }
            }    
            d(0);
        }
    }
}
