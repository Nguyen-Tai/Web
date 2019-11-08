using System;
using System.Collections.Generic;
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
        public Guid DonDatHangId { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayGiao { get; set; }
        public bool XacNhan { get; set; }
        public bool HoanTat { get; set; }
        public bool Huy { get; set; }
        public bool GhiChu { get; set; }
        public string TenKhachHang { get; set; }
        public string EmailKhachHang { get; set; }
        public string TenNguoiTT { get; set; }
        public string DiaChiTT1 { get; set; }
        public string? DiaChiTT2 { get; set; }
        public string DienThoaiTT { get; set; }
        public string TenNguoiNH { get; set; }
        public string? DiaChiNH1 { get; set; }
        public string DiaChiNH { get; set; }
        public string DienThoaiNH { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

    }
}
