using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIManager
{
    public partial class MatetialInformation : Form
    {
        public MatetialInformation()
        {
            InitializeComponent();
            dgvNguyenLieu.DataSource = NguyenLieuBLL.Instance.GetAllNguyenLieu();
            dgvNguyenLieu.Columns["ID_LoaiNguyenLieu"].Visible = false;
            dgvNguyenLieu.Columns["ChiTietNhaCungCaps"].Visible = false;
            dgvNguyenLieu.Columns["Khoes"].Visible = false;
            dgvNguyenLieu.Columns["ChiTietMonAns"].Visible = false;
            ReloadDgv(0);
        }

        void ReloadDgv(int IDLoaiNguyenLieu)
        {
            if (IDLoaiNguyenLieu == 0)
            {
                dgvNguyenLieu.DataSource = NguyenLieuBLL.Instance.GetAllNguyenLieu();
            }

            else
            {
                dgvNguyenLieu.DataSource = NguyenLieuBLL.Instance.GetAllNguyenLieuByIdLoaiNguyenLieu(IDLoaiNguyenLieu);
            }


        }
        private void btnFreshFood_Click(object sender, EventArgs e)
        {
            ReloadDgv(1);
        }
        private void btnVegetable_Click(object sender, EventArgs e)
        {
            ReloadDgv(2);
        }
        private void btnDriedFood_Click(object sender, EventArgs e)
        {
            ReloadDgv(3);
        }
        private void btnDrinking_Click(object sender, EventArgs e)
        {
            ReloadDgv(4);
        }

        private void btnAllMaterial_Click(object sender, EventArgs e)
        {
            ReloadDgv(0);
        }

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            DetailMaterial frm = new DetailMaterial(-1);
            frm.d = new DetailMaterial.MyDel(ReloadDgv);
            frm.Show();
        }

        private void btnUpdateMaterial_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count == 1)
            {
                DetailMaterial frm = new DetailMaterial(Convert.ToInt32(dgvNguyenLieu.SelectedRows[0].Cells["ID_NguyenLieu"].Value));
                frm.d = new DetailMaterial.MyDel(ReloadDgv);
                frm.Show();
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (DataGridViewRow i in dgvNguyenLieu.SelectedRows)
            {
                list.Add(Convert.ToInt32(i.Cells["ID_NguyenLieu"].Value.ToString()));
            }
            NguyenLieuBLL.Instance.DelNguyenLieu(list);
            ReloadDgv(0);
            NoticeBox box = new NoticeBox("Delete material success!");
            box.Show();
        }
    }
}
