using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("User")]
    public class User
    {
        public User()
        {
            this.HoaDons = new HashSet<HoaDon>();
            this.BangChamCongs = new HashSet<BangChamCong>();
            this.CaLams = new HashSet<CaLam>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_User { get; set; }
        [Required]
        public int ID_ChucVu { get; set; }
        public string TenUser { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public byte[] AnhUser { get; set; }
        public string DiaChi { get; set; }
        public string CMND_CCCD { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public System.DateTime NgayBatDauLam { get; set; }

        public virtual ChucVu ChucVu { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<BangChamCong> BangChamCongs { get; set; }
        public virtual ICollection<CaLam> CaLams { get; set; }
    }
}