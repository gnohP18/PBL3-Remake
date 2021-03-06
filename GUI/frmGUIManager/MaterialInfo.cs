using BLL;
using DTO;
using System;
using System.Windows.Forms;
namespace GUI.frmGUIManager
{
    public partial class MaterialInfo : Form
    {
        private int ID_NguyenLieu;
        public MaterialInfo(int ID_NguyenLieu)
        {
            InitializeComponent();
            this.ID_NguyenLieu = ID_NguyenLieu;
            dgvInforMaterial.DataSource = NguyenLieuBLL.Instance.GetThongTinNguyenLieuTrongKho(ID_NguyenLieu);
            dgvInforMaterial.Columns["ID_NhaCungCap"].Visible = false;
            dgvInforMaterial.Columns["ID_ChiTietNguyenLieu"].Visible = false;
        }
        private void dgvInforMaterial_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInforMaterial.SelectedRows.Count == 1)
            {

                int ID_ChiTietNguyenLieu = Convert.ToInt32(dgvInforMaterial.SelectedRows[0].Cells["ID_ChiTietNguyenLieu"].Value);
                Kho kho = KhoBLL.Instance.GetChiTietNguyenLieuByIDChiTietNguyenLieu(ID_ChiTietNguyenLieu);
                txtMaterialID.Text = kho.NguyenLieu.ID_NguyenLieu.ToString();
                txtMaterialName.Text = kho.NguyenLieu.TenNguyenLieu;
                txtUnit.Text = kho.NguyenLieu.DonViTinh;
                txtManufacture.Text = kho.NhaCungCap.TenNhaCungCap;
                dtpImportDate.Value = kho.NgayNhap;
                dtpExpirationDate.Value = kho.NgayHetHan;
                txtImportQuantity.Text = kho.LuongNhapVao.ToString();
                txtInventoryQuantity.Text = kho.LuongTonKho.ToString();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
