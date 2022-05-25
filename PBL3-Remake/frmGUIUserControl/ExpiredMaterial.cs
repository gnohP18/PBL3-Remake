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
    public partial class ExpiredMaterial : Form
    {
        public ExpiredMaterial()
        {
            InitializeComponent();
            ReloadDGV();
        }
        void ReloadDGV()
        {
            dgvExpiredMaterial.DataSource = BLLQLNH.Instance.getListNguyenLieuHetHan();
            dgvExpiredMaterial.ReadOnly = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> ListID_ChiTietNguyenLieuXoa = new List<int>();
            foreach(DataGridViewRow i in dgvExpiredMaterial.SelectedRows)
            {
                ListID_ChiTietNguyenLieuXoa.Add(Convert.ToInt32(i.Cells["ID_ChiTietNguyenLieu"].Value.ToString()));
            }
            BLLQLNH.Instance.DelChiTietNguyenLieu(ListID_ChiTietNguyenLieuXoa);
            ReloadDGV();
        }
    }
}
