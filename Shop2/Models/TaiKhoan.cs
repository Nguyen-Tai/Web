using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TaiKhoanId { get; set; }

        public string TenTaiKhoan { get; set; }
        public string QuyenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string? CauHoiBaoMat { get; set; }
        public string? CauTraLoi { get; set; }
        public string Email { get; set; }
        public DateTime NgayTao { get; set; }
        public virtual HoSoTaiKhoan HoSoTaiKhoan { get; set; }

    }
}
