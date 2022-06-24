﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using DTO;
using BLL;
namespace GUI.frmGUISeller
{
    public partial class frmAttendance : Form
    {
        Dictionary<User, bool> ListNhanVien;
        List<int> ListIDNhanVien = new List<int>();
        public frmAttendance()
        {
            InitializeComponent();
            ListNhanVien = NhanVienBLL.Instance.GetThongTinDiemDanhNhanVienNow();
        }
        private void AddIDNhanVien(int IDNhanVien)
        {
            ListIDNhanVien.Add(IDNhanVien);
        }
        private void frmAttendence_Load(object sender, EventArgs e)
        {
            Dictionary<User,bool> listNhanVien = NhanVienBLL.Instance.GetThongTinDiemDanhNhanVienNow();
            foreach(KeyValuePair<User,bool> i in listNhanVien)
            {
                frmGUIUserControl.CheckBoxUC uc = new frmGUIUserControl.CheckBoxUC(i);
                uc.Add = new frmGUIUserControl.CheckBoxUC.AddDelegate(AddIDNhanVien);
                pnNhanVien.Controls.Add(uc);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach(int i in ListIDNhanVien)
            {
                NhanVienBLL.Instance.ChamCong(i);
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}