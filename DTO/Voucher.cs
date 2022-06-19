using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Voucher")]
    public class Voucher
    {
        public Voucher()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [Required]
        public string MaVoucher { get; set; }
        public string GiaTriVoucher { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int HanMucSuDung { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
