using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    [Table("Kho")]
    public class Kho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_ChiTietNguyenLieu { get; set; }
        [Required]
        public int ID_NguyenLieu { get; set; }
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
