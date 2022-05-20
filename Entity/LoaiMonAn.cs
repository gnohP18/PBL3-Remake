using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("LoaiMonAn")]
    public class LoaiMonAn
    {
        public LoaiMonAn()
        {
            this.MonAns = new HashSet<MonAn>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_LoaiMonAnh { get; set; }
        public string TenLoaiMonAn { get; set; }
        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}
