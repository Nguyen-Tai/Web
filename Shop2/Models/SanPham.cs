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
        [Required]
        [MaxLength(500)]
        public string TenSanPham { get; set; }

        [MaxLength(1000)]
        [DisplayName("Mô tả")]
        public string? MotaSP { get; set; }

        [DisplayName("Giá sản phẩm")]
        [Column(TypeName = "money")]
        [Required]
        public int Gia { get; set; }

        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [DisplayName("Tác giả")]
        [MaxLength(1000)]
        public string TacGia { get; set; }

        [DisplayName("Nhà xuất bản")]
        [MaxLength(1000)]
        public string NXB { get; set; }

        [DisplayName("Ngôn ngữ")]
        [MaxLength(50)]
        public string NgonNgu { get; set; }

        [DisplayName("Ngày thêm")]
        public DateTime NgayThem { get; set; }
        public virtual ICollection<SanPhamMatHang> SanPhamMatHangs { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
    }
}
