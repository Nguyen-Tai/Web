using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int DonDatHangId { get; set; }
        public virtual DonDatHang DonDatHang { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }
        [MaxLength(1000)]

        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Đơn giá")]
        public decimal DonGia { get; set; }

        [DisplayName("Tổng cộng")]
        [Column(TypeName = "money")]
        public decimal? TongCong { get; set; }       
    }
}
