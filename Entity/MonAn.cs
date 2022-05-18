using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("MonAn")]
    public class MonAn
    {
        public MonAn()
        {
            this.HoaDons = new HashSet<HoaDon>();
            this.ChiTietBans = new HashSet<ChiTietBan>();
            this.ChiTietMonAns = new HashSet<ChiTietMonAn>();
        }
        [Key]
        [Required]
        public int ID_MonAn { get; set; }
        public string TenMonAn { get; set; }
        public int ThanhTien { get; set; }
        public byte[] AnhMonAn { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<ChiTietBan> ChiTietBans { get; set; }
        public virtual ICollection<ChiTietMonAn> ChiTietMonAns { get; set; }
    }
}
