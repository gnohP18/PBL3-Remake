using System.Collections.Generic;

namespace Entity
{
    public class HoaDon_view
    {
        public int ID { get; set; }
        public User user { get; set; }
        public List<ChiTietHoaDon> DanhSachMonAn { get; set; }
    }
}
