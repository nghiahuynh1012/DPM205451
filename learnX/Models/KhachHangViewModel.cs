using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace learnX.Models
{
    public class KhachHangViewModel
    {
        public KhachHangViewModel()
        {
        }

        [DisplayName("ID")]
        public int uID { get; set; }

        [DisplayName("Họ và tên")]
        [MaxLength(50, ErrorMessage = "Họ và tên không quá 50 ký tự.")]
        public string uHoTen { get; set; }

        [DisplayName("Giới tính")]
        public bool uGioiTinh { get; set; }

        [DisplayName("Ngày Sinh")]
        public DateTime uNgaySinh { get; set; }

        [DisplayName("Điện Thoại")]
        [MaxLength(10, ErrorMessage = "Điện thoại không quá 10 ký tự.")]
        public string uSoDienThoai { get; set; }

        [DisplayName("Địa Chỉ")]
        [MaxLength(50, ErrorMessage = "Địa chỉ không quá 50 ký tự.")]
        public string uDiaChi { get; set; }
    }
}
