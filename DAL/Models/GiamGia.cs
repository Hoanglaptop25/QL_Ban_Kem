using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class GiamGia
    {
        [Key]
        public int Id { get; set; }
        public string TenGiamGia { get; set; }
        public string LoaiGiamGia { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc {  get; set; }
        public string GiaTri { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }   
    }
}
