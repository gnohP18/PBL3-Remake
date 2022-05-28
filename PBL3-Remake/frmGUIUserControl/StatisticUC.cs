using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class StatisticUC : UserControl
    {
        List<Statistic_view> ListDoanhThu = new List<Statistic_view>();
        private Statistic_view DoanhThuNgay = new Statistic_view();
        public DateTime DateCustom { get; set; }
        private int NumberOfOrdered { get; set; }
        private int Total { get; set; }
        private int Profit { get; set; }
        public StatisticUC()
        {
            InitializeComponent();
        }
        private void SetDataForDateCustom(DateTime date)
        {
            foreach (Statistic_view i in ListDoanhThu)
            {
                if (i.Date == date)
                {
                    DoanhThuNgay = i;
                    Console.WriteLine("Total " + i.Total + " Profit " + i.Profit);
                }
            }
        }
        private void StatisticUC_Load(object sender, EventArgs e)
        {

        }
        private void CalendarStatistic_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalendarStatistic.MaxSelectionCount = 1;
            DateCustom = CalendarStatistic.SelectionStart;
            SetDataForDateCustom(DateCustom);
            lblOrdered.Text = BLL.BLLNVNH.Instance.GetNumberOfOrdered(CalendarStatistic.SelectionStart).ToString();
            lblProfit.Text = DoanhThuNgay.Profit.ToString();
            lblTotal.Text = DoanhThuNgay.Total.ToString();
            DayChart.DataSource = DoanhThuNgay;

        }

    }
}
