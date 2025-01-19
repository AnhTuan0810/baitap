using System.ComponentModel.DataAnnotations;

namespace buoi3.Models.BT
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; } 

        public string TenKhachHang { get; set; } 
        public string SoDienThoai { get; set; } 
        public string Email { get; set; } 
        public string DiaChi { get; set; } 

        // Quan hệ 1-nhiều với HoaDon
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }
}
