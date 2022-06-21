using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class EmployeeTimeSheet : Form
    {
        public EmployeeTimeSheet(int User_ID)
        {
            _User = BLL.NhanVienBLL.Instance.GetNhanVienByID(User_ID);
            User_Position = BLL.NhanVienBLL.Instance.GetPositionByID_Position(User_ID);
            if (BLL.NhanVienBLL.Instance.GetEmployeeTimeSheetByID_User(User_ID) != null)
            {
                TimeSheet = BLL.NhanVienBLL.Instance.GetEmployeeTimeSheetByID_User(User_ID).LichSuLamViec;
            };
            InitializeComponent();
            SetupDataForChart(DateTime.Now);
        }
        #region Local Variable
        private User _User { get; set; }
        private ChucVu User_Position { get; set; }
        private int NumberOfDateAttendance { get; set; }
        private int NumberDateOfMonth { get; set; }
        private int NumberOfDateLate { get; set; }
        private int NumberOfDateAbsent { get; set; }
        private string Text { get; set; }
        private string TimeSheet { get; set; }
        private List<DayChart_view> Dc_v { get; set; }
        #endregion
        #region Funtion
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }
        private void SetupDataForChart(DateTime date)
        {
            NumberDateOfMonth = DayOfMonth(date);
            char[] charTimeSheet = TimeSheet.ToCharArray();
            NumberOfDateAttendance = 0;
            NumberOfDateAbsent = 0;
            NumberOfDateLate = 0;
            foreach (char c in charTimeSheet)
            {
                if (c == '0') NumberOfDateAbsent++;
                if (c == '1') NumberOfDateAttendance++;
            }
            NumberOfDateLate = NumberDateOfMonth * 2 - NumberOfDateAbsent - NumberOfDateAttendance;
            NumberOfDateAttendance += NumberOfDateLate;
            Console.WriteLine("Absent " + NumberOfDateAbsent);
            Console.WriteLine("Attendance " + NumberOfDateAttendance);
            Console.WriteLine("Late " + NumberOfDateLate);
            Dc_v = new List<DayChart_view>();
            Dc_v.Add(new DayChart_view { Date = date, Value = NumberOfDateAbsent, Text = "Absent" });
            Dc_v.Add(new DayChart_view { Date = date, Value = NumberOfDateLate, Text = "Late" });
            Dc_v.Add(new DayChart_view { Date = date, Value = NumberOfDateAttendance, Text = "Attendance" });
            DayChart.DataSource = Dc_v;
            DayChart.Series[0].YValueMembers = "Value";
            DayChart.Series[0].XValueMember = "Text";
        }
        private void SetupSalary()
        {
            lblAbsent.Text = NumberOfDateAbsent.ToString();
            lblAttendance.Text = NumberOfDateAttendance.ToString();
            lblLate.Text = NumberOfDateLate.ToString();
            lblPosition.Text = User_Position.TenChucVu;
            lblCoefficientsSalary.Text = User_Position.HeSoLuong.ToString();


        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
