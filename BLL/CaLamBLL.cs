using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class CaLamBLL : BLL
    {
        private static CaLamBLL _Instance;
        public static CaLamBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CaLamBLL();
                return _Instance;
            }
            private set { }
        }
        private CaLamBLL()
        {

        }
        public Dictionary<CaLam, bool> GetAllCaLamByID_NhanVien(int ID_NhanVien)
        {
            Dictionary<CaLam, bool> data = new Dictionary<CaLam, bool>();
            if (NhanVienBLL.Instance.GetNhanVienByID(ID_NhanVien) == null)
            {
                foreach (CaLam i in dALQLNH.CaLams.ToList()) data.Add(i, false);
            }
            else
            {
                foreach (CaLam i in dALQLNH.CaLams.ToList())
                {
                    if (i.ChiTietCaLams.Where(s => s.ID_User == ID_NhanVien).FirstOrDefault() != null) data.Add(i, true);
                    else data.Add(i, false);
                }
            }
            return data;
        }
        public string GetStringCaLamTheoSangChieuByIDCalam(int ID_Calam, bool isSang)
        {
            string result = "";
            CaLam calam = dALQLNH.CaLams.Find(ID_Calam);
            string LichCaLam = calam.LichCaLam;
            if (isSang == true)
            {
                result += "Morning shift :";
                for (int i = 0; i < LichCaLam.Length; i++)
                {
                    if (i % 2 == 0 && LichCaLam[i] == '1')
                    {
                        if (result != "Morning shift :") result += ", ";
                        result += (DayOfWeek)(i / 2);
                        Console.WriteLine(result);
                    }
                }
                return result;
            }
            else
            {
                result += "Afternool shift :";
                for (int i = 0; i < LichCaLam.Length; i++)
                {
                    if (i % 2 != 0 && LichCaLam[i] == '1')
                    {
                        if (result != "Afternool shift :") result += ", ";
                        result += (DayOfWeek)(i / 2);
                    }
                }
                return result;
            }
        }

        public void SetCaLamForNhanVien(int ID_NhanVien, List<int> listIDCaLam)
        {
            foreach (ChiTietCaLam i in dALQLNH.ChiTietCaLams.ToList())
            {
                if (i.ID_User == ID_NhanVien)
                {
                    dALQLNH.ChiTietCaLams.Remove(i);
                    dALQLNH.SaveChanges();
                }
            }
            foreach (int i in listIDCaLam)
            {
                dALQLNH.ChiTietCaLams.Add(new ChiTietCaLam
                {
                    ID_User = ID_NhanVien,
                    ID_CaLam = i
                });
                dALQLNH.SaveChanges();
            }

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
        public TimeSpan GetThoiGianBatDauCaNow()
        {
            int SangChieu = GetBuoiLamNow();
            ThongTinNhaHang TTNH = dALQLNH.ThongTinNhaHangs.Find(1);
            if(SangChieu == 0)
            {
                return TTNH.ThoiGianBatDauLamViecSang;
            }
            else
            {
                return TTNH.ThoiGianBatDauLamViecChieu;
            }

        }
    }
}
