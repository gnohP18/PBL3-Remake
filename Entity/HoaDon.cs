using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
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
        [Required]
        public int ID_KhachHang { get; set; }
        public System.DateTime NgayLap { get; set; }
        public int TongTien { get; set; }
        public int TienQuyDoiTuDiemTichLuy { get; set; }
        public string MaVoucher { get; set; }
        public virtual User User { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
