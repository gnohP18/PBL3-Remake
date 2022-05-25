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
            cbbKindOfMaterial.Items.AddRange(BLLQLNH.Instance.GetAllLoaiNguyenLieu().ToArray());
            cbbKindOfMaterial.DisplayMember = "TenLoaiNguyenLieu";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cbbKindOfMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbKindOfMaterial.SelectedIndex != -1)
            {
                cbbMaterialName.Items.Clear();
                cbbMaterialName.Items.AddRange(BLLQLNH.Instance.GetListNguyenLieuByIdLoaiNguyenLieu(cbbKindOfMaterial.SelectedIndex + 1).ToArray());
                //foreach(NguyenLieu i in BLLQLNH.Instance.GetListNguyenLieuByIdLoaiNguyenLieu(cbbKindOfMaterial.SelectedIndex + 1))
                //{
                //    cbbMaterialName.Items.Add(i);
                //}
                cbbMaterialName.DisplayMember = "TenNguyenLieu";
                cbbManufacturer.Items.Clear();
                cbbManufacturer.Items.AddRange(BLLQLNH.Instance.GetAllNhaCungCap().ToArray());
                cbbManufacturer.DisplayMember = "TenNhaCungCap";
            }
        }
    }
}
