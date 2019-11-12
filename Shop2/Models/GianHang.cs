using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class GianHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GianHangId { get; set; }

        [DisplayName("Tên gian hàng")]
        [Required]
        [MaxLength(100)]
        public string TenGianHang { get; set; }

        [DisplayName("Mô tả")]
        [MaxLength(1000)]
        public string MoTaGH { get; set; }
        public virtual ICollection<LoaiMatHang> LoaiMatHangs { get; set; }
    }
}
