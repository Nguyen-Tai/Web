using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class HoSoTaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TaiKhoanId { get; set; }

        [Column(TypeName = "ntext")]
        public string? CreditCard { get; set; }
        public string TenNguoiTT { get; set; }
        public string DiaChiTT1 { get; set; }
        public string? DiaChiTT2 { get; set; }
        public string DienThoaiTT { get; set; }
        public string TenNguoiNH { get; set; }
        public string DiaChiNH1 { get; set; }
        public string? DiaChiNH2 { get; set; }
        public string DienThoaiNH { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
