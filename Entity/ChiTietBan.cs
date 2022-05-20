using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("ChiTietBan")]
    public class ChiTietBan
    {
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ChiTietBan { get; set; }
        [Required]
        public int ID_Ban { get; set; }
        [Required]
        public int ID_MonAn { get; set; }
        public int TinhTrang { get; set; }


        public virtual Ban Ban { get; set; }
        public virtual MonAn MonAn { get; set; }
    }
}
 