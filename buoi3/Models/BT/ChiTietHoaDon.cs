using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace buoi3.Models.BT
{
    public class ChiTietHoaDon
    {
        [Key]
        public int MaChiTietHoaDon { get; set; } 

        // Khóa ngoại đến HoaDon
        public int MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        // Khóa ngoại đến SanPhamChiTiet
        public int MaSanPhamChiTiet { get; set; }
        [ForeignKey("MaSanPhamChiTiet")]
        public virtual SanPhamChiTiet SanPhamChiTiet { get; set; }

        public int SoLuong { get; set; } 
        public decimal DonGia { get; set; } 
    }
}
