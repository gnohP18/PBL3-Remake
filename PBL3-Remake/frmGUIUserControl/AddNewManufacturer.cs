using Entity;
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

namespace GUI.frmGUIUserControl
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
                BLLQLNH.Instance.AddNewNhaCungCap(BLLQLNH.Instance.GetNewIDNhaCungCap(), txtNameNewManufacturer.Text, txtAddressManufacture.Text, txtTaxCode.Text, txtPhoneNumberManufacture.Text);

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
