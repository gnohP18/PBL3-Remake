using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieu_View
    {
        public int ID_NguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public float LuongTonKho { get; set; }
        public string DonViTinh { get; set; }
        public string TenLoaiNguyenLieu { get; set; }
    }
}