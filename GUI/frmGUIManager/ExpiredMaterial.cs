using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIManager
{
    public partial class ExpiredMaterial : Form
    {
        public ExpiredMaterial()
        {
            InitializeComponent();
            dgvExpiredMaterial.DataSource = NguyenLieuBLL.Instance.getListNguyenLieuHetHan();
            dgvExpiredMaterial.Columns["ID_NhaCungCap"].Visible = false;
            dgvExpiredMaterial.Columns["ID_ChiTietNguyenLieu"].Visible = false;
            ReloadDGV();
        }
        void ReloadDGV()
        {
            dgvExpiredMaterial.DataSource = NguyenLieuBLL.Instance.getListNguyenLieuHetHan();
            dgvExpiredMaterial.ReadOnly = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            List<int> ListID_ChiTietNguyenLieuXoa = new List<int>();
            foreach (DataGridViewRow i in dgvExpiredMaterial.SelectedRows)
            {
                ListID_ChiTietNguyenLieuXoa.Add(Convert.ToInt32(i.Cells["ID_ChiTietNguyenLieu"].Value.ToString()));
            }
            NguyenLieuBLL.Instance.DelChiTietNguyenLieu(ListID_ChiTietNguyenLieuXoa);
            NoticeBox box = new NoticeBox("Delete successfull");
            box.Show();
            ReloadDGV();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            List<int> ListID_ChiTietNguyenLieuXoa = new List<int>();
            foreach (DataGridViewRow i in dgvExpiredMaterial.Rows)
            {
                ListID_ChiTietNguyenLieuXoa.Add(Convert.ToInt32(i.Cells["ID_ChiTietNguyenLieu"].Value.ToString()));
            }
            NguyenLieuBLL.Instance.DelChiTietNguyenLieu(ListID_ChiTietNguyenLieuXoa);
            NoticeBox box = new NoticeBox("Delete successfull");
            box.Show();
            ReloadDGV();
        }
    }
}
