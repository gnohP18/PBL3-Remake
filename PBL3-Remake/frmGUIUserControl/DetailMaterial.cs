using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

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
            cbbKindOfMaterial.Items.AddRange(BLLQLNH.Instance.GetAllLoaiNguyenLieu().ToArray());
        }
        void GUI()
        {
            txtID.Enabled = false;
            NguyenLieu nl = BLLQLNH.Instance.GetNguyenLieuByIDNguyenLieu(IDNguyenLieu);
            if(nl != null)
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
                txtID.Text = BLLQLNH.Instance.GetNewIDNguyenLieu().ToString();
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
            BLLQLNH.Instance.ExcuteAddorUpdate(nl);
            NoticeBox box = new NoticeBox("Action performed");
            box.Show();
            d(0);
        }
    }
}
