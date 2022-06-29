using BLL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class DetailTable : Form
    {

        Image NotReadyImage = GUI.Properties.Resources.uncheckedRed;
        Image ReadyImage = GUI.Properties.Resources.checkedGreen;
        DataGridViewImageColumn colImg;

        public DetailTable()
        {
            InitializeComponent();
            dgvDetailTable.DataSource = BanBLL.Instance.GetAllChiTietBan_ViewByStatus(1);
            dgvDetailTable.Columns["ID_ChiTietBan"].Visible = false;
            dgvDetailTable.Columns["TinhTrang"].Visible = false;
            colImg = new DataGridViewImageColumn();
            colImg.Image = ReadyImage;
            colImg.HeaderText = "TinhTrang";
            colImg.Name = "TinhTrang";
            dgvDetailTable.Columns.Add(colImg);
        }

        private void LoadDishByStatusDish(int st)
        {
            dgvDetailTable.DataSource = BanBLL.Instance.GetAllChiTietBan_ViewByStatus(st);
            if (st == 1)
            {
                colImg.Image = ReadyImage;
                btnExecute.Visible = false;
            }
            else
            {
                colImg.Image = NotReadyImage;
                btnExecute.Visible =true;
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

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if(dgvDetailTable.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dgvDetailTable.SelectedRows)
                {
                    BanBLL.Instance.ExecuteFood(Convert.ToInt32(i.Cells["ID_ChiTietBan"].Value));
                    btnNoReady.PerformClick();
                }
            }
        }
    }
}
