using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entity
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

    }
}
