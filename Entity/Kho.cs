using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("Kho")]
    public class Kho
    {
        [Key, Column(Order = 0)]
        [Required]
        public int ID_NguyenLieu { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int ID_NhaCungCap { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public float LuongNhapVao { get; set; }
        public float LuongTonKho { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }

    }
}
