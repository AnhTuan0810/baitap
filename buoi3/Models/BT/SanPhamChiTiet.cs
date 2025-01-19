using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace buoi3.Models.BT
{
    public class SanPhamChiTiet
    {
        [Key]
        public int MaSanPhamChiTiet { get; set; } 

        // Khóa ngoại đến SanPham
        public int MaSanPham { get; set; }
        [ForeignKey("MaSanPham")]
        public virtual SanPham SanPham { get; set; }

        public string MauSac { get; set; } 
        public string KichThuoc { get; set; } 
        public int SoLuongTon { get; set; } 
        public decimal Gia { get; set; } 
    }
}
