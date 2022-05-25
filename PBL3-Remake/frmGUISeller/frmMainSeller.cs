using BLL;
using Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmMainSeller : Form
    {
        public frmMainSeller()
        {
            InitializeComponent();
            SetCbb();
        }

        private void frmMainSeller_Load(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;
            pnTable.AutoScroll = true;
            LoadAllBanWithTang(1);
        }

        void SetCbb()
        {
            cbbStatusTable.Items.Add("All");
            cbbStatusTable.Items.Add("Emty");
            cbbStatusTable.Items.Add("Busy");
            //cbbStatusDish.Items.Add("All");
            cbbStatusDish.Items.Add("No ready");
            cbbStatusDish.Items.Add("Done");
        }

        private int Floor = 0;
        private bool statustb;
        void SetTable(Panel pn, TableForOrdering tb, int id, int fl, bool st)
        {
            tb.Width = 250;
            tb.Height = 200;
            pn.Controls.Add(tb);
            tb.IDTable = id;
            tb.Floor = fl;
            tb.statusTable = st;
            tb.GUITable();
        }

        void LoadAllBanWithTang(int fl)
        {
            int soban = BLLNVNH.Instance.NumberOfStatusAndFloor(true, fl) + BLLNVNH.Instance.NumberOfStatusAndFloor(false, fl);
            Console.WriteLine("Soban " + soban);
            TableForOrdering[] tb = new TableForOrdering[soban];
            int dem1 = 0;
            foreach (Ban i in BLLNVNH.Instance.GetAllBanByTang(fl))
            {
                tb[dem1] = new TableForOrdering();
                tb[dem1].IDTable = i.ID_Ban;
                tb[dem1].NameTable = i.TenBan;
                tb[dem1].Floor = i.Tang;
                int ttb = i.TinhTrangBan;
                if (ttb == 0)
                    tb[dem1].statusTable = false;
                else tb[dem1].statusTable = true;
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
                    //Console.WriteLine(tb[i].IDTable + " " + Ly + " " + Lx);
                    SetTable(pnTable, tb[i], tb[i].IDTable, Floor, tb[i].statusTable);
                }
            }
        }

        void LoadBanWithTinhTrangBanVaTang(bool st, int fl)
        {
            int soban = BLLNVNH.Instance.NumberOfStatusAndFloor(st, fl);
            TableForOrdering[] tb = new TableForOrdering[soban];
            int dem1 = 0;
            foreach (Ban i in BLLNVNH.Instance.GetAllBanByTinhTrangBanVaTang(st, fl))
            {
                tb[dem1] = new TableForOrdering();
                tb[dem1].IDTable = i.ID_Ban;
                tb[dem1].NameTable = i.TenBan;
                tb[dem1].Floor = i.Tang;
                int ttb = i.TinhTrangBan;
                if (ttb == 0)
                    tb[dem1].statusTable = false;
                else tb[dem1].statusTable = true;
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
                    //Console.WriteLine(tb[i].IDTable + " " + Ly + " " + Lx);
                    SetTable(pnTable, tb[i], tb[i].IDTable, Floor, tb[i].statusTable);
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
            RemoveTable();
            LoadBanWithTinhTrangBanVaTang(statustb, Floor);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            Floor = 2;
            RemoveTable();
            LoadBanWithTinhTrangBanVaTang(statustb, Floor);
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStatusTable.SelectedIndex == 1)
            {
                statustb = true;
                RemoveTable();
                LoadBanWithTinhTrangBanVaTang(statustb, Floor);
            }
            else if (cbbStatusTable.SelectedIndex == 2)
            {
                statustb = false;
                RemoveTable();
                LoadBanWithTinhTrangBanVaTang(statustb, Floor);
            }
            else if (cbbStatusTable.SelectedIndex == 0)
            {
                RemoveTable();
                LoadAllBanWithTang(Floor);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataGridView dgvStatusDish;
        private void LoadDishByStatusDish(int st)
        {
            //DataGridView 
            dgvStatusDish = new DataGridView();
            pnTable.Controls.Add(dgvStatusDish);
            dgvStatusDish.Dock = DockStyle.Fill;
            Image NotReadyImage = PBL3_Remake.Properties.Resources.uncheckedRed;
            Image ReadyImage = PBL3_Remake.Properties.Resources.checkedGreen;
            dgvStatusDish.DataSource = BLLNVNH.Instance.GetAllDetailTableByStatus(st);
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
        private void cbbStatusDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveTable();
            if (cbbStatusDish.SelectedIndex == 0)
                LoadDishByStatusDish(0);
            else if (cbbStatusDish.SelectedIndex == 1)
                LoadDishByStatusDish(1);
            //else if (cbbStatusDish.SelectedIndex == 0)
            //  LoadDishByStatusDish(3);
        }
        private void dgvStatusDish_CellsClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                int idctb = Convert.ToInt32(dgvStatusDish.SelectedRows[0].Cells["ID_ChiTietBan"].Value.ToString());
                Console.WriteLine("ID=" + idctb);
                frmStatusDish frm = new frmStatusDish(idctb);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }
    }
}
