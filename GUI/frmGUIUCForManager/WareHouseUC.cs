using BLL;
using System;
using System.Windows.Forms;
using GUI.frmGUIManager;
namespace GUI.frmGUIUCForManager
{

    public partial class WareHouseUC : UserControl
    {
        private static WareHouseUC _Instance;
        public static WareHouseUC Instance
        {
            get { if (_Instance == null) _Instance = new WareHouseUC(); return _Instance; }
        }
        public WareHouseUC(bool isSeller = false)
        {
            InitializeComponent();
            if (isSeller)
            {
                btnAddMaterialToWareHouse.Visible = false;
                btnViewExpiredMaterial.Visible = false;
                btnMaterialInformation.Visible = false;
            }
        }
        private void btnMoreInfor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvNguyenLieuKho.SelectedRows[0].Cells["ID_NguyenLieu"].Value.ToString());
            InfoFood frm = new InfoFood(id);
            frm.Show();
        }

        private void btnAddNewManuFacturer_Click(object sender, EventArgs e)
        {
            frmGUIManager.AddNewManufacturer frm = new frmGUIManager.AddNewManufacturer();
            frm.Show();
        }
        void Show(int IDNguyenLieu)
        {
            dgvNguyenLieuKho.DataSource = NguyenLieuBLL.Instance.GetListNguyenLieuTrongKhoByIdLoaiNguyenLieu(IDNguyenLieu);
        }
        private void btnFreshFood_Click(object sender, EventArgs e)
        {
            Show(1);
        }
        private void btnVegetable_Click(object sender, EventArgs e)
        {
            Show(2);
        }
        private void btnDriedFood_Click(object sender, EventArgs e)
        {
            Show(3);
        }
        private void btnDrinking_Click(object sender, EventArgs e)
        {
            Show(4);
        }


        private void dgvNguyenLieuKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = Convert.ToInt32(dgvNguyenLieuKho.SelectedRows[0].Cells["ID_NguyenLieu"].Value.ToString());
            txtNameFood.Text = dgvNguyenLieuKho.SelectedRows[0].Cells["TenNguyenLieu"].Value.ToString();
            txtAmountFood.Text = dgvNguyenLieuKho.SelectedRows[0].Cells["LuongTonKho"].Value.ToString();
        }

        private void btnMoreInfor_Click_1(object sender, EventArgs e)
        {
            if (dgvNguyenLieuKho.SelectedRows.Count == 1)
            {
                int ID_NguyenLieu = Convert.ToInt32(dgvNguyenLieuKho.SelectedRows[0].Cells["ID_NguyenLieu"].Value);
                frmGUIManager.MaterialInfo frm = new MaterialInfo(ID_NguyenLieu);
                frm.Show();
            }
        }

        private void btnViewExpiredMaterial_Click(object sender, EventArgs e)
        {
            frmGUIManager.ExpiredMaterial frm = new ExpiredMaterial();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnAddMaterialToWareHouse_Click(object sender, EventArgs e)
        {
            frmGUIManager.AddMaterialToWareHouse frm = new AddMaterialToWareHouse();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnMaterialInformation_Click(object sender, EventArgs e)
        {
            frmGUIManager.MatetialInformation frm = new MatetialInformation();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnAllMaterial_Click(object sender, EventArgs e)
        {
            dgvNguyenLieuKho.DataSource = NguyenLieuBLL.Instance.GetListNguyenLieuTrongKhoByIdLoaiNguyenLieu(0);
        }
    }
}
