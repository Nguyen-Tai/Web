using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class ChiTietDonDatHang
    {
        public int SanPhamId { get; set; }
        public virtual SanPham SanPham { get; set; }
        public Guid DonDatHangId { get; set; }
        public virtual DonDatHang DonDatHang { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }
        [Column(TypeName = "money")]
        public decimal? TongCong { get; set; }       
    }
}
