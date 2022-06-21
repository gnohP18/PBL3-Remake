using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmMainSeller : Form
    {
        private int Floor = 1;
        private int statustb = -1;
        public delegate void Mydel(int st, int fl);
        public Mydel d { get; set; }
        private User _user { get; set; }
        public frmMainSeller()
        {
            //_user = user;
            InitializeComponent();
            SetCbb();
            d = new Mydel(LoadBanByTinhTrangBanVaTang);
        }

        private void frmMainSeller_Load(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;
            pnTable.AutoScroll = true;
            LoadBanByTinhTrangBanVaTang(-1, 1);
            //if (_user.ChucVu.ID_ChucVu == 3)
            //{
            //    btnRollUp.Visible = true;
            //}
            //else
            //{
            //    btnRollUp.Visible = false;
            //}
        }

        void SetCbb()
        {
            cbbStatusTable.Items.Add("All");
            cbbStatusTable.Items.Add("Emty");
            cbbStatusTable.Items.Add("Busy");
            cbbStatusTable.SelectedIndex = 0;
        }


        void SetTable(Panel pn, TableForOrdering tb)
        {
            tb.Width = 250;
            tb.Height = 200;
            pn.Controls.Add(tb);
        }
        void LoadBanByTinhTrangBanVaTang(int st, int fl)
        {
            RemoveTable();
            List<Ban> listBan = BanBLL.Instance.GetMainBanByTinhTrangBanVaTang(st, fl);
            int soban = listBan.Count;
            TableForOrdering[] tb = new TableForOrdering[soban];
            int dem1 = 0;
            foreach (Ban i in listBan)
            {
                tb[dem1] = new TableForOrdering(i);
                tb[dem1].d = d;
                int ttb = i.TinhTrangBan;
                dem1++;
            }
            int soluongban = soban;
            if (soluongban != 0)
            {
                for (int i = 0; i < tb.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 4 == 0) Lx = 20;
                    else if (i % 4 == 1)
                    {
                        Lx = 330;
                    }
                    else if (i % 4 == 2)
                    {
                        Lx = 630;
                    }
                    else if (i % 4 == 3)
                    {
                        Lx = 930;
                    }
                    int thuong = Convert.ToInt32(i / 4);
                    Ly = 25 + 260 * thuong;
                    tb[i].SetLocation(Lx, Ly);
                    SetTable(pnTable, tb[i]);
                }
            }
        }
        void RemoveTable()
        {
            pnTable.Controls.Clear();
        }
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            Floor = 1;
            LoadBanByTinhTrangBanVaTang(statustb, Floor);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            Floor = 2;
            LoadBanByTinhTrangBanVaTang(statustb, Floor);
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStatusTable.SelectedIndex == 1)
            {
                statustb = 0;
                LoadBanByTinhTrangBanVaTang(statustb, Floor);
            }
            else if (cbbStatusTable.SelectedIndex == 2)
            {
                statustb = 1;
                LoadBanByTinhTrangBanVaTang(statustb, Floor);
            }
            else if (cbbStatusTable.SelectedIndex == 0)
            {
                statustb = -1;
                LoadBanByTinhTrangBanVaTang(statustb, Floor);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataGridView dgvStatusDish;
        private void LoadDishByStatusDish(int st)
        {
            dgvStatusDish = new DataGridView();
            pnTable.Controls.Add(dgvStatusDish);
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

        private void btnAttendance_Click(object sender, EventArgs e)
        {

        }


        private void btnDetailTable_Click(object sender, EventArgs e)
        {

        }

    }
}
