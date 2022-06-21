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

        void SetTable(Panel pn, TableForOrdering tb)
        {
            tb.Width = 250;
            tb.Height = 200;
            pn.Controls.Add(tb);
        }
        private void LoadDishByStatusDish(int st)
        {
            dgvStatusDish = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel2.Controls.Add(dgvStatusDish);
            dgvStatusDish.Dock = DockStyle.Fill;
            Image NotReadyImage = PBL3_Remake.Properties.Resources.uncheckedRed;
            Image ReadyImage = PBL3_Remake.Properties.Resources.checkedGreen;
            dgvStatusDish.DataSource = BanBLL.Instance.GetAllDetailTableByStatus(st);
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            dgvStatusDish.Columns.Add(imgcol);
            foreach (DataGridViewRow i in dgvStatusDish.Rows)
            {
                if (i.Cells[4].Value.ToString() == "1")
                {
                    imgcol.Image = ReadyImage;
                }
                if (i.Cells[4].Value.ToString() == "0")
                {
                    imgcol.Image = NotReadyImage;
                }
            }
            dgvStatusDish.Columns[5].Visible = false;
            dgvStatusDish.Columns[6].Visible = false;
            dgvStatusDish.CellClick += dgvStatusDish_CellsClick;
            dgvStatusDish.ReadOnly = true;
            dgvStatusDish.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatusDish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        //private void cbbStatusDish_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    RemoveTable();
        //    if (cbbStatusDish.SelectedIndex == 0)
        //        LoadDishByStatusDish(0);
        //    else if (cbbStatusDish.SelectedIndex == 1)
        //        LoadDishByStatusDish(1);
        //}
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
        void RemoveTable()
        {
            guna2Panel2.Controls.Clear();
        }
        private void btnReady_Click(object sender, EventArgs e)
        {
            RemoveTable();
            LoadDishByStatusDish(1);
        }

        private void btnNoReady_Click(object sender, EventArgs e)
        {
            RemoveTable();
            LoadDishByStatusDish(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
