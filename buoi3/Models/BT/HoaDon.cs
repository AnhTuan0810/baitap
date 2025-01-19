using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace buoi3.Models.BT
{
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; } 

        public DateTime NgayLap { get; set; } 
        public decimal TongTien { get; set; } 

        // Khóa ngoại đến NhanVien
        public int MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

        // Khóa ngoại đến KhachHang
        public int MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        public virtual KhachHang KhachHang { get; set; }

        // Quan hệ 1-nhiều 
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
    }
}
