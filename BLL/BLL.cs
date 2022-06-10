using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public int checkLoginCustomer(string username, string password)
        {
            User user = (User)dALQLNH.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user == null) return -1;
            if (user.ID_ChucVu == 1) return 1;
            if (user.ID_ChucVu == 2) return -2;
            if (user.ID_ChucVu == 3)
            {
                int dateNowHashCode = DateTime.Now.GetHashCode();
                List<ChiTietCaLam> listChiTietCaLam = dALQLNH.ChiTietCaLams.Where(s => s.ID_User == user.ID_User).ToList();
                List<string> strCaLam = new List<string>();
                foreach (ChiTietCaLam i in listChiTietCaLam)
                {
                    strCaLam.Add(dALQLNH.CaLams.Find(i.ID_CaLam).LichCaLam);
                }
                foreach (string i in strCaLam)
                {

                }
            }
            return 1;
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
