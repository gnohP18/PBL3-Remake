using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class StatisticUC : UserControl
    {
        List<Statistic_view> ListDoanhThu = new List<Statistic_view>();
        List<Statistic_view> DoanhThuTheoNgay = new List<Statistic_view>();
        private Statistic_view DoanhThuNgay = new Statistic_view();
        private List<DayChart_view> DC_v = new List<DayChart_view>();
        public DateTime DateCustom { get; set; }
        private int NumberOfOrdered { get; set; }
        private int Total { get; set; }
        private int Profit { get; set; }
        private int Consuming { get; set; }
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
        private void SetDataForMainChart(DateTime dt)
        {
            MainChart.Series[0].Points.Clear();
            List<Statistic_view> listbydate = new List<Statistic_view>();
            DateTime dtBefore = dt.AddDays(-30);
            foreach (Statistic_view i in ListDoanhThu)
            {
                if (i.Date > dtBefore && i.Date < dt)
                {
                    listbydate.Add(i);
                }
            }
            MainChart.DataSource = listbydate;
            MainChart.Series["Total"].YValueMembers = "Total";
            MainChart.Series["Total"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            MainChart.Series["Total"].XValueMember = "Date";
            MainChart.Series["Profit"].YValueMembers = "Profit";
            MainChart.Series["Profit"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            MainChart.Series["Profit"].XValueMember = "Date";
            MainChart.Series["Consuming"].YValueMembers = "Consuming";
            MainChart.Series["Consuming"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            MainChart.Series["Consuming"].XValueMember = "Date";
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
                    //Console.WriteLine("Total " + i.Total + " Profit " + i.Profit);
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
            Console.WriteLine("Tong so ngay " + BLL.BLLNVNH.Instance.GetAllDoanhThu().Count);
            foreach (Statistic_view i in ListDoanhThu)
            {
                //Console.WriteLine("ID " + i.ID_money + " Consuming " + i.Consuming + " Total " + i.Total + " Profit " + i.Profit + " ngay " + i.Date.ToShortDateString());
            }

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
            //DC_v.Add(AddDV_v(NumberOfOrdered, DateCustom));
            DC_v.Add(AddDV_v(Consuming, DateCustom, "Consuming"));
            DC_v.Add(AddDV_v(Total, DateCustom, "Total"));
            DC_v.Add(AddDV_v(Profit, DateCustom, "Profit"));
            SetDataForDateCustom(DateCustom);
            lblOrdered.Text = BLL.BLLNVNH.Instance.GetNumberOfOrdered(CalendarStatistic.SelectionStart).ToString();
            lblProfit.Text = DoanhThuNgay.Profit.ToString();
            lblTotal.Text = DoanhThuNgay.Total.ToString();
            SetDataForDateCustom(CalendarStatistic.SelectionStart);
            SetDataForMainChart(DateCustom);
        }

    }
}
