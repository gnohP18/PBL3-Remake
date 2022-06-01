using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.frmGUIUserControl
{
    public partial class StatisticUC : UserControl
    {
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
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {

            var btn = (Button)button;
            //highlight button
            btn.BackColor = Color.FromArgb(66, 134, 244);
            btn.ForeColor = Color.White;
            //btn.RightToLeft = RightToLeft.Yes;
            //Unhighlight button
            if (CurrentButton != null && CurrentButton != btn)
            {
                //btn.RightToLeft = RightToLeft.No;
                CurrentButton.BackColor = Color.FromArgb(17, 21, 37);
                CurrentButton.ForeColor = Color.White;
            }
            CurrentButton = btn;
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
            MainChart.Series[0].Points.Clear();
            List<Statistic_view> listbydate = new List<Statistic_view>();
            foreach (Statistic_view i in ListDoanhThu)
            {
                if (i.Date > daystart && i.Date < dayend)
                {
                    listbydate.Add(i);
                }
            }
            MainChart.ChartAreas[0].AxisY.Maximum = 3000000;
            MainChart.ChartAreas[0].AxisY.Minimum = -3000000;
            MainChart.DataSource = listbydate;
            MainChart.Series["Total"].YValueMembers = "Total";
            MainChart.Series["Total"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            MainChart.Series["Total"].XValueMember = "Date";
            MainChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Weeks;
            MainChart.Series["Total"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            MainChart.Series["Profit"].YValueMembers = "Profit";
            MainChart.Series["Profit"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            MainChart.Series["Profit"].XValueMember = "Date";
            MainChart.Series["Profit"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            MainChart.Series["Consuming"].YValueMembers = "Consuming";
            MainChart.Series["Consuming"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            MainChart.Series["Consuming"].XValueMember = "Date";
            MainChart.Series["Consuming"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
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
                    Console.WriteLine("Total " + i.Total + " Profit " + i.Profit);
                }
            }
            Console.WriteLine(NumberOfOrdered + " " + Profit + " " + Total);
            DayChart.DataSource = DC_v;
            DayChart.Series[0].YValueMembers = "Value";
            DayChart.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            DayChart.Series[0].XValueMember = "Text";
            DayChart.DataBind();
        }
        private void StatisticUC_Load(object sender, EventArgs e)
        {
            ListDoanhThu = BLL.BLLNVNH.Instance.GetAllDoanhThu();
            DateTime dt = DateTime.Now;
            NumberOfOrdered = BLL.BLLNVNH.Instance.GetNumberOfOrdered(dt);
            Profit = BLL.BLLNVNH.Instance.GetProfit(dt);
            Total = BLL.BLLNVNH.Instance.GetTotal(dt);
            Consuming = Total - Profit;
            DC_v.Clear();
            DC_v.Add(AddDV_v(Consuming, dt, "Consuming"));
            DC_v.Add(AddDV_v(Total, dt, "Total"));
            DC_v.Add(AddDV_v(Profit, dt, "Profit"));
            SetDataForDateCustom(dt);
            lblOrdered.Text = BLL.BLLNVNH.Instance.GetNumberOfOrdered(CalendarStatistic.SelectionStart).ToString();
            lblProfit.Text = DoanhThuNgay.Profit.ToString();
            lblTotal.Text = DoanhThuNgay.Total.ToString();
            lblConsuming.Text = DoanhThuNgay.Consuming.ToString();
            SetDataForDateCustom(dt);
            SetDataForMainChart(dt, dt.AddDays(-30));
        }

        private void CalendarStatistic_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalendarStatistic.MaxSelectionCount = 1;
            DateCustom = CalendarStatistic.SelectionStart;
            NumberOfOrdered = BLL.BLLNVNH.Instance.GetNumberOfOrdered(DateCustom);
            Profit = BLL.BLLNVNH.Instance.GetProfit(DateCustom);
            Total = BLL.BLLNVNH.Instance.GetTotal(DateCustom);
            Consuming = Total - Profit;
            DC_v.Clear();
            DC_v.Add(AddDV_v(Consuming, DateCustom, "Consuming"));
            DC_v.Add(AddDV_v(Total, DateCustom, "Total"));
            DC_v.Add(AddDV_v(Profit, DateCustom, "Profit"));
            lblOrdered.Text = BLL.BLLNVNH.Instance.GetNumberOfOrdered(CalendarStatistic.SelectionStart).ToString();
            lblProfit.Text = DoanhThuNgay.Profit.ToString();
            lblTotal.Text = DoanhThuNgay.Total.ToString();
            lblConsuming.Text = DoanhThuNgay.Consuming.ToString();
            SetDataForDateCustom(CalendarStatistic.SelectionStart);
        }
        private void btnDetailInvoice_Click(object sender, EventArgs e)
        {

        }

        private void dtpDayStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDayStart.Value < dtpDayEnd.Value)
            {
                DayStart = dtpDayStart.Value;
                SetDataForMainChart(DayStart, DayEnd);
            }
            else
            {
                NoticeBox frm = new NoticeBox("You start day is invalid!");
            }
        }

        private void dtpDayEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDayStart.Value < dtpDayEnd.Value)
            {
                DayEnd = dtpDayEnd.Value;
                SetDataForMainChart(DayStart, DayEnd);
            }
            else
            {
                NoticeBox frm = new NoticeBox("You end day is invalid!");
            }

        }
    }
}
