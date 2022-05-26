using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("Voucher")]
    public class Voucher
    {
        public Voucher()
        {
          
        }
        [Key]
        [Required]
        public string MaVoucher { get; set; }
        public string GiaTriVoucher { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int HanMucSuDung { get; set; }

    }
}
