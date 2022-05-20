using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("BangChamCong")]
    public class BangChamCong
    {
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_BangChamCong { get; set; }
        [Required]
        public int ID_User { get; set; }
        public string LichSuLamViec { get; set; }
        public DateTime NgayDauTienTinhCong { get; set; }

        public virtual User User { get; set; }
    }
}