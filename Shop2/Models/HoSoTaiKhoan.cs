using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class HoSoTaiKhoan
    {
        [Key]
        public int TaiKhoanId { get; set; }

        [Column(TypeName = "ntext")]
        [DisplayName("Thẻ thanh toán")]
        public string? CreditCard { get; set; }

        [DisplayName("Tên người thanh toán")]
        public string TenNguoiTT { get; set; }

        [DisplayName("Địa chỉ người thanh toán 1")]
        public string DiaChiTT1 { get; set; }

        [DisplayName("Địa chỉ người thanh toán 2")]
        public string? DiaChiTT2 { get; set; }

        [DisplayName("Điện thoại người thanh toán")]
        public string DienThoaiTT { get; set; }

        [DisplayName("Tên người nhận hàng")]
        public string TenNguoiNH { get; set; }

        [DisplayName("Địa chỉ người nhận hàng 1")]
        public string DiaChiNH1 { get; set; }

        [DisplayName("Địa chỉ người nhận hàng 2")]
        public string? DiaChiNH2 { get; set; }

        [DisplayName("Điện thoại người nhận hàng")]
        public string DienThoaiNH { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
