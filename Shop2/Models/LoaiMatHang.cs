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
        public string TenMatHang { get; set; }
        [MaxLength(100)]

        [DisplayName("Mô tả")]
        public string MoTaMatHang { get; set; }
        [MaxLength(1000)]
        public virtual ICollection<SanPhamMatHang> SanPhamMatHangs { get; set; }
    }
}
