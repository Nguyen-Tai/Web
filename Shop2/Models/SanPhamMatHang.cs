using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class SanPhamMatHang
    {
        public int SanPhamId { get; set; }
        public virtual SanPham SanPham { get; set; }
        public int MatHangId { get; set; }
        public virtual LoaiMatHang LoaiMatHang { get; set; }
    }
}
