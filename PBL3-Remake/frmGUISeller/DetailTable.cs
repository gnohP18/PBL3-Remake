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
        }

        private void LoadDishByStatusDish(int st)
        {
            Image NotReadyImage = PBL3_Remake.Properties.Resources.uncheckedRed;
            Image ReadyImage = PBL3_Remake.Properties.Resources.checkedGreen;

            dgvStatusDish.DataSource = BanBLL.Instance.GetAllChiTietBan_ViewByStatus(st);
            foreach (ChiTietBan_View i in BanBLL.Instance.GetAllChiTietBan_ViewByStatus(st))
            {
                Console.WriteLine(i.TenBan + " " + i.TenMonAn);
            }
            //DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            //if (st == 1) imgcol.Image = ReadyImage;
            //else imgcol.Image = NotReadyImage;
            //dgvStatusDish.Columns.Add(imgcol);
            //dgvStatusDish.CellClick += dgvStatusDish_CellsClick;
            //dgvStatusDish.ReadOnly = true;
            //dgvStatusDish.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvStatusDish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void dgvStatusDish_CellsClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                int idctb = Convert.ToInt32(dgvStatusDish.SelectedRows[0].Cells["ID_ChiTietBan"].Value.ToString());
                frmStatusDish frm = new frmStatusDish(idctb);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {

            //LoadDishByStatusDish(1);
            //dgvStatusDish.DataSource = BanBLL.Instance.GetAllChiTietBan_ViewByStatus(1);
            LoadDishByStatusDish(1);
        }

        private void btnNoReady_Click(object sender, EventArgs e)
        {
            //LoadDishByStatusDish(0);
            //dgvStatusDish.DataSource = BanBLL.Instance.GetAllChiTietBan_ViewByStatus(0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
