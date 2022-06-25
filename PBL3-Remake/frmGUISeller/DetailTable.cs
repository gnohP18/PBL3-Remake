using BLL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class DetailTable : Form
    {
        public DetailTable()
        {
            InitializeComponent();
            dgvDetailTable.DataSource = BanBLL.Instance.GetAllChiTietBan_ViewByStatus(1);
            MessageBox.Show(BanBLL.Instance.GetAllChiTietBan_ViewByStatus(1).Count + "");
        }

        private void LoadDishByStatusDish(int st)
        {
            Image NotReadyImage = PBL3_Remake.Properties.Resources.uncheckedRed;
            Image ReadyImage = PBL3_Remake.Properties.Resources.checkedGreen;
            dgvDetailTable.DataSource = BanBLL.Instance.GetAllChiTietBan_ViewByStatus(st);
        }
        private void dgvStatusDish_CellsClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                int idctb = Convert.ToInt32(dgvDetailTable.SelectedRows[0].Cells["ID_ChiTietBan"].Value.ToString());
                frmStatusDish frm = new frmStatusDish(idctb);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            LoadDishByStatusDish(1);
        }

        private void btnNoReady_Click(object sender, EventArgs e)
        {
            LoadDishByStatusDish(0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
