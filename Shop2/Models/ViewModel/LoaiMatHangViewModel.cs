using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models.ViewModel
{
    public class LoaiMatHangViewModel
    {
        public LoaiMatHang LoaiMatHang { get; set; }
        public IEnumerable<GianHang> GianHangs { get; set; }
    }
}
