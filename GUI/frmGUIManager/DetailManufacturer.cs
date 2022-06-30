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
            GUI();
            LoadDgv();
        }
        void LoadDgv()
        {
            dgvNguyenLieu.DataSource =  NhaCungCapBLL.Instance.GetChiTietNhaCungCap_Views(MA);
        }
        void GUI()
        {
            cbbKindOfIngredinet.Items.AddRange(NguyenLieuBLL.Instance.GetAllLoaiNguyenLieu().ToArray());
            lbIDNCC.Text = Convert.ToString(MA);
            txtPhone.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).SoDienThoai.ToString();
            txtNameNCC.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).TenNhaCungCap.ToString();
            txtAddressNCC.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).DiaChi.ToString();
            txtTaxCode.Text = NhaCungCapBLL.Instance.GetNCCByID(MA).MaSoThue.ToString();
        }
        private void cbbKindOfIngredinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbIngrendients.Items.Clear();
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
                NoticeBox box = new NoticeBox("Add successful");
                box.Show();
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
            if(dgvNguyenLieu.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dgvNguyenLieu.SelectedRows)
                {
                    listDel.Add(Convert.ToInt32(dgvNguyenLieu.SelectedRows[0].Cells["ID_NguyenLieu"].Value.ToString()));
                }
                NhaCungCapBLL.Instance.DeteleChiTietNhaCungCap(listDel,MA);
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
