using DTO;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class KhachHangBLL : BLL
    {
        private static KhachHangBLL _Instance;
        public static KhachHangBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new KhachHangBLL();
                return _Instance;
            }
            private set { }
        }
        private KhachHangBLL()
        {

        }
        public List<KhachHang> GetAllGuest()
        {
            return dALQLNH.KhachHangs.ToList();
        }
        public KhachHang GetGuestByIDGuest(int ID_Guest)
        {
            return dALQLNH.KhachHangs.Where(p => p.ID_KhachHang == ID_Guest).FirstOrDefault();
        }
        public KhachHang GetGuestByGuestPhoneNumber(string GuestPhoneNumber)
        {
            return dALQLNH.KhachHangs.Where(p => p.SDT == GuestPhoneNumber).FirstOrDefault();
        }
        public int GetNewIDKhachHang()
        {
            int ID = 1;
            foreach (KhachHang i in dALQLNH.KhachHangs)
            {
                if (ID != i.ID_KhachHang)
                {
                    return ID;
                }
                ID++;
            }
            return ID;
        }
        public void DeleteKhachHangByIDKhachHang(int ID_KhachHang)
        {
            GetGuestByIDGuest(ID_KhachHang).DaXoa = true;
            dALQLNH.SaveChanges();
        }
        public void AddNewKhachHang(string TenKhachHang, string SDT, string DiaChi, bool GioiTinh, int DiemTihLuy)
        {
            KhachHang newKhachHang = new KhachHang();
            newKhachHang.ID_KhachHang = GetNewIDKhachHang();
            newKhachHang.TenKhachHang = TenKhachHang;
            newKhachHang.DaXoa = false;
            newKhachHang.DiaChi = DiaChi;
            newKhachHang.NgayDangKy = System.DateTime.Now;
            newKhachHang.SDT = SDT;
            newKhachHang.GioiTinh = GioiTinh;
            newKhachHang.DiemTichLuy = DiemTihLuy;
            dALQLNH.KhachHangs.Add(newKhachHang);
            dALQLNH.SaveChanges();
        }
        public List<ChiTietKhachHang_View> GetDetailGuest_ViewByID_Guest(int ID_Guest)
        {
            List<ChiTietKhachHang_View> list = new List<ChiTietKhachHang_View>();
            KhachHang kh = GetGuestByIDGuest(ID_Guest);
            foreach (HoaDon i in HoaDonBLL.Instance.GetAllHoaDonByIDKhachHang(ID_Guest))
            {
                ChiTietKhachHang_View ctkh_v = new ChiTietKhachHang_View();
                ctkh_v.ID_Guest = ID_Guest;
                ctkh_v.Name_Guest = kh.TenKhachHang;
                ctkh_v.ID_Receipt = i.ID_HoaDon;
                ctkh_v.MoneyConvertFormPoint = i.TienQuyDoiTuDiemTichLuy;
                ctkh_v.Total = i.TongTien;
                ctkh_v.Date_Create = i.NgayLap;
                list.Add(ctkh_v);
            }
            return list;
        }
    }
}
