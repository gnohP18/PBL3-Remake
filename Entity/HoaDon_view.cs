using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HoaDon_View
    {
        public int ID_HoaDon { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongTien { get; set; }
        public int TienQuyDoiTuDiemTichLuy { get; set; }
        public string MaVoucher { get; set; }
    }
}
