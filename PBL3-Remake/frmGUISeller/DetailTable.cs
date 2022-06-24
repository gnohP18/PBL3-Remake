using GUI.frmGUISeller;
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
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            dgvStatusDish.Columns.Add(imgcol);
            dgvStatusDish.CellClick += dgvStatusDish_CellsClick;
            dgvStatusDish.ReadOnly = true;
            dgvStatusDish.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatusDish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void dgvStatusDish_CellsClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                /*int idctb = Convert.ToInt32(dgvStatusDish.SelectedRows[0].Cells["ID_ChiTietBan"].Value.ToString());
                frmStatusDish frm = new frmStatusDish(idctb);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();*/
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
