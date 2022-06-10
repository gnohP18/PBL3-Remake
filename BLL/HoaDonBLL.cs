using Entity;
using System.Collections.Generic;

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
    }
}
