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
            cbbKindOfMaterial.DisplayMember = "TenLoaiNguyenLieu";
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

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            foreach (NguyenLieu i in BLLQLNH.Instance.GetAllNguyenLieu())
            {
                if (i.TenNguyenLieu.ToUpper() == txtInputMaterialName.ToString().ToUpper())
                {
                    GUI.NoticeBox box = new NoticeBox("Material name have already exist");
                    box.Show();
                }
                else
                {
                    LoaiNguyenLieu lnl = (LoaiNguyenLieu)(cbbKindOfMaterial.SelectedItem);
                    NguyenLieu nl = new NguyenLieu
                    {
                        ID_NguyenLieu = Convert.ToInt32(txtID.Text),
                        DonViTinh = txtUnit.Text,
                        TenNguyenLieu = txtInputMaterialName.Text,
                        HSD = Convert.ToInt32(txtExpiry.Text),
                        ID_LoaiNguyenLieu = lnl.ID_LoaiNguyenLieu
                    };
                    BLLQLNH.Instance.AddNewMaterial(nl);
                    GUI.NoticeBox box = new NoticeBox("");
                    box.Show();
                    break;
                }
            }
            d(0);
        }
    }
}
