using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    [Table("NhaCungCap")]
    public class NhaCungCap
    {
        public NhaCungCap()
        {
            this.ChiTietNhaCungCaps = new HashSet<ChiTietNhaCungCap>();
            this.Khoes = new HashSet<Kho>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_NhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public string SoDienThoai { get; set; }
        public virtual ICollection<ChiTietNhaCungCap> ChiTietNhaCungCaps { get; set; }
        public virtual ICollection<Kho> Khoes { get; set; }
        public override string ToString()
        {
            return this.TenNhaCungCap;
        }
    }
}
