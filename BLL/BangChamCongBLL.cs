using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class BangChamCongBLL : BLL
    {
        private static BangChamCongBLL _Instance;
        public static BangChamCongBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BangChamCongBLL();
                return _Instance;
            }
            private set { }
        }
        private BangChamCongBLL()
        {

        }
        public DateTime GetNgayChamCongHienTai()
        {
            return dALQLNH.ThongTinNhaHangs.Find(1).NgayBatDauChamCongHienTai;
        }
        public BangChamCong GetEmployeeTimeSheetByID_User(int ID_User, DateTime date)
        {
            return dALQLNH.BangChamCongs.Where(c => c.ID_User == ID_User && c.NgayDauTienTinhCong == date).FirstOrDefault();
        }

        public void ChamCong(int ID_User)
        {
            User user = dALQLNH.Users.Find(ID_User);
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            DateTime dtNow = DateTime.Now;
            int indexDay = (dtNow - TTNH.NgayBatDauChamCongHienTai).Days;
            int SangChieu = NhanVienBLL.Instance.GetBuoiLamNow();
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
            else if (MinuteLate  >= 120)
            {
                temp[indexDay * 2 + SangChieu] = '2';
                bangChamCong.TinhLuong = 0;
            }
            else
            {
                temp[indexDay * 2 + SangChieu] = (char)(MinuteLate / 15 + 64);
                bangChamCong.TinhLuong += user.ChucVu.HeSoLuong - MinuteLate / 15 * TTNH.TienPhatTre15p;
            }
            bangChamCong.LichSuLamViec = temp.ToString();
            dALQLNH.SaveChanges();
        }
        public int GetNewIDBangChamCong()
        {
            int id = 1;
            foreach (BangChamCong i in dALQLNH.BangChamCongs)
            {
                if (id != i.ID_BangChamCong)
                {
                    return id;
                }
                id++;
            }
            return id;

        }
        public void UpdateBangChamCongDauCa()
        {
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            DateTime dtEndChamCong = TTNH.NgayBatDauChamCongHienTai.AddMonths(1);
            dtEndChamCong = new DateTime(dtEndChamCong.Year, dtEndChamCong.Month, TTNH.NgayPhatLuong);
            if (DateTime.Now >= dtEndChamCong )
            {
                TTNH.NgayBatDauChamCongHienTai = dtEndChamCong;
                dtEndChamCong = TTNH.NgayBatDauChamCongHienTai.AddMonths(1);
                dtEndChamCong = new DateTime(dtEndChamCong.Year, dtEndChamCong.Month, TTNH.NgayPhatLuong);
                string s = "";
                for(int i = 1;i<(dtEndChamCong - TTNH.NgayBatDauChamCongHienTai).Days*2 + 2; i++)
                {
                    s += "0";
                }
                foreach(User i in dALQLNH.Users.ToList())
                {
                    dALQLNH.BangChamCongs.Add(new BangChamCong
                    {
                        ID_BangChamCong = GetNewIDBangChamCong(),
                        ID_User = i.ID_User,
                        NgayDauTienTinhCong = TTNH.NgayBatDauChamCongHienTai,
                        LichSuLamViec = s,
                        TinhLuong = 0
                    });
                    dALQLNH.SaveChanges();
                }
            }
        }

        public void SetUpBangChamCongNowForNhanVien(int ID_NhanVien)
        {
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            DateTime dtEndChamCong = TTNH.NgayBatDauChamCongHienTai.AddMonths(1);
            dtEndChamCong = new DateTime(dtEndChamCong.Year, dtEndChamCong.Month, TTNH.NgayPhatLuong);
            string s = "";
            for (int i = 1; i <= (dtEndChamCong - TTNH.NgayBatDauChamCongHienTai).Days * 2 + 2; i++)
            {
                s += "0";
            }
            dALQLNH.BangChamCongs.Add(new BangChamCong
            {
                ID_BangChamCong = GetNewIDBangChamCong(),
                ID_User = ID_NhanVien,
                NgayDauTienTinhCong = TTNH.NgayBatDauChamCongHienTai,
                LichSuLamViec = s,
                TinhLuong = 0
            });
            dALQLNH.SaveChanges();

        }
    }
}
