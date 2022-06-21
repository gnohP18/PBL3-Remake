using System;
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
    public partial class frmAttendence : Form
    {
        public frmAttendence()
        {
            InitializeComponent();
        }

        private void frmAttendence_Load(object sender, EventArgs e)
        {
            Dictionary<User,bool> listNhanVien = NhanVienBLL.Instance.GetThongTinDiemDanhNhanVienNow();
            foreach(KeyValuePair<User,bool> i in listNhanVien)
            {
                pnNhanVien.Controls.Add(new frmGUIUserControl.CheckBoxUC(i));
            }
        }
    }
}
