using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("HoaDon")]
    public class HoaDon
    {
        public HoaDon()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_HoaDon { get; set; }
        [Required]
        public int ID_User { get; set; }
        public System.DateTime NgayLap { get; set; }
        public int TongTien { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
