using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int TaiKhoanId { get; set; }

        [DisplayName("Tên tài khoản")]
        public string TenTaiKhoan { get; set; }

        [DisplayName("Quyền tài khoản")]
        public string QuyenTaiKhoan { get; set; }

        [DisplayName("Mật khẩu")]
        public string MatKhau { get; set; }

        [DisplayName("Câu hỏi bảo mật")]
        public string? CauHoiBaoMat { get; set; }

        [DisplayName("Câu trả lời")]
        public string? CauTraLoi { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime NgayTao { get; set; }
        public virtual HoSoTaiKhoan HoSoTaiKhoan { get; set; }

    }
}
