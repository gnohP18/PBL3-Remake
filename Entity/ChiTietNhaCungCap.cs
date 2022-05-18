using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("ChiTietNhaCungCap")]
    public class ChiTietNhaCungCap
    {
        [Key, Column(Order = 0)]
        [Required]
        public int ID_NhaCungCap { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int ID_NguyenLieu { get; set; }
        public int DonGia { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }

    }
}
