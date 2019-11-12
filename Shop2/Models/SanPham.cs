using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SanPhamId { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }
        [MaxLength(1000)]

        [DisplayName("Mô tả")]
        public string? MotaSP { get; set; }

        [DisplayName("Giá sản phẩm")]
        public int Gia { get; set; }

        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [DisplayName("Tác giả")]
        public string TacGia { get; set; }
        [MaxLength(1000)]

        [DisplayName("Nhà xuất bản")]
        public string NXB { get; set; }
        [MaxLength(1000)]

        [DisplayName("Ngôn ngữ")]
        public string NgonNgu { get; set; }
        [MaxLength(50)]

        [DisplayName("Ngày thêm")]
        public DateTime NgayThem { get; set; }
        public virtual ICollection<SanPhamMatHang> SanPhamMatHangs { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
    }
}
