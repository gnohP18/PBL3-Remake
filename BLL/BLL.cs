using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BLL
{
    public class BLL
    {
        protected DALQLNH dALQLNH;
        protected BLL()
        {
            dALQLNH = new DALQLNH();
        }
        #region Thông tin nguyên liệu hiện tại, lấy nguyên liệu qua tên
        

        #endregion
        #region CheckLogin, GetAllUser
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
            if (bangChamCong.LichSuLamViec[indexDay * 2 + SangChieu] != '0') return;
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
            dALQLNH.SaveChanges();
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
        
        
        #endregion
        #region Thống kê

        
        
        #endregion
    }
}
