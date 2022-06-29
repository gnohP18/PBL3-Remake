using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("KhachHang")]
    public class KhachHang
    {
        public KhachHang()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_KhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgayDangKy { get; set; }
        public bool DaXoa { get; set; }
        public int DiemTichLuy { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public override string ToString()
        {
            return this.TenKhachHang;
        }
    }
}
