using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
{
    [Table("MonAn")]
    public class MonAn
    {
        public MonAn()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            this.ChiTietBans = new HashSet<ChiTietBan>();
            this.ChiTietMonAns = new HashSet<ChiTietMonAn>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_MonAn { get; set; }
        public int ID_LoaiMonAn { get; set; }
        public string TenMonAn { get; set; }
        public int ThanhTien { get; set; }
        public byte[] AnhMonAn { get; set; }
        public int TrangThai { get; set; }
        public virtual LoaiMonAn LoaiMonAn { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<ChiTietBan> ChiTietBans { get; set; }
        public virtual ICollection<ChiTietMonAn> ChiTietMonAns { get; set; }
    }
}
