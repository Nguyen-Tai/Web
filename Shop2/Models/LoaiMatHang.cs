using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class LoaiMatHang
    {   
        [Key]
        public int MatHangId { get; set; }
        public string TenMatHang { get; set; }
        [MaxLength(50)]
        public string MoTaMatHang { get; set; }
        [MaxLength(1000)]
        public virtual ICollection<SanPhamMatHang> SanPhamMatHangs { get; set; }
    }
}
