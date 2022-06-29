using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    [Table("ChucVu")]
    public class ChucVu
    {
        public ChucVu()
        {
            this.Users = new HashSet<User>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_ChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string MoTa { get; set; }
        public int HeSoLuong { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public override string ToString()
        {
            return TenChucVu;
        }
    }
}