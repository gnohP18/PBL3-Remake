using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUISeller
{
    public partial class frmMainSeller : Form
    {
        public frmMainSeller(int ID_NhanVien)
        {
            InitializeComponent();
            SetCbb();
            d = new Mydel(LoadBanByTinhTrangBanVaTang);
            this.ID_NhanVien = ID_NhanVien;
        }
        #region Local Variable
        private int Floor = 1;
        private int statustb = -1;
        public delegate void Mydel(int st, int fl);
        public Mydel d { get; set; }
        private int ID_NhanVien;
        #endregion
        #region Function
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
                tb[dem1] = new TableForOrdering(i, ID_NhanVien);
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

        #endregion
        #region Event Form
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
        private void frmMainSeller_Load(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;
            pnTable.AutoScroll = true;
            LoadBanByTinhTrangBanVaTang(-1, 1);
            if (NhanVienBLL.Instance.GetNhanVienByID(ID_NhanVien).ID_ChucVu == 3) btnAttend.Visible = true;
            else btnAttend.Visible = false;
            lblTitleWelcome.Text = NhanVienBLL.Instance.GetNhanVienByID(ID_NhanVien).TenUser;
            Real_time.Start();
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
            this.Owner.Show();
            this.Dispose();
        }

        private void btnDetailTable_Click(object sender, EventArgs e)
        {
            frmGUISeller.DetailTable frm = new DetailTable();
            frm.Show();
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            frmGUISeller.frmAttendance form = new frmAttendance();
            form.ShowDialog();
        }
        private void Real_time_Tick(object sender, EventArgs e)
        {
            lblTimeWork.Text = DateTime.Now.ToShortTimeString();
        }
        #endregion

    }
}
