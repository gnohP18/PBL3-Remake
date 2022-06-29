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
using DTO;
namespace GUI.frmGUIManager
{
    public partial class DetailManufacturer : Form
    {
        public delegate void MyDel();
        public MyDel d;
        int MA { get; set; }
        public DetailManufacturer(int ma)
        {   
            MA = ma;
            InitializeComponent();
            SetCBB();
            GUI();
            LoadDgv();
        }
        private void SetCBB()
        {
            cbbIngrendients.Items.Clear();
            cbbKindOfIngredinet.Items.Clear();
            cbbKindOfIngredinet.Items.AddRange(NguyenLieuBLL.Instance.GetAllLoaiNguyenLieu().ToArray());
        }
        void LoadDgv()
        {
            dgvNguyenLieuCuaNhaCungCap.DataSource =  NhaCungCapBLL.Instance.GetChiTietNhaCungCap_Views(MA);
        }
        void GUI()
        {
            lbIDNCC.Text = Convert.ToString(MA);
            txtPhone.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).SoDienThoai.ToString();
            txtNameNCC.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).TenNhaCungCap.ToString();
            txtAddressNCC.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).DiaChi.ToString();
            txtTaxCode.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).MaSoThue.ToString();
        }
        private void cbbKindOfIngredinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbIngrendients.Items.AddRange(NguyenLieuBLL.Instance.GetAllNguyenLieuByIdLoaiNguyenLieu(((LoaiNguyenLieu)cbbKindOfIngredinet.SelectedItem).ID_LoaiNguyenLieu).ToArray());
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if(cbbIngrendients.SelectedIndex != -1 && txtPrice.Text != "")
            {
                ChiTietNhaCungCap ct = new ChiTietNhaCungCap
                {
                ID_NhaCungCap = MA,
                ID_NguyenLieu = ((NguyenLieu)cbbIngrendients.SelectedItem).ID_NguyenLieu,
                DonGia = Convert.ToInt32(txtPrice.Text),
                };
                NhaCungCapBLL.Instance.AddNewChiTietNhaCungCap(ct);
                LoadDgv();
            }
            else
            {
                NoticeBox box = new NoticeBox("Please fill fully information");
                box.Show();
            }
        }

        private void btnDeleteManufacturer_Click(object sender, EventArgs e)
        {
            NhaCungCapBLL.Instance.DeleteNhaCungCap(MA);
            Close();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            List<int> listDel = new List<int>();
            if(dgvNguyenLieuCuaNhaCungCap.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dgvNguyenLieuCuaNhaCungCap.SelectedRows)
                {
                    listDel.Add(Convert.ToInt32(dgvNguyenLieuCuaNhaCungCap.SelectedRows[0].Cells["ID_ChiTietNhaCungCap"].Value.ToString()));
                }
                NhaCungCapBLL.Instance.DeteleChiTietNhaCungCap(listDel);
                LoadDgv();
            }
            else
            {
                NoticeBox box = new NoticeBox("Choose at least one details to delete");
                box.Show();
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap {
                ID_NhaCungCap = Convert.ToInt32(lbIDNCC.Text),
                TenNhaCungCap = txtNameNCC.Text,
                DiaChi = txtAddressNCC.Text,
                MaSoThue = txtTaxCode.Text,
                SoDienThoai = txtPhone.Text  
        };
        NhaCungCapBLL.Instance.UpdateNhaCungCap(nhaCungCap);
            d();
        Close();
        }
    }
}
