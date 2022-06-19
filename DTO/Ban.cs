using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Ban")]
    public class Ban
    {
        public Ban()
        {
            this.ChiTietBans = new HashSet<ChiTietBan>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_Ban { get; set; }
        public string TenBan { get; set; }
        public int Tang { get; set; }
        public int TinhTrangBan { get; set; }
        public virtual ICollection<ChiTietBan> ChiTietBans { get; set; }
        public override string ToString()
        {
            return this.TenBan;
        }
    }
}
