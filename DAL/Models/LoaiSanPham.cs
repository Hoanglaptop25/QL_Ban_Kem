using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int Id { get; set; }
        public string TenLoaiSanPham { get; set; }
        public string MoTa { get; set; }
        public SanPham SanPham { get; set; }
    }
}
