using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HoaDonChiTiet
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(SanPham))]
        public int IdSanPham { get; set; }
        [ForeignKey(nameof(HoaDon))]
        public int IdHoaDon { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public string Gia { get; set; }
        public string ThanhTien { get; set; }
        public string GhiChu {  get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }

    }
}
