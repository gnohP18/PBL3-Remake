using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class MatetialInformation : Form
    {
        public MatetialInformation()
        {
            InitializeComponent();
            ReloadDgv(0);
        }

        void ReloadDgv(int IDLoaiNguyenLieu)
        {
            if (IDLoaiNguyenLieu == 0)
            {
                dgvNguyenLieu.DataSource = BLLQLNH.Instance.GetAllNguyenLieu();
            }

            else {
                dgvNguyenLieu.DataSource = BLLQLNH.Instance.GetListNguyenLieuByIdLoaiNguyenLieu(IDLoaiNguyenLieu);
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
    }
}
