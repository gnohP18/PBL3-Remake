using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.frmGUIManager
{
    public partial class AddMaterialToWareHouse : Form
    {
        public AddMaterialToWareHouse()
        {
            InitializeComponent();
            cbbKindOfMaterial.Items.AddRange(NguyenLieuBLL.Instance.GetAllLoaiNguyenLieu().ToArray());

        }
        private void cbbKindOfMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKindOfMaterial.SelectedIndex != -1)
            {
                cbbMaterialName.Items.Clear();
                int ID_LoaiNguyenLieu = ((LoaiNguyenLieu)cbbKindOfMaterial.SelectedItem).ID_LoaiNguyenLieu;
                cbbMaterialName.Items.AddRange(NguyenLieuBLL.Instance.GetAllNguyenLieuByIdLoaiNguyenLieu(ID_LoaiNguyenLieu).ToArray());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbbKindOfMaterial.SelectedIndex = -1;
            cbbManufacturer.SelectedIndex = -1;
            cbbMaterialName.SelectedIndex = -1;
            txtQuantity.Text = "";
            dtpImportDay.Value = DateTime.Now;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //cung nguyen lieu & ngay nhap ==> + vao luong ton kho

        private void btnAddMaterialToWareHouse_Click(object sender, EventArgs e)
        {
            if (cbbKindOfMaterial.SelectedIndex != -1 && cbbMaterialName.SelectedIndex != -1 && cbbManufacturer.SelectedIndex != -1 && dtpImportDay.Checked != false)
            {
                foreach (Kho i in BLL.KhoBLL.Instance.GetAllKho())
                {
                    if (i.NguyenLieu.TenNguyenLieu == cbbMaterialName.SelectedItem.ToString()
                        && i.NhaCungCap.TenNhaCungCap == cbbManufacturer.SelectedItem.ToString()
                        && i.NgayNhap.ToShortDateString() == dtpImportDay.Value.ToShortDateString())
                    {
                        KhoBLL.Instance.UpdateLuongNhapVaoVaLuongTonKho(i, Convert.ToInt32(txtQuantity.Text.ToString()));
                        GUI.NoticeBox box = new NoticeBox("Add material successfully!");
                        box.ShowDialog();
                        this.Close();
                    }

                    else
                    {
                        NguyenLieu nl = (NguyenLieu)(cbbMaterialName.SelectedItem);
                        NhaCungCap ncc = (NhaCungCap)(cbbManufacturer.SelectedItem);
                        Kho kho = new Kho
                        {
                            ID_ChiTietNguyenLieu = NguyenLieuBLL.Instance.GetNewIDChiTietNguyenLieu(),
                            ID_NguyenLieu = nl.ID_NguyenLieu,
                            ID_NhaCungCap = ncc.ID_NhaCungCap,
                            NgayNhap = dtpImportDay.Value,
                            NgayHetHan = dtpImportDay.Value.AddDays(nl.HSD),
                            LuongNhapVao = Convert.ToInt32(txtQuantity.Text.ToString()),
                            LuongTonKho = Convert.ToInt32(txtQuantity.Text.ToString()),
                        };
                        KhoBLL.Instance.AddMaterialToWareHouse(kho);
                        GUI.NoticeBox box = new NoticeBox("Add material successfully!");
                        box.ShowDialog();
                        this.Close();
                        break;
                    }
                }
            }
            else
            {
                GUI.NoticeBox box = new NoticeBox("Please fill fully information!");
                box.Show();
            }


        }

        private void btnManufacturerManagement_Click(object sender, EventArgs e)
        {
            frmGUIManager.ManufacturerManagement frm = new ManufacturerManagement();
            frm.ShowDialog();
            cbbMaterialName.SelectedIndex = -1;
            cbbManufacturer.Items.Clear();
        }

        private void cbbMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaterialName.SelectedIndex != -1)
            {
                cbbManufacturer.Items.Clear();
                int ID_NguyenLieu = ((NguyenLieu)cbbMaterialName.SelectedItem).ID_NguyenLieu;
                cbbManufacturer.Items.AddRange(NhaCungCapBLL.Instance.GetAllNhaCungCapByIDNguyenLieu(ID_NguyenLieu).ToArray());
            }
        }
    }
}
