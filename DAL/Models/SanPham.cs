using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(LoaiSanPham))]
        public int? IdLoaiSp { get; set; }     
        public string TenSanPham { get; set; }
        public int GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual List<LoaiSanPham > LoaiSanPhams { get; set; }

    }
}
