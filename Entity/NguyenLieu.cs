using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    [Table("NguyenLieu")]
    public class NguyenLieu
    {
        public NguyenLieu()
        {
            this.ChiTietMonAns = new HashSet<ChiTietMonAn>();
            this.Khoes = new HashSet<Kho>();
            this.ChiTietNhaCungCaps = new HashSet<ChiTietNhaCungCap>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_NguyenLieu { get; set; }
        public string DonViTinh { get; set; }
        public string TenNguyenLieu { get; set; }
        public int HSD { get; set; }
        [Required]
        public int ID_LoaiNguyenLieu { get; set; }

        public virtual LoaiNguyenLieu LoaiNguyenLieu { get; set; }
        public virtual ICollection<ChiTietNhaCungCap> ChiTietNhaCungCaps { get; set; }
        public virtual ICollection<Kho> Khoes { get; set; }
        public virtual ICollection<ChiTietMonAn> ChiTietMonAns { get; set; }
        public override string ToString()
        {
            return this.TenNguyenLieu;
        }

    }
}
