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
    public partial class AddMaterialToWareHouse : Form
    {
        public AddMaterialToWareHouse()
        {
            InitializeComponent();
            SetCBB();
        }
         void SetCBB()
        {
            cbbKindOfMaterial.Items.AddRange(BLLQLNH.Instance.GetAllTenLoaiNguyenLieu().ToArray());
            cbbKindOfMaterial.DisplayMember = "TenLoaiNguyenLieu";
        }


        private void cbbKindOfMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbKindOfMaterial.SelectedIndex != -1)
            {
                cbbMaterialName.Items.Clear();
                cbbMaterialName.Items.AddRange(BLLQLNH.Instance.GetListTenNguyenLieuByIdLoaiNguyenLieu(cbbKindOfMaterial.SelectedIndex + 1).ToArray());
                cbbManufacturer.Items.Clear();
                cbbManufacturer.Items.AddRange(BLLQLNH.Instance.GetAllTenNhaCungCap().ToArray());
            }
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            frmGUIUserControl.AddNewManufacturer frm = new frmGUIUserControl.AddNewManufacturer();
            frm.Show();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //cung nguyen lieu & ngay nhap ==> + vao luong ton kho

        private void btnAddMaterialToWareHouse_Click(object sender, EventArgs e)
        {
            if (cbbKindOfMaterial.SelectedIndex != -1 && cbbMaterialName.SelectedIndex != -1 && cbbManufacturer.SelectedIndex != -1 && dtpImportDay.Checked != false)
            {
                foreach (Kho i in BLL.BLLQLNH.Instance.GetAllKho())
                {
                    if (i.NguyenLieu.TenNguyenLieu == cbbMaterialName.SelectedItem.ToString() 
                        && i.NhaCungCap.TenNhaCungCap == cbbManufacturer.SelectedItem.ToString()
                        && i.NgayNhap == dtpImportDay.Value)
                    {
                        BLLQLNH.Instance.UpdateLuongNhapVaoVaLuongTonKho(i, Convert.ToInt32(txtQuantity.Text.ToString()));
                        MessageBox.Show("Add success");
                    } 
                }
            }
            else
            {

            }
            //
            //    dALQLNH.Khoes.Add(new Kho
            //    {
            //        ID_ChiTietNguyenLieu = BLLQLNH.Instance.GetNewIDChiTietNguyenLieu(),
            //        //ID_NguyenLieu = ,
            //        //ID_NhaCungCap = ,
            //        NgayNhap = dtpImportDay.Value,
            //        NgayHetHan = dtpImportDay.Value.AddDays(1), //
            //        LuongNhapVao = (float)Convert.ToDouble(txtQuantity.Text.ToString()),
            //        LuongTonKho = BLLQLNH.Instance.GetLuongTonKhoByIDNguyenLieu(BLLQLNH.Instance.GetNewIDNguyenLieu() - 1) + (float)Convert.ToDouble(txtQuantity.Text.ToString()),

            //    });
            //    MessageBox.Show("Add material successfully!");
                
            //}
            //else
            //{
            //    MessageBox.Show("Please fill fully information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}    
        }

        private void cbbMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbMaterialName.SelectedItem.ToString());
        }
    }
}
