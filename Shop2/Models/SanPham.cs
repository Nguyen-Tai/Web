using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class SanPham
    {
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; }
        [MaxLength(1000)]
        public string? MotaSP { get; set; }
        public int Gia { get; set; }
        public string TacGia { get; set; }
        [MaxLength(1000)]
        public string NXB { get; set; }
        [MaxLength(1000)]
        public string NgonNgu { get; set; }
        [MaxLength(50)]
        public DateTime NgayThem { get; set; }
        public virtual ICollection<SanPhamMatHang> SanPhamMatHangs { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
    }
}
