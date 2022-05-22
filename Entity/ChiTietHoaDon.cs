using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {
        [Key, Column(Order = 0)]
        [Required]
        public int ID_HoaDon { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int ID_MonAn { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual MonAn MonAn { get; set; }
    }
}
