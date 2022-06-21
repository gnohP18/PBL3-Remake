﻿using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.frmGUIUserControl
{
    public partial class EmployeeTimeSheet : Form
    {
        public EmployeeTimeSheet(int User_ID)
        {
            _User = BLL.NhanVienBLL.Instance.GetEmployeeByID_Employee(User_ID);
            User_Position = new ChucVu();

            if (BLL.NhanVienBLL.Instance.GetEmployeeTimeSheetByID_User(User_ID) != null)
            {
                TimeSheet = BLL.NhanVienBLL.Instance.GetEmployeeTimeSheetByID_User(User_ID).LichSuLamViec;
            };
            InitializeComponent();
            SetupDataForChart(DateTime.Now);
            SetupSalary();
            SetupTimeSheet();
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
            //NumberDateOfMonth = NumberOfDay(date);
            NumberDateOfMonth = BLL.NhanVienBLL.Instance.GetTimeSheetsByID_User(_User.ID_User).LichSuLamViec.Length;
            NumberOfDateAttendance = 0;
            NumberOfDateAbsent = 0;
            NumberOfDateLate = 0;
            char[] charTimeSheet = TimeSheet.ToCharArray();
            foreach (char c in charTimeSheet)
            {
                if (c == '0') NumberOfDateAbsent++;
                if (c == '1') NumberOfDateAttendance++;
            }
            NumberOfDateLate = NumberDateOfMonth - NumberOfDateAbsent - NumberOfDateAttendance;
            NumberOfDateAttendance += NumberOfDateLate;
            Console.WriteLine("Absent " + NumberOfDateAbsent);
            Console.WriteLine("Attendance " + NumberOfDateAttendance);
            Console.WriteLine("Late " + NumberOfDateLate);
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
            lblID_User.Text = _User.ID_User.ToString();
            lblName_User.Text = _User.TenUser;
            lblAbsent.Text = NumberOfDateAbsent.ToString();
            lblAttendance.Text = NumberOfDateAttendance.ToString();
            lblLate.Text = NumberOfDateLate.ToString();
            lblPosition.Text = User_Position.TenChucVu;
            lblCoefficientsSalary.Text = User_Position.HeSoLuong.ToString();
        }
        private void SetupTimeSheet()
        {
            TimeSheetUC tsUC = new TimeSheetUC(BLL.NhanVienBLL.Instance.GetTimeSheetsByID_User(_User.ID_User).LichSuLamViec);
            this.Controls.Add(tsUC);
            tsUC.Location = new System.Drawing.Point(400, 0);
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
