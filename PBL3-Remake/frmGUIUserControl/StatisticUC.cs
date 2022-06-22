using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.frmGUIUserControl
{
    public partial class StatisticUC : UserControl
    {
        private static StatisticUC _Instance;
        public static StatisticUC Instance
        {
            get { if (_Instance == null) _Instance = new StatisticUC(); return _Instance; }
        }
        #region Variable Instance
        List<Statistic_view> ListDoanhThu = new List<Statistic_view>();
        List<Statistic_view> DoanhThuTheoNgay = new List<Statistic_view>();
        private Statistic_view DoanhThuNgay = new Statistic_view();
        private List<DayChart_view> DC_v = new List<DayChart_view>();
        public DateTime DateCustom { get; set; }
        private int NumberOfOrdered { get; set; }
        private int Total { get; set; }
        private int Profit { get; set; }
        private int Consuming { get; set; }
        private DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
        #endregion
        public StatisticUC()
        {
            InitializeComponent();
        }
        private DayChart_view AddDV_v(int value, DateTime date, string text)
        {
            DayChart_view dc = new DayChart_view();
            dc.Value = value;
            dc.Date = date;
            dc.Text = text;
            return dc;
        }
        private void SetDataForMainChart(DateTime daystart, DateTime dayend)
        {
            int SumTotal = 0, SumComsuming = 0, SumProfit = 0;
            MainChart.Series[0].Points.Clear();
            List<Statistic_view> listbydate = new List<Statistic_view>();
            foreach (Statistic_view i in ListDoanhThu)
            {
                if (i.Date > daystart && i.Date < dayend)
                {
                    SumTotal += i.Total;
                    SumProfit += i.Profit;
                    SumComsuming += i.Consuming;
                    listbydate.Add(i);
                }
            }
            lblOrderDateTimeCustom.Text = listbydate.Count.ToString();
            lblConsumingDateTimeCustom.Text = SumComsuming.ToString();
            lblProfitDateTimeCustom.Text = SumProfit.ToString();
            lblTotalDateTimeCustom.Text = SumTotal.ToString();
            MainChart.ChartAreas[0].AxisY.Maximum = 5000000;
            MainChart.ChartAreas[0].AxisY.Minimum = -5000000;
            MainChart.DataSource = listbydate;
            MainChart.Series["Total"].YValueMembers = "Total";
            MainChart.Series["Total"].YValueType = ChartValueType.Int32;
            MainChart.Series["Total"].XValueMember = "Date";
            MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Weeks;
            MainChart.Series["Total"].XValueType = ChartValueType.Date;
            MainChart.Series["Profit"].YValueMembers = "Profit";
            MainChart.Series["Profit"].YValueType = ChartValueType.Int32;
            MainChart.Series["Profit"].XValueMember = "Date";
            MainChart.Series["Profit"].XValueType = ChartValueType.Date;
            MainChart.Series["Consuming"].YValueMembers = "Consuming";
            MainChart.Series["Consuming"].YValueType = ChartValueType.Int32;
            MainChart.Series["Consuming"].XValueMember = "Date";
            MainChart.Series["Consuming"].XValueType = ChartValueType.Date;
            MainChart.DataBind();
        }
        private void SetDataForDateCustom(DateTime date)
        {
            DayChart.Series[0].Points.Clear();
            DoanhThuTheoNgay.Clear();
            foreach (Statistic_view i in ListDoanhThu)
            {
                if (i.Date == date)
                {
                    DoanhThuNgay = i;
                    DoanhThuTheoNgay.Add(i);
                }
            }
            lblOrdered.Text = BLL.ThongKeBLL.Instance.GetNumberOfOrdered(date).ToString();
            lblProfit.Text = Profit.ToString();
            lblTotal.Text = Total.ToString();
            lblConsuming.Text = Consuming.ToString();
            //Console.WriteLine(date.ToShortDateString() + " " + NumberOfOrdered + " " + Profit + " " + Consuming + " " + Total);
            DayChart.DataSource = DC_v;
            DayChart.Series[0].YValueMembers = "Value";
            DayChart.Series[0].YValueType = ChartValueType.Int32;
            DayChart.Series[0].XValueMember = "Text";
            DayChart.DataBind();
        }
        private void StatisticUC_Load(object sender, EventArgs e)
        {
            ListDoanhThu = BLL.ThongKeBLL.Instance.GetAllDoanhThu();
            DateTime dt = DateTime.Now;
            NumberOfOrdered = BLL.ThongKeBLL.Instance.GetNumberOfOrdered(dt);
            Profit = BLL.ThongKeBLL.Instance.GetProfit(dt);
            Total = BLL.ThongKeBLL.Instance.GetTotal(dt);
            Consuming = Total - Profit;
            DC_v.Clear();
            DC_v.Add(AddDV_v(Consuming, dt, "Consuming"));
            DC_v.Add(AddDV_v(Total, dt, "Total"));
            DC_v.Add(AddDV_v(Profit, dt, "Profit"));
            SetDataForDateCustom(dt);
        }

        private void CalendarStatistic_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalendarStatistic.MaxSelectionCount = 1;
            DateCustom = CalendarStatistic.SelectionStart;
            NumberOfOrdered = BLL.ThongKeBLL.Instance.GetNumberOfOrdered(DateCustom);
            Profit = BLL.ThongKeBLL.Instance.GetProfit(DateCustom);
            Total = BLL.ThongKeBLL.Instance.GetTotal(DateCustom);
            Consuming = Total - Profit;
            DC_v.Clear();
            DC_v.Add(AddDV_v(Consuming, DateCustom, "Consuming"));
            DC_v.Add(AddDV_v(Total, DateCustom, "Total"));
            DC_v.Add(AddDV_v(Profit, DateCustom, "Profit"));
            lblOrdered.Text = BLL.ThongKeBLL.Instance.GetNumberOfOrdered(CalendarStatistic.SelectionStart).ToString();
            lblProfit.Text = DoanhThuNgay.Profit.ToString();
            lblTotal.Text = DoanhThuNgay.Total.ToString();
            lblConsuming.Text = DoanhThuNgay.Consuming.ToString();
            SetDataForDateCustom(CalendarStatistic.SelectionStart);
        }
        private void btnDetailInvoice_Click(object sender, EventArgs e)
        {
            DetailInvoice frm = new DetailInvoice(DayStart, DayEnd);
            frm.Show();
        }

        private void dtpDayStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDayStart.Value < dtpDayEnd.Value)
            {
                DayStart = dtpDayStart.Value;
                SetDataForMainChart(DayStart, DayEnd);
            }
            else if (dtpDayStart.Value > dtpDayEnd.Value)
            {
                NoticeBox frm = new NoticeBox("You start day is invalid!");
                frm.Show();
            }
        }

        private void dtpDayEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDayStart.Value < dtpDayEnd.Value)
            {
                DayEnd = dtpDayEnd.Value;
                SetDataForMainChart(DayStart, DayEnd);
            }
            else if (dtpDayStart.Value > dtpDayEnd.Value)
            {
                NoticeBox frm = new NoticeBox("You end day is invalid!");
                frm.Show();
            }

        }
    }
}
