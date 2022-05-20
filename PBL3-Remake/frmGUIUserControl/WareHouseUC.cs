using BLL;
using System;
using System.Windows.Forms;
namespace GUI.frmGUIUserControl
{

    public partial class WareHouseUC : UserControl
    {
        public WareHouseUC()
        {
            InitializeComponent();
            SetCBBKingOfFood();
        }

        public void SetCBBKingOfFood()
        {
            cbbKindOfFood.Items.Clear();
            cbbKindOfFood.Items.AddRange(BLLNVNH.Instance.GetKindOfFood().ToArray());
        }
        private void btnMoreInfor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvNguyenLieuKho.SelectedRows[0].Cells["ID_NguyenLieu"].Value.ToString());
            InfoFood frm = new InfoFood(id);
            frm.Show();
        }

        private void btnAddNewManuFacturer_Click(object sender, EventArgs e)
        {
            frmGUIUserControl.AddNewManufacturer frm = new frmGUIUserControl.AddNewManufacturer();
            frm.Show();
        }
        public void Show(int idNguyenLieu)
        {
            dgvNguyenLieuKho.DataSource = BLLQLNH.Instance.GetListNguyenLieuByIdLoaiNguyenLieu(idNguyenLieu);
        }
        private void btnDriedFood_Click(object sender, EventArgs e)
        {
            Show(3);
        }

        private void btnVegetable_Click(object sender, EventArgs e)
        {
            Show(2);
        }

        private void btnFreshFood_Click(object sender, EventArgs e)
        {
            Show(1);
        }

        private void btnDrinking_Click(object sender, EventArgs e)
        {
            Show(4);
        }


        private void dgvNguyenLieuKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = Convert.ToInt32(dgvNguyenLieuKho.SelectedRows[0].Cells["ID_NguyenLieu"].Value.ToString());
            txtNameFood.Text = dgvNguyenLieuKho.SelectedRows[0].Cells["TenNguyenLieu"].Value.ToString();
            txtAmountFood.Text = Convert.ToString(BLLNVNH.Instance.GetSoLuongNguyenLieuByIDNguyenLieu(count));
        }

    }
}

//txtNameFood.Text = dgvNguyenLieuKho.SelectedRows[0].Cells["TenNguyenLieu"].Value.ToString();