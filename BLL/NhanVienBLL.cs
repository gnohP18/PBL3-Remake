using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public User GetEmployeeByID_Employee(int ID_Employee)
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
                    if (i == '1' || i == 'A' || i == 'B')
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
                Employee_view employee = new Employee_view();
                employee.ID_User = i.ID_User;
                employee.User_Name = i.TenUser;
                employee.User_Position = i.ChucVu.TenChucVu;
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
                }
                list.Add(employee);
            }
            return list;
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
    }
}
