using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("ChucVu")]
    public class ChucVu
    {
        public ChucVu()
        {
            this.Users = new HashSet<User>();
        }
        [Key]
        [Required]
        public int ID_ChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string MoTa { get; set; }
        public int HeSoLuong { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}