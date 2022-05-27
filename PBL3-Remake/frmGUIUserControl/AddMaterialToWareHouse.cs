﻿using System;
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
        }


        private void cbbKindOfMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKindOfMaterial.SelectedIndex != -1)
            {
                cbbMaterialName.Items.Clear();
                cbbMaterialName.Items.AddRange(BLLQLNH.Instance.GetListNguyenLieuByIdLoaiNguyenLieu(cbbKindOfMaterial.SelectedIndex + 1).ToArray());
                cbbManufacturer.Items.Clear();
                cbbManufacturer.Items.AddRange(BLLQLNH.Instance.GetAllNhaCungCap().ToArray());
            }
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            frmGUIUserControl.AddNewManufacturer frm = new frmGUIUserControl.AddNewManufacturer();
            frm.Show();
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
                foreach (Kho i in BLL.BLLQLNH.Instance.GetAllKho())
                {
                    if (i.NguyenLieu.TenNguyenLieu == cbbMaterialName.SelectedItem.ToString()
                        && i.NhaCungCap.TenNhaCungCap == cbbManufacturer.SelectedItem.ToString()
                        && i.NgayNhap == dtpImportDay.Value)
                    {
                        BLLQLNH.Instance.UpdateLuongNhapVaoVaLuongTonKho(i, Convert.ToInt32(txtQuantity.Text.ToString()));
                        GUI.NoticeBox box = new NoticeBox("Add material successfully!");
                        box.Show();
                    }

                    else
                    {   NguyenLieu nl = (NguyenLieu)(cbbMaterialName.SelectedItem);
                        NhaCungCap ncc = (NhaCungCap)(cbbManufacturer.SelectedItem);
                        Kho kho = new Kho
                        {
                        ID_ChiTietNguyenLieu = BLLQLNH.Instance.GetNewIDChiTietNguyenLieu(),
                        ID_NguyenLieu = nl.ID_NguyenLieu,
                        ID_NhaCungCap = ncc.ID_NhaCungCap,
                        NgayNhap = dtpImportDay.Value,
                        NgayHetHan = dtpImportDay.Value.AddDays(nl.HSD),
                        LuongNhapVao = Convert.ToInt32(txtQuantity.Text.ToString()),
                        LuongTonKho = Convert.ToInt32(txtQuantity.Text.ToString()),
                    };
                        BLLQLNH.Instance.AddMaterialToWareHouse(kho);
                        GUI.NoticeBox box = new NoticeBox("Add material successfully!");
                        box.Show();
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


    }
}