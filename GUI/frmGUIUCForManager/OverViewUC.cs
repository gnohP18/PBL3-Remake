using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI.frmGUIManager;
namespace GUI.frmGUIUCForManager
{
    public partial class OverViewUC : UserControl
    {
        private static OverViewUC _Instance;
        public static OverViewUC Instance
        {
            get { if (_Instance == null) _Instance = new OverViewUC(); return _Instance; }
        }
        public OverViewUC()
        {
            InitializeComponent();
        }
        #region Local Variable
        private int CurrentFloor { get; set; }
        private int CurrentStatus { get; set; }
        private int NumberOfOrdered { get; set; }
        private int TotalRevenue { get; set; }
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
            dgvTable.DataSource = BanBLL.Instance.GetAllTable_viewByFloorAndStatus(0, CurrentFloor);
        }
        private void SetDataForDateCustom()
        {
            NumberOfOrdered = BLL.ThongKeBLL.Instance.GetNumberOfOrdered(CurrentDay);
            TotalRevenue = BLL.ThongKeBLL.Instance.GetTotalRevenue(CurrentDay);
            Profit = BLL.ThongKeBLL.Instance.GetProfit(CurrentDay);
            Consuming = TotalRevenue - Profit;
            DC_v.Add(AddDV_v(Consuming, CurrentDay, "Consuming"));
            DC_v.Add(AddDV_v(TotalRevenue, CurrentDay, "TotalRevenue"));
            DC_v.Add(AddDV_v(Profit, CurrentDay, "Profit"));
            Overviewchart.Series[0].Points.Clear();
            lblOrdered.Text = NumberOfOrdered.ToString();
            lblProfit.Text = Profit.ToString();
            lblTotalRevenue.Text = TotalRevenue.ToString();
            lblConsuming.Text = Consuming.ToString();
            Overviewchart.DataSource = DC_v;
            Overviewchart.Series[0].YValueMembers = "Value";
            Overviewchart.Series[0].XValueMember = "Text";
        }
        private void GUI()
        {
            SetupDataGridView();
            SetDataForDateCustom();
            int BusyTableFloor1 = BanBLL.Instance.GetAllTableByFloor(1).Count - BanBLL.Instance.GetMainBanByTinhTrangBanVaTang(0, 1).Count;
            int BusyTableFloor2 = BanBLL.Instance.GetAllTableByFloor(2).Count - BanBLL.Instance.GetMainBanByTinhTrangBanVaTang(0, 2).Count;
            lblNumberofTableFl1.Text = BusyTableFloor1.ToString();
            lblNumberofTableFl2.Text = BusyTableFloor2.ToString();
            cbbStatusTable.Items.Add("All");
            cbbStatusTable.Items.Add("Emty");
            cbbStatusTable.Items.Add("Busy");
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
            frm.ShowDialog();
        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            CurrentFloor = 1;
            dgvTable.DataSource = BanBLL.Instance.GetAllTable_viewByFloorAndStatus(CurrentStatus, CurrentFloor);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            CurrentFloor = 2;
            dgvTable.DataSource = BanBLL.Instance.GetAllTable_viewByFloorAndStatus(CurrentStatus, CurrentFloor);
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTable.CurrentCell.RowIndex;
            int ID_Tabel_view = Convert.ToInt32(dgvTable.Rows[index].Cells[0].Value.ToString());
            DetailTable frm = new DetailTable(ID_Tabel_view);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void cbbStatusTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CurrentStatus = cbbStatusTable.SelectedIndex;
            dgvTable.DataSource = BanBLL.Instance.GetAllTable_viewByFloorAndStatus(CurrentStatus, CurrentFloor);
        }
    }
}


