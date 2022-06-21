using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.frmGUISeller;
using System.Threading;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //LoadBanByTinhTrangBanVaTang(-1, 1);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            /*foreach(KeyValuePair<User,bool>  i in NhanVienBLL.Instance.GetThongTinDiemDanhNhanVienNow())
            {
                pn.Controls.Add(new frmGUIUserControl.CheckBoxUC(i));
            }*/
            foreach (KeyValuePair<CaLam, bool> i in CaLamBLL.Instance.GetAllCaLamByID_NhanVien(3))
            {
                pn.Controls.Add(new frmGUIUserControl.CheckBoxUC(i));
            }
        }
    }
}
