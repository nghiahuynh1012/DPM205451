using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities
{
    [Table("wsKhachHang")]
    public class KhachHang
    {
        [Key]
        public int uID { get; set; }
        public string uHoTen { get; set; }
        public bool uGioiTinh { get; set; }
        public DateTime uNgaySinh { get; set; }
        public string uSoDienThoai { get; set; }
        public string uDiaChi { get; set; }
    
    }
}
