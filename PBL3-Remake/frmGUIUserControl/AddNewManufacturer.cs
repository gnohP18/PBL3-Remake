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
            if(txtNameNewManufacturer.Text != "" && txtAddressManufacture.Text != "" && txtPhoneNumberManufacture.Text != "" && txtTaxCode.Text != "")
            {
                BLLQLNH.Instance.AddNewNhaCungCap(BLLQLNH.Instance.GetNewIDNhaCungCap(), txtNameNewManufacturer.Text, txtAddressManufacture.Text, txtTaxCode.Text, txtPhoneNumberManufacture.Text);
               
                MessageBox.Show("Add new manufacturer successfully");
            }
            else
            {
                MessageBox.Show("Please fill fully information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
