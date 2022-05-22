using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("ChiTietCaLam")]
    public class ChiTietCaLam
    {
        [Key, Column(Order = 0)]
        [Required]
        public int ID_CaLam { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int ID_User { get; set; }
        public virtual CaLam CaLam { get; set; }
        public virtual User User { get; set; }
    }
}
