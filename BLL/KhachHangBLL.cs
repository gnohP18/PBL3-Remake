using Entity;
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
        }
    }
}
