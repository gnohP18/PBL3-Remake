using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
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
        public int SoTienQuyDoiThanhDiemTichLuy { get; set; }
        public int DiemTichLuyQuyDoiThanhTien { get; set; }
        public TimeSpan ThoiGianBatDauLamViecSang { get; set; }
        public TimeSpan ThoiGianKetThucLamViecSang { get; set; }
        public TimeSpan ThoiGianBatDauLamViecChieu { get; set; }
        public TimeSpan ThoiGianKetThucLamViecChieu { get; set; }
        public DateTime NgayBatDauChamCongHienTai { get; set; }
        public int NgayPhatLuong { get; set; }
        public int TienPhatTre15p { get; set; }   
    }
}
