using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class LoaiMatHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MatHangId { get; set; }

        [DisplayName("Tên mặt hàng")]
        [Required]
        [MaxLength(100)]
        public string TenMatHang { get; set; }

        [DisplayName("Mô tả")]
        [MaxLength(1000)]
        public string MoTaMatHang { get; set; }
        public virtual ICollection<SanPhamMatHang> SanPhamMatHangs { get; set; }
    }
}
