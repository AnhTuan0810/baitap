using System.ComponentModel.DataAnnotations;

namespace buoi3.Models.BT
{
    public class SanPham
    {
        [Key]
        public int MaSanPham { get; set; } 

        public string TenSanPham { get; set; } 
        public string MoTa { get; set; } 

        // Quan hệ 1-nhiều với SanPhamChiTiet
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
    }
}
