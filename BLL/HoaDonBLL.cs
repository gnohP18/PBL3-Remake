using Entity;
using System;
using System.Collections.Generic;
using DTO;
namespace BLL
{
    public class HoaDonBLL : BLL
    {
        private static HoaDonBLL _Instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new HoaDonBLL();
                return _Instance;
            }
            private set { }
        }
        private HoaDonBLL()
        {

        }
        public List<HoaDon> GetAllHoaDonByIDKhachHang(int ID_KhachHang)
        {
            List<HoaDon> list = new List<HoaDon>();
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.ID_KhachHang == ID_KhachHang)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public List<HoaDon_View> GetAllInvoice_viewByDay(DateTime date)
        {
            List<HoaDon_View> list = new List<HoaDon_View>();
            foreach (HoaDon i in dALQLNH.HoaDons)
            {
                if (i.NgayLap == date)
                {
                    HoaDon_View hdv = new HoaDon_View();
                    hdv.ID_HoaDon = i.ID_HoaDon;
                    hdv.TenNhanVien = NhanVienBLL.Instance.GetEmployeeByID_Employee(i.ID_User).TenUser;
                    hdv.TenKhachHang = KhachHangBLL.Instance.GetGuestByIDGuest(i.ID_KhachHang).TenKhachHang;
                    hdv.TienQuyDoiTuDiemTichLuy = i.TienQuyDoiTuDiemTichLuy;
                    hdv.NgayLap = i.NgayLap;
                    hdv.MaVoucher = i.MaVoucher;
                    hdv.TongTien = i.TongTien;
                    list.Add(hdv);
                }
            }
            return list;
        }
    }
}
