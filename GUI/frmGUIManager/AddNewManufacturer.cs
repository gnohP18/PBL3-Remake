using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.frmGUIManager
{
    public partial class AddNewManufacturer : Form
    {
        public AddNewManufacturer()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNameNewManufacturer.Text != "" && txtAddressManufacture.Text != "" && txtPhoneNumberManufacture.Text != "" && txtTaxCode.Text != "")
            {
                NhaCungCap ncc = new NhaCungCap
                {
                    ID_NhaCungCap = NhaCungCapBLL.Instance.GetNewIDNhaCungCap(),
                    TenNhaCungCap = txtNameNewManufacturer.Text,
                    DiaChi = txtAddressManufacture.Text,
                    MaSoThue = txtTaxCode.Text,
                    SoDienThoai = txtPhoneNumberManufacture.Text
                };
                NhaCungCapBLL.Instance.AddNewNhaCungCap(ncc);

                GUI.NoticeBox box = new NoticeBox("Add new manufacturer successfully");
                box.Show();
            }
            else
            {
                GUI.NoticeBox box = new NoticeBox("Please fill fully information!");
                box.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAddressManufacture.Text = "";
            txtNameNewManufacturer.Text = "";
            txtPhoneNumberManufacture.Text = "";
            txtTaxCode.Text = "";
        }
    }
}
