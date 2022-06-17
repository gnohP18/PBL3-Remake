﻿using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class OverViewUC : UserControl
    {
        private static OverViewUC _Instance;
        public static OverViewUC Instance
        {
            get { if (_Instance == null) _Instance = new OverViewUC(); return _Instance; }
        }
        private OverViewUC()
        {
            InitializeComponent();
        }
        #region Local Variable
        private int CurrentFloor { get; set; }
        private int CurrentStatus { get; set; }
        private int NumberOfOrdered { get; set; }
        private int Total { get; set; }
        private int Profit { get; set; }
        private int Consuming { get; set; }
        private List<DayChart_view> DC_v = new List<DayChart_view>();
        private DateTime CurrentDay { get; set; }
        #endregion
        private DayChart_view AddDV_v(int value, DateTime date, string text)
        {
            DayChart_view dc = new DayChart_view();
            dc.Value = value;
            dc.Date = date;
            dc.Text = text;
            return dc;
        }
        private void SetupDataGridView()
        {
            dgvDanhSachHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachHoaDon.DataSource = BLL.HoaDonBLL.Instance.GetAllInvoice_viewByDay(CurrentDay);
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.DataSource = BLL.BLLNVNH.Instance.GetAllTable_viewByFloor(CurrentFloor);
        }
        private void SetDataForDateCustom()
        {
            NumberOfOrdered = BLL.ThongKeBLL.Instance.GetNumberOfOrdered(CurrentDay);
            Total = BLL.ThongKeBLL.Instance.GetTotal(CurrentDay);
            Profit = BLL.ThongKeBLL.Instance.GetProfit(CurrentDay);
            Consuming = Total - Profit;
            //Console.WriteLine(CurrentDay.ToShortDateString() + " " + NumberOfOrdered + " " + Profit + " " + Consuming + " " + Total);
            DC_v.Add(AddDV_v(Consuming, CurrentDay, "Consuming"));
            DC_v.Add(AddDV_v(Total, CurrentDay, "Total"));
            DC_v.Add(AddDV_v(Profit, CurrentDay, "Profit"));
            foreach (DayChart_view dc in DC_v)
            {
                Console.WriteLine(dc.Text + " " + dc.Value);
            }
            Overviewchart.Series[0].Points.Clear();
            lblOrdered.Text = NumberOfOrdered.ToString();
            lblProfit.Text = Profit.ToString();
            lblTotal.Text = Total.ToString();
            lblConsuming.Text = Consuming.ToString();
            Overviewchart.DataSource = DC_v;
            Overviewchart.Series[0].YValueMembers = "Value";
            Overviewchart.Series[0].XValueMember = "Text";
        }
        private void GUI()
        {
            SetupDataGridView();
            SetDataForDateCustom();
            int BusyTableFloor1 = BLL.BLLNVNH.Instance.GetAllTableByFloor(1).Count - BLL.BLLNVNH.Instance.GetMainBanByTinhTrangBanVaTang(0, 1).Count;
            int BusyTableFloor2 = BLL.BLLNVNH.Instance.GetAllTableByFloor(2).Count - BLL.BLLNVNH.Instance.GetMainBanByTinhTrangBanVaTang(0, 2).Count;
            lblNumberofTableFl1.Text = BusyTableFloor1.ToString();
            lblNumberofTableFl2.Text = BusyTableFloor2.ToString();
        }
        private void OverViewUC_Load(object sender, EventArgs e)
        {
            OverViewCalendar.MaxSelectionCount = 1;
            CurrentDay = OverViewCalendar.SelectionStart.Date;
            CurrentFloor = 1;
            RealTime.Start();
            GUI();
        }

        private void RealTime_Tick(object sender, EventArgs e)
        {
            lblRealTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDanhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDanhSachHoaDon.CurrentCell.RowIndex;
            int ID_HoaDon = Convert.ToInt32(dgvDanhSachHoaDon.Rows[index].Cells[0].Value.ToString());
            Invoice frm = new Invoice(ID_HoaDon);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            CurrentFloor = 1;
            SetupDataGridView();
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            CurrentFloor = 2;
            SetupDataGridView();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTable.CurrentCell.RowIndex;
            int ID_Tabel_view = Convert.ToInt32(dgvTable.Rows[index].Cells[0].Value.ToString());
            DetailTable frm = new DetailTable(ID_Tabel_view);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
