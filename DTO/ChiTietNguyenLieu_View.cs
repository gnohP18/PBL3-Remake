using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietNguyenLieu_View
    {
        public int ID_ChiTietNguyenLieu { get; set; }
        public int ID_NguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public int ID_NhaCungCap { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public float LuongNhapVao { get; set; }
        public float LuongTonKho { get; set; }
    }
}
