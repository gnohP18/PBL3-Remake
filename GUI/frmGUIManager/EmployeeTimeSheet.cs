using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI.frmGUIUCForManager;
using Entity;
namespace GUI.frmGUIManager
{
    public partial class EmployeeTimeSheet : Form
    {
        public EmployeeTimeSheet(int User_ID)
        {
            _User = BLL.NhanVienBLL.Instance.GetNhanVienByID(User_ID);
            date = BLL.BangChamCongBLL.Instance.GetNgayChamCongHienTai();
            LoadTimeSheet();
            InitializeComponent();
            SetupDataForChart(date);
            SetupSalary();
            SetupTimeSheetUC();
        }

        #region Local Variable
        private DateTime date { get; set; }
        private User _User { get; set; }
        private ChucVu User_Position { get; set; }
        private int NumberOfDateAttendance { get; set; }
        private int NumberDateOfMonth { get; set; }
        private int NumberOfDateLate { get; set; }
        private int NumberOfDateAbsent { get; set; }
        private string TimeSheet { get; set; }
        private List<DayChart_view> Dc_v { get; set; }
        TimeSheetUC tsUC;
        #endregion
        #region Funtion
        void LoadTimeSheet()
        {
            if (BLL.BangChamCongBLL.Instance.GetEmployeeTimeSheetByID_User(_User.ID_User, date) != null)
            {
                TimeSheet = BLL.BangChamCongBLL.Instance.GetEmployeeTimeSheetByID_User(_User.ID_User, date).LichSuLamViec;
            }
            else TimeSheet = null;
        }

        private int NumberOfDay(DateTime dt)
        {
            DateTime newmonth = new DateTime(dt.Year, dt.Month, 5);
            newmonth = newmonth.AddMonths(1);
            int num = 0;
            while (dt <= newmonth)
            {
                num++;
                dt = dt.AddDays(1);
            }
            return num;
        }
        private void SetupDataForChart(DateTime date)
        {
            DayChart.Series[0].Points.Clear();
            NumberDateOfMonth = NumberOfDay(date);
            char[] charTimeSheet = TimeSheet.ToCharArray();
            NumberOfDateAttendance = 0;
            NumberOfDateAbsent = 0;
            NumberOfDateLate = 0;
            foreach (char c in charTimeSheet)
            {
                if (c == '2') NumberOfDateAbsent++;
                if (c == '1') NumberOfDateAttendance++;
                if ('A' <= c && c <= 'Z') NumberOfDateLate++;
            }
            NumberOfDateAttendance += NumberOfDateLate;
            Dc_v = new List<DayChart_view>();
            Dc_v.Add(new DayChart_view { Date = date, Value = NumberOfDateAttendance, Text = "Attendance" });
            Dc_v.Add(new DayChart_view { Date = date, Value = NumberOfDateLate, Text = "Late" });
            Dc_v.Add(new DayChart_view { Date = date, Value = NumberOfDateAbsent, Text = "Absent" });
            DayChart.DataSource = Dc_v;
            DayChart.Series[0].YValueMembers = "Value";
            DayChart.Series[0].XValueMember = "Text";
        }
        private void SetupSalary()
        {
            User_Position = BLL.NhanVienBLL.Instance.GetPositionByID_Position(_User.ID_ChucVu);
            lblAbsent.Text = NumberOfDateAbsent.ToString();
            lblAttendance.Text = NumberOfDateAttendance.ToString();
            lblLate.Text = NumberOfDateLate.ToString();
            lblPosition.Text = User_Position.TenChucVu;
            lblCoefficientsSalary.Text = User_Position.HeSoLuong.ToString();
            lblID_User.Text = _User.ID_User.ToString();
            lblName_User.Text = _User.TenUser;
            lblTotalSalary.Text = BLL.NhanVienBLL.Instance.GetSalaryByID_User_ByDate(_User.ID_User, date).ToString();

        }

        private void SetupTimeSheetUC()
        {
            if (tsUC != null) this.Controls.Remove(tsUC);
            TimeSheet = BLL.BangChamCongBLL.Instance.GetEmployeeTimeSheetByID_User(_User.ID_User, date).LichSuLamViec;
            tsUC = new TimeSheetUC(TimeSheet, date);
            tsUC.Location = new System.Drawing.Point(400, 0);
            this.Controls.Add(tsUC);
            tsUC.dNext = new TimeSheetUC.Mydel(btnNext_Click);
            tsUC.dPre = new TimeSheetUC.Mydel(btnPre_Click);
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            BLL.NhanVienBLL.Instance.GetNumberTimeLate('a');
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (date == BLL.BangChamCongBLL.Instance.GetNgayChamCongHienTai()) return;
            date = new DateTime(date.Year, date.Month + 1, date.Day);
            LoadTimeSheet();
            if (TimeSheet == null)
            {
                date = new DateTime(date.Year, date.Month - 1, date.Day);
                return;
            }
            SetupDataForChart(date);
            SetupSalary();
            SetupTimeSheetUC();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            date = new DateTime(date.Year, date.Month - 1, date.Day);
            LoadTimeSheet();
            if (TimeSheet == null)
            {
                date = new DateTime(date.Year, date.Month + 1, date.Day);
                return;
            }
            SetupDataForChart(date);
            SetupSalary();
            SetupTimeSheetUC();

        }
    }
}
