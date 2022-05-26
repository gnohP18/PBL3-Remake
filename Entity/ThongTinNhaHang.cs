using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("ThongTinNhaHang")]
    public class ThongTinNhaHang
    {
        public ThongTinNhaHang()
        {
            
        }
        [Key]
        [Required]
        public int ID_ThongTinNhaHang { get; set; }
        public string TenNhaHang { get; set; }
        public string DiaChi { get; set; }
        public DateTime ThoiGianBatDauLamViecSang { get; set; }
        public DateTime ThoiGianKetThucLamViecSang { get; set; }
        public DateTime ThoiGianBatDauLamViecChieu { get; set; }
        public DateTime ThoiGianKetThucLamViecChieu { get; set; }
        public int NgayPhatLuong { get; set; }
    }
}
