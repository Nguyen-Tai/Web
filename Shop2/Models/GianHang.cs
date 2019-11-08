using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class GianHang
    {
        public int GianHangId { get; set; }
        public string TenGianHang { get; set; }
        public string MoTaGH { get; set; }
        public virtual ICollection<LoaiMatHang> LoaiMatHangs { get; set; }
    }
}
