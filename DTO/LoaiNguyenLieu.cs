using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO
{
    [Table("LoaiNguyenLieu")]
    public class LoaiNguyenLieu
    {
        public LoaiNguyenLieu()
        {
            this.NguyenLieus = new HashSet<NguyenLieu>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ID_LoaiNguyenLieu { get; set; }
        public string TenLoaiNguyenLieu { get; set; }
        public virtual ICollection<NguyenLieu> NguyenLieus { get; set; }
        public override string ToString()
        {
            return this.TenLoaiNguyenLieu;
        }
    }
}