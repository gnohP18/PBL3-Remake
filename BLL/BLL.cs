using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
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
        public Dictionary<int, float> GetThongTinLuongNguyenLieuHienTai()
        {
            Dictionary<int, float> listThongTinLuongNguyenLieu = new Dictionary<int, float>();
            foreach (NguyenLieu i in dALQLNH.NguyenLieus)
            {
                listThongTinLuongNguyenLieu.Add(i.ID_NguyenLieu, 0);
            }
            var parentGroupKho = dALQLNH.Khoes.GroupBy(s => s.ID_NguyenLieu);
            foreach (var childGroupKho in parentGroupKho)
            {
                int ID_NguyenLieu = childGroupKho.Key;
                foreach (Kho i in childGroupKho)
                {
                    if (i.NgayHetHan > DateTime.Now)
                    {
                        listThongTinLuongNguyenLieu[ID_NguyenLieu] += i.LuongTonKho;
                    }
                }
            }
            return listThongTinLuongNguyenLieu;
        }

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
            BangChamCong bangChamCong = dALQLNH.BangChamCongs.Where(s=>s.ID_User == ID_User && s.NgayDauTienTinhCong == TTNH.NgayBatDauChamCongHienTai).FirstOrDefault();
            if (bangChamCong.LichSuLamViec[indexDay*2 + SangChieu] != '0') return;
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
            if (user.ID_ChucVu == 1 ) return 1;
            if(isCustomerLogin == true && user.ID_ChucVu != 2 && GetBuoiLamNow() != -1)
            {
                int SangChieu = GetBuoiLamNow();
                foreach(ChiTietCaLam i in user.ChiTietCaLams)
                {
                    if (i.CaLam.LichCaLam[DateTime.Now.DayOfWeek.GetHashCode()*2 + SangChieu] == '1') return 1;
                }
                return 0;
            }
            if(isCustomerLogin == false && user.ID_ChucVu == 2)
            {
                return 1;
            }
            return 0;
        }
        public List<User> GetAllNhanVienCoLichLamViecByTime(DateTime dt)
        {
            List<User> data = new List<User> ();
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
        public List<User> GetAllUser()
        {
            return dALQLNH.Users.ToList();
        }
        #endregion
        #region Thống kê


        public List<HoaDon> GetHoaDonByNgay(DateTime dt)
        {
            List<HoaDon> hd = new List<HoaDon>();
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (dt == i.NgayLap) hd.Add(i);
            }
            return hd;
        }
        public List<HoaDon_View> GetHoaDonByFromDatetoDate(DateTime dateStart, DateTime dateEnd)
        {
            List<HoaDon_View> hoaDonviews = new List<HoaDon_View>();
            foreach (HoaDon i in dALQLNH.HoaDons.Where(s => s.NgayLap >= dateStart && s.NgayLap <= dateEnd))
            {
                hoaDonviews.Add(new HoaDon_View
                {
                    ID_HoaDon = i.ID_HoaDon,
                    NgayLap = i.NgayLap,
                    TenKhachHang = i.KhachHang.TenKhachHang,
                    TenNhanVien = i.User.TenUser,
                    MaVoucher = i.MaVoucher,
                    TienQuyDoiTuDiemTichLuy = i.TienQuyDoiTuDiemTichLuy,
                    TongTien = i.TongTien
                });
            }
            return hoaDonviews;
        }
        public List<ChiTietHoaDon_View> GetChiTietHoaDonByIDHoaDon(int id)
        {
            List<ChiTietHoaDon_View> list = new List<ChiTietHoaDon_View>();
            foreach (ChiTietHoaDon i in dALQLNH.HoaDons.Find(id).ChiTietHoaDons)
            {
                list.Add(new ChiTietHoaDon_View
                {
                    TenMonAn = i.MonAn.TenMonAn,
                    SoLuong = i.SoLuong,
                    ThanhTien = i.MonAn.ThanhTien*i.SoLuong
                });
            }
            return list;
        }
        #endregion
    }
}
