using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{

    [Table("ChiTietMonAn")]
    public class ChiTietMonAn
    {
        [Key , Column(Order = 0)][Required]
        public int ID_MonAn { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int ID_NguyenLieu { get; set; }
        public double Luong { get; set; }
        public virtual MonAn MonAn { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
