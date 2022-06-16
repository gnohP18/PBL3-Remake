using Entity;
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

        private void OverViewUC_Load(object sender, EventArgs e)
        {
            OverViewCalendar.MaxSelectionCount = 1;
            CurrentDay = OverViewCalendar.SelectionStart.Date;
            RealTime.Start();
            SetupDataGridView();
            SetDataForDateCustom();
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
    }
}
