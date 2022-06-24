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

        public User GetNhanVienByID(int ID_Employee)
        {
            return dALQLNH.Users.Where(p => p.ID_User == ID_Employee).FirstOrDefault();
        }
        public BangChamCong GetTimeSheetsByID_User(int ID_User)
        {
            return dALQLNH.BangChamCongs.Where(p => p.ID_User == ID_User).FirstOrDefault();
        }
        public int GetNumberOfDayWorkByID_User(int ID_User)
        {
            int NumberOdDayWork = 0;
            if (GetTimeSheetsByID_User(ID_User) != null)
                foreach (char i in GetTimeSheetsByID_User(ID_User).LichSuLamViec.ToCharArray())
                {
                    if (i == '1' || 'A' <= i && i <= 'Z')
                    {
                        NumberOdDayWork++;
                    }
                }
            return NumberOdDayWork;
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
                    foreach (User us in GetAllNhanVienCoLichLamViecByTime())
                    {
                        if (us.ID_User == i.ID_User)
                        {
                            employee.Status = "Working";
                        }
                        else
                        {
                            employee.Status = "Offline";
                        }
                        if (us.DaXoa == true)
                        {
                            employee.Status = "Remove";
                        }
                    }
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
        public void AddNewEmployee(User _us)
        {
            int NewID_User = dALQLNH.Users.Count() + 1;
            _us.ID_User = NewID_User;
            dALQLNH.Users.Add(_us);
            dALQLNH.SaveChanges();
            DateTime dt = DateTime.Now;
            int NewID_TimeSheets = dALQLNH.BangChamCongs.Count() + 1;
            string TimeSheet = "";
            for (int i = 0; i < dt.Day; i++)
            {
                TimeSheet += "0";
            }
            BangChamCong newbcc = new BangChamCong();
            newbcc.ID_User = NewID_User;
            newbcc.ID_BangChamCong = NewID_TimeSheets;
            newbcc.LichSuLamViec = TimeSheet;
            newbcc.NgayDauTienTinhCong = DateTime.Now.AddDays(1);
            dALQLNH.BangChamCongs.Add(newbcc);
            dALQLNH.SaveChanges();
        }
        public List<User> GetAllUser()
        {
            return dALQLNH.Users.ToList();
        }
        public List<User> GetAllNhanVienCoLichLamViecByTime()
        {
            List<User> data = new List<User>();
            int SangChieu = GetBuoiLamNow();
            foreach (ChiTietCaLam i in dALQLNH.ChiTietCaLams)
            {
                if (i.CaLam.LichCaLam[DateTime.Now.DayOfWeek.GetHashCode() * 2 + SangChieu] == '1')
                {
                    data.Add(i.User);
                }
            }
            return data;
        }
        public Dictionary<User, bool> GetThongTinDiemDanhNhanVienNow()
        {
            Dictionary<User, bool> data = new Dictionary<User, bool>();
            int SangChieu = GetBuoiLamNow();
            foreach (ChiTietCaLam i in dALQLNH.ChiTietCaLams)
            {
                if (i.CaLam.LichCaLam[DateTime.Now.DayOfWeek.GetHashCode() * 2 + SangChieu] == '1')
                {
                    ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
                    DateTime dtNow = DateTime.Now;
                    int indexDay = (dtNow - TTNH.NgayBatDauChamCongHienTai).Days;
                    BangChamCong bangChamCong = dALQLNH.BangChamCongs.Where(s => s.ID_User == i.User.ID_User && s.NgayDauTienTinhCong == TTNH.NgayBatDauChamCongHienTai).FirstOrDefault();
                    if (bangChamCong.LichSuLamViec[indexDay * 2 + SangChieu] != '0')
                        data.Add(i.User, true);
                    else data.Add(i.User, false);
                }
            }
            return data;
        }
        public int checkLogin(string username, string password, bool isCustomerLogin)
        {
            User user = (User)(dALQLNH.Users.Where(p => p.Username == username && p.Password == password).FirstOrDefault());
            if (user == null) return -1;
            if (user.ID_ChucVu == 1) return 1;
            if (isCustomerLogin == true && user.ID_ChucVu != 2 && GetBuoiLamNow() != -1)
            {
                int SangChieu = GetBuoiLamNow();
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
        public int GetBuoiLamNow()
        {
            DateTime dtNow = DateTime.Now;
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            if (dtNow.TimeOfDay >= TTNH.ThoiGianBatDauLamViecSang && dtNow.TimeOfDay <= TTNH.ThoiGianKetThucLamViecSang)
            {
                return 0;
            }
            if (dtNow.TimeOfDay >= TTNH.ThoiGianBatDauLamViecChieu && dtNow.TimeOfDay <= TTNH.ThoiGianKetThucLamViecChieu)
            {
                return 1;
            }
            return -1;
        }
        public void ChamCong(int ID_User)
        {
            User user = dALQLNH.Users.Find(ID_User);
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            DateTime dtNow = DateTime.Now;
            int indexDay = (dtNow - TTNH.NgayBatDauChamCongHienTai).Days;
            int SangChieu = GetBuoiLamNow();
            BangChamCong bangChamCong = dALQLNH.BangChamCongs.Where(s => s.ID_User == ID_User && s.NgayDauTienTinhCong == TTNH.NgayBatDauChamCongHienTai).FirstOrDefault();
            TimeSpan TimeLate;
            if (SangChieu == 0)
            {
                TimeLate = dtNow.TimeOfDay - TTNH.ThoiGianBatDauLamViecSang;
            }
            else
            {
                TimeLate = dtNow.TimeOfDay - TTNH.ThoiGianBatDauLamViecChieu;
            }
            int MinuteLate = TimeLate.Hours * 60 + TimeLate.Minutes;
            StringBuilder temp = new StringBuilder(bangChamCong.LichSuLamViec);
            if (MinuteLate < 15) temp[indexDay * 2 + SangChieu] = '1';
            else temp[indexDay * 2 + SangChieu] = (char)(MinuteLate / 15 + 64);
            bangChamCong.LichSuLamViec = temp.ToString();
            bangChamCong.TinhLuong += user.ChucVu.HeSoLuong - MinuteLate / 15 * TTNH.TienPhatTre15p;
            dALQLNH.SaveChanges();
        }
        public void DeleteEmployee(int ID_User)
        {
            GetNhanVienByID(ID_User).DaXoa = true;
            dALQLNH.SaveChanges();
        }
        public DateTime GetNgayChamCongHienTai()
        {
            return dALQLNH.ThongTinNhaHangs.Find(1).NgayBatDauChamCongHienTai;
        }
        public BangChamCong GetEmployeeTimeSheetByID_User(int ID_User, DateTime date)
        {
            return dALQLNH.BangChamCongs.Where(c => c.ID_User == ID_User && c.NgayDauTienTinhCong == date).FirstOrDefault();
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


    }
}
