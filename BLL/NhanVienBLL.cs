using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BLL
{
    public class NhanVienBLL : BLL
    {
        private static NhanVienBLL _Instance;
        public static NhanVienBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new NhanVienBLL();
                return _Instance;
            }
            private set { }
        }
        private NhanVienBLL()
        {

        }
        public int GetNumberTimeLate(char c)
        {

            Dictionary<char, int> Temp = new Dictionary<char, int>();
            for (int i = 0; i < 25; i++)
            {
                Temp.Add((char)(65 + i), 15 * (i + 1));
                //Console.WriteLine(Temp.Values + "\t" + Temp.Values);
            }
            //foreach (char i in Temp.Keys)
            //{
            //    Console.WriteLine(i);
            //}
            int NumberTimeLate = 0;
            foreach (KeyValuePair<char, int> T in Temp)
            {
                if (T.Key == c)
                {
                    NumberTimeLate = T.Value;
                }
            }
            return NumberTimeLate;
        }
        public int GetSalaryByID_User_ByDate(int ID_User, DateTime month)
        {
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            BangChamCong bcc = dALQLNH.BangChamCongs.Where(c => c.ID_User == ID_User && c.NgayDauTienTinhCong.Month == month.Month).FirstOrDefault();
            int NumberTimeLate = 0;
            int DayWork = GetNumberOfDayWork(bcc.LichSuLamViec);
            char[] charbcc = bcc.LichSuLamViec.ToCharArray();
            foreach (char i in charbcc)
            {
                if ('A' <= i && i <= 'Z')
                {
                    NumberTimeLate += GetNumberTimeLate(i);
                    Console.WriteLine(NumberTimeLate);
                }

            }
            User _Us = GetNhanVienByID(ID_User);
            ChucVu cv = GetPositionByID_Position(_Us.ID_ChucVu);
            Console.WriteLine("Total timelate " + NumberTimeLate);
            int Salary = DayWork * cv.HeSoLuong - NumberTimeLate / 15 * TTNH.TienPhatTre15p;
            return Salary;
        }

        public List<Employee_view> GetAllEmployee_view()
        {
            List<Employee_view> list = new List<Employee_view>();
            foreach (User i in dALQLNH.Users)
            {
                if (i.DaXoa == false)
                {
                    Employee_view employee = new Employee_view();
                    employee.ID_User = i.ID_User;
                    employee.User_Name = i.TenUser;
                    employee.User_Position = i.ChucVu.TenChucVu;
                    employee.Phone_number = i.SDT;
                    employee.DateStartWork = i.NgayBatDauLam;
                    employee.DateOfBirth = i.NgaySinh;
                    employee.UserNameLogin = i.Username;
                    employee.PasswordLogin = i.Password;
                    employee.NumberOfDayWork = GetNumberOfDayWorkByID_User(i.ID_User);
                    if (CaLamBLL.Instance.GetThongTinDiemDanhNhanVienNow().ContainsKey(i)) employee.Status = "Working";
                    else employee.Status = "Off";
                    list.Add(employee);
                }
            }
            return list;
        }
        public User GetNhanVienByUserName(string Username)
        {
            return dALQLNH.Users.Where(s => s.Username == Username).FirstOrDefault();
        }
        public List<ChucVu> GetAllPosition()
        {
            return dALQLNH.ChucVus.ToList();
        }
        public bool checkUsername(string Username)
        {
            if (dALQLNH.Users.Where(s => s.Username == Username) != null) return false;
            else return true;
        }
        public void Execute(User user)
        {
            User userDB = dALQLNH.Users.Find(user.ID_User);
            if(userDB != null)
            {
                userDB.TenUser = user.TenUser;
                userDB.Username = user.Username;
                userDB.AnhUser = user.AnhUser;
                userDB.ID_ChucVu = user.ID_ChucVu;
                userDB.CMND_CCCD = user.CMND_CCCD;
                userDB.SDT = user.SDT;
                userDB.DiaChi = user.DiaChi;
                userDB.Password = user.Password;
                userDB.NgayBatDauLam = user.NgayBatDauLam;
                userDB.NgaySinh = user.NgaySinh;
                dALQLNH.SaveChanges();
            }
            else
            {
                user.ID_User = GetNewIDUser();
                dALQLNH.Users.Add(user);
                dALQLNH.Entry(user).Reference(s => s.ChucVu).Load();
                dALQLNH.SaveChanges();
                if(user.ID_ChucVu != 1 && user.ID_ChucVu != 2)
                {
                    BangChamCongBLL.Instance.SetUpBangChamCongNowForNhanVien(user.ID_User);
                }
            }
        }
        public int GetNewIDUser()
        {
            int id = 1;
            foreach (User i in dALQLNH.Users)
            {
                if (id != i.ID_User)
                {
                    return id;
                }
                id++;
            }
            return id;
        }
        public List<User> GetAllUser()
        {
            return dALQLNH.Users.ToList();
        }
        
        public int checkLogin(string username, string password, bool isCustomerLogin)
        {
            User user = (User)(dALQLNH.Users.Where(p => p.Username == username && p.Password == password).FirstOrDefault());
            if (user == null) return -1;
            if (user.ID_ChucVu == 1) return 1;
            if (isCustomerLogin == true && user.ID_ChucVu != 2 && CaLamBLL.Instance.GetBuoiLamNow() != -1)
            {
                int SangChieu = CaLamBLL.Instance.GetBuoiLamNow();
                foreach (ChiTietCaLam i in user.ChiTietCaLams)
                {
                    if (i.CaLam.LichCaLam[DateTime.Now.DayOfWeek.GetHashCode() * 2 + SangChieu] == '1') return 1;
                }
                return 0;
            }
            if (isCustomerLogin == false && user.ID_ChucVu == 2)
            {
                return 1;
            }
            return 0;
        }
        public void DeleteEmployee(int ID_User)
        {
            GetNhanVienByID(ID_User).DaXoa = true;
            dALQLNH.SaveChanges();
        }
        
        public ChucVu GetPositionByID_Position(int ID_Position)
        {
            return dALQLNH.ChucVus.Where(p => p.ID_ChucVu == ID_Position).FirstOrDefault();
        }
        public int GetNumberOfDayWork(string TimeSheet)
        {
            char[] TimeSheetChar = TimeSheet.ToCharArray();
            int DayAbsent = 0;
            foreach (char c in TimeSheetChar)
            {
                if (c == '0' || c == '2') DayAbsent++;
            }
            return TimeSheetChar.Length - DayAbsent;
        }
        public int GetNumberDayWorkFormDayStartWorkByID_User(int ID_User)
        {
            int DayWork = 0;
            foreach (BangChamCong i in dALQLNH.BangChamCongs)
            {
                if (i.ID_User == ID_User)
                {
                    DayWork += GetNumberOfDayWork(i.LichSuLamViec);
                }
            }
            return DayWork;
        }
        public User GetNhanVienByID(int ID_Employee)
        {
            return dALQLNH.Users.Where(p => p.ID_User == ID_Employee).FirstOrDefault();
        }
        public BangChamCong GetNewestTimeSheetsByID_User(int ID_User)
        {
            List<BangChamCong> NewestTimeSheets = new List<BangChamCong>();
            foreach (BangChamCong i in dALQLNH.BangChamCongs)
            {
                if (i.ID_User == ID_User)
                {
                    NewestTimeSheets.Add(i);
                }
            }
            //return dALQLNH.BangChamCongs.Where(p => p.ID_User == ID_User).FirstOrDefault();
            if (NewestTimeSheets.Count > 0)
                return NewestTimeSheets[NewestTimeSheets.Count - 1];
            else return null;
        }
        public int GetNumberOfDayWorkByID_User(int ID_User)
        {
            int NumberOfDayWork = 0;
            if (GetNewestTimeSheetsByID_User(ID_User) != null)
                foreach (char i in GetNewestTimeSheetsByID_User(ID_User).LichSuLamViec.ToCharArray())
                {
                    if (i == '1' || 'A' <= i && i <= 'Z')
                    {
                        NumberOfDayWork++;
                    }
                }
            return NumberOfDayWork;
        }
        public int GetNumberOfTotalDayWorkByID_User(int ID_User)
        {
            int DayNoHaveWork = 0;
            string strTimeSheet = "";

            foreach (BangChamCong i in dALQLNH.BangChamCongs)
            {
                if (i.ID_User == ID_User)
                {
                    strTimeSheet += i.LichSuLamViec;
                }
            }
            char[] charTimeSheet = strTimeSheet.ToCharArray();
            foreach (char c in charTimeSheet)
            {
                if (c == '0') DayNoHaveWork++;
            }
            int TotalDayWork = charTimeSheet.Length - DayNoHaveWork;
            return TotalDayWork;
        }

        public List<SalaryEmployee_view> GetAllSalaryEmployee_view()
        {
            List<SalaryEmployee_view> list = new List<SalaryEmployee_view>();
            foreach (User i in dALQLNH.Users)
            {
                SalaryEmployee_view slrEmployee = new SalaryEmployee_view();
                slrEmployee.ID_User = i.ID_User;
                slrEmployee.Name_User = i.TenUser;
                slrEmployee.CoefficientsSalary = i.ChucVu.HeSoLuong;
                slrEmployee.TotalDayWork = GetNumberDayWorkFormDayStartWorkByID_User(i.ID_User);
                slrEmployee.Name_Position = GetPositionByID_Position(i.ID_ChucVu).TenChucVu;
                int DayWork = GetNumberDayWorkFormDayStartWorkByID_User(i.ID_User);
                int DayTotal = GetNumberOfTotalDayWorkByID_User(i.ID_User);
                if (DayWork != 0 && DayTotal != 0)
                {
                    slrEmployee.PerCentDayWorkAndDayAbsent = (float)(DayWork) / (float)(DayTotal) * 100;
                }
                else
                {
                    slrEmployee.PerCentDayWorkAndDayAbsent = 0;
                }

                list.Add(slrEmployee);
            }
            return list;
        }
        public SalaryEmployee_view GetSalaryEmployee_viewByID_User(int ID_User)
        {
            SalaryEmployee_view salaryEmployee = new SalaryEmployee_view();
            foreach (SalaryEmployee_view i in GetAllSalaryEmployee_view())
            {
                if (i.ID_User == ID_User)
                    salaryEmployee = i;
            }
            return salaryEmployee;
        }
        #region Salary Employee
        public int NumberDayofMonth(DateTime dt)
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
        //public Dictionary<DateTime, char> ReturnDayWorkFormTimeSheet(DateTime month, string TimeSheet)
        //{
        //    ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
        //    int PaySalaryDay = TTNH.NgayPhatLuong;
        //    DateTime StartDay = new DateTime(month.Year, month.Month, TTNH.NgayPhatLuong);
        //    Dictionary<DateTime, char> dayWorkAndState = new Dictionary<DateTime, char>();
        //    char[] charTimeSheet = TimeSheet.ToCharArray();
        //    int oldindex = 1;
        //    int newindex = 1;
        //    for (int i = 0; i < charTimeSheet.Length; i += 2)
        //    {
        //        if (charTimeSheet[i] == '1' || 'A' <= charTimeSheet[i] && charTimeSheet[i] <= 'Z')
        //        {
        //            if (i % 2 == 0) newindex = i / 2;
        //            else if (i % 2 == 1) newindex = (i - 1) / 2;
        //            dayWorkAndState.Add(StartDay.AddDays(newindex - oldindex), '1');
        //            oldindex = newindex;
        //        }
        //    }
        //    return dayWorkAndState;
        //}
        //public BangChamCong GetTimeSheetByID_UserAndID_TimeSheet(int ID_User, DateTime month)
        //{
        //    return dALQLNH.BangChamCongs.Where(p => p.ID_User == ID_User && p.NgayDauTienTinhCong.Month == month.Month).FirstOrDefault();
        //}
        //public Dictionary<DateTime,string> GetAllDayWorkAndStateByID_UserAndTimeSheet(int ID_User,DateTime month)
        //{
        //    Dictionary<DateTime,string> dayWorkAndState = new Dictionary<DateTime,string>();
        //    BangChamCong bcc= GetTimeSheetByID_UserAndID_TimeSheet(ID_User,month);
        //    char[] CharTimeSheet = bcc.LichSuLamViec.ToCharArray();
        //    for (int i = 0; i < CharTimeSheet.Length; i++)
        //    {

        //    }
        //}
        #endregion

    }
}
