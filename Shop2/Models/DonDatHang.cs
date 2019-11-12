using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class DonDatHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DonDatHangId { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime NgayTao { get; set; }

        [DisplayName("Ngày giao")]
        public DateTime? NgayGiao { get; set; }

        [DisplayName("Xác nhận")]
        public bool XacNhan { get; set; }

        [DisplayName("Hoàn tất")]
        public bool HoanTat { get; set; }

        [DisplayName("Hủy")]
        public bool Huy { get; set; }

        [DisplayName("Ghi chú")]
        public bool GhiChu { get; set; }

        [DisplayName("Tên khách hàng")]
        public string TenKhachHang { get; set; }

        [DisplayName("Email khách hàng")]
        public string EmailKhachHang { get; set; }

        [DisplayName("Tên người thanh toán")]
        public string TenNguoiTT { get; set; }

        [DisplayName("Địa chỉ người thanh toán 1")]
        public string DiaChiTT1 { get; set; }

        [DisplayName("Địa chỉ người thanh toán 2")]
        public string? DiaChiTT2 { get; set; }

        [DisplayName("Điện thoại người thanh toán 1")]
        public string DienThoaiTT { get; set; }

        [DisplayName("Tên người nhận hàng")]
        public string TenNguoiNH { get; set; }

        [DisplayName("Địa chỉ người nhận hàng 2")]
        public string? DiaChiNH1 { get; set; }

        [DisplayName("Địa chỉ người nhận hàng 1")]
        public string DiaChiNH { get; set; }

        [DisplayName("Điện thoại nhận hàng")]
        public string DienThoaiNH { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

    }
}
