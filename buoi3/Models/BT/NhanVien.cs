using System.ComponentModel.DataAnnotations;

namespace buoi3.Models.BT
{
    public class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; } // Khóa chính

        public string TenNhanVien { get; set; } 
        public string SoDienThoai { get; set; } 
        public string DiaChi { get; set; } 

        // Quan hệ 1-nhiều với HoaDon
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }
}
