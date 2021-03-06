using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GUI.frmGUIUCForSeller;
using Entity;
namespace GUI.frmGUISeller
{
    public partial class frmOrder : Form
    {
        public frmMainSeller.Mydel d;
        public int IDTable { get; set; }
        private int IDLoaiMonAn = 1;
        List<MonAn_View> listMonAnViewDaDat;
        List<MonAn_View> listMonAnViewDangDat;
        int ID_NhanVien;
        public frmOrder(int id,int ID_NhanVien)
        {
            IDTable = id;
            this.ID_NhanVien = ID_NhanVien;
            InitializeComponent();
            MonAnBLL.Instance.UpdateTrangThaiMonAn(NguyenLieuBLL.Instance.GetThongTinLuongNguyenLieuHienTai());
            listMonAnViewDangDat = new List<MonAn_View>();
            listMonAnViewDaDat = MonAnBLL.Instance.GetListMonAnByIDBan(IDTable);
            LoadDataGridView();
            dgvOrder.Columns["ID_MonAn"].Visible = false;
            dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AddButtonDataGridView();
            ShowDish("");
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            lblIDTable.Text = BanBLL.Instance.GetBanByID_Ban(IDTable).ID_Ban.ToString();
            lblNameTable.Text = BanBLL.Instance.GetBanByID_Ban(IDTable).TenBan;
            pnDish.AutoScroll = true;
            ShowDish("");

        }
        private void SetDish(Panel pn, DishForOrdering dsh)
        {
            dsh.Width = 180;
            dsh.Height = 180;
            pn.Controls.Add(dsh);
        }
        private void AddButtonDataGridView()
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Image = GUI.Properties.Resources.des_32;
            dgvOrder.Columns.Add(imageColumn);
        }
        private void LoadDataGridView()
        {
            List<MonAn_View> list = new List<MonAn_View>();
            list.AddRange(listMonAnViewDaDat);
            list.AddRange(listMonAnViewDangDat);
            dgvOrder.DataSource = list;
        }
        private void RemoveDish()
        {
            pnDish.Controls.Clear();
        }
        private void LoadDishOnDatagridview(MonAn MonAn)
        {
            bool checkMonAnExisted = false;
            List<int> listIDMonAn = new List<int>();
            foreach (MonAn_View i in listMonAnViewDangDat)
            {
                if (i.ID_MonAn == MonAn.ID_MonAn)
                {
                    i.SoLuong++;
                    i.ThanhTien += MonAn.ThanhTien;
                    checkMonAnExisted = true;
                    break;
                }
            }
            if (!checkMonAnExisted)
            {
                listMonAnViewDangDat.Add(new MonAn_View { ID_MonAn = MonAn.ID_MonAn, TenMonAn = MonAn.TenMonAn, SoLuong = 1, ThanhTien = MonAn.ThanhTien });
            }
            MonAnBLL.Instance.UpdateTrangThaiMonAn(NguyenLieuBLL.Instance.GetThongTinLuongNguyenLieuHienTai(), listMonAnViewDangDat);
            LoadDataGridView();
        }
        private void ShowDish(string txt)
        {
            RemoveDish();
            MonAnBLL.Instance.UpdateTrangThaiMonAn(NguyenLieuBLL.Instance.GetThongTinLuongNguyenLieuHienTai(), listMonAnViewDangDat);
            List<MonAn> listMonAn = MonAnBLL.Instance.GetMonAn(IDLoaiMonAn, txt, 1);
            int somon = listMonAn.Count;
            DishForOrdering[] dsh = new DishForOrdering[somon];
            int dem1 = 0;
            foreach (MonAn i in listMonAn)
            {
                dsh[dem1] = new DishForOrdering(i);
                dsh[dem1].d = new DishForOrdering.Mydel(LoadDishOnDatagridview);
                dem1++;
            }
            if (somon != 0)
            {
                for (int i = 0; i < dsh.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 4 == 0) Lx = 25;
                    else if (i % 4 == 1)
                    {
                        Lx = 235;
                    }
                    else if (i % 4 == 2)
                    {
                        Lx = 440;
                    }
                    else if (i % 4 == 3)
                    {
                        Lx = 645;
                    }
                    int thuong = Convert.ToInt32(i / 4);
                    Ly = 25 + 230 * thuong;
                    dsh[i].SetLocation(Lx, Ly);
                    SetDish(pnDish, dsh[i]);
                }
            }

        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 1;
            RemoveDish();
            ShowDish("");
        }

        private void btnMainDish_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 2;
            RemoveDish();
            ShowDish("");
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 3;
            RemoveDish();
            ShowDish("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDLoaiMonAn = 4;
            RemoveDish();
            ShowDish("");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //btnPay.Enabled = false;
            RemoveDish();
            frmPay frm = new frmPay(IDTable,ID_NhanVien);
            frm.d = new frmPay.Mydel(CloseOrder);
            frm.deleFrmMainSeller = d;
            frm.MdiParent = this;
            pnDish.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            pnDish.AutoScroll = false;
            frm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            BanBLL.Instance.Order(listMonAnViewDangDat, IDTable);
            if (listMonAnViewDangDat.Count > 0 && BanBLL.Instance.GetBanByID_Ban(IDTable).TinhTrangBan == 0)
                BanBLL.Instance.ChangeStatusTable(IDTable, IDTable);
            this.Close();
            d(0, 1);
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= listMonAnViewDaDat.Count)
            {
                listMonAnViewDangDat[e.RowIndex - listMonAnViewDaDat.Count].SoLuong--;
                if (listMonAnViewDangDat[e.RowIndex - listMonAnViewDaDat.Count].SoLuong == 0)
                {
                    listMonAnViewDangDat.RemoveAt(e.RowIndex - listMonAnViewDaDat.Count);
                }
                MonAnBLL.Instance.UpdateTrangThaiMonAn(NguyenLieuBLL.Instance.GetThongTinLuongNguyenLieuHienTai(), listMonAnViewDangDat);
                LoadDataGridView();
            }

        }

        private void btnCollabTable_Click(object sender, EventArgs e)
        {
            frmCollaborTable frm = new frmCollaborTable(BanBLL.Instance.GetBanByID_Ban(IDTable));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            listMonAnViewDaDat = MonAnBLL.Instance.GetListMonAnByIDBan(IDTable);
            LoadDataGridView();
        }

        private void CloseOrder()
        {
            d(0, 1);
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseOrder();
        }
    }
}
