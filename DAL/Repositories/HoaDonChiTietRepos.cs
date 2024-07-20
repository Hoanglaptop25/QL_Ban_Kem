using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonChiTietRepos
    {
        AppDbContext _context = new AppDbContext();

        public HoaDonChiTietRepos()
        {
            _context = new AppDbContext();
        }
        public List<HoaDonChiTiet> GetAllHDCT()
        {
            return _context.HoaDonChiTiets.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public HoaDonChiTiet GetById(int id)
        {
            return _context.HoaDonChiTiets.Find(id);
        }
        public bool CreateHDCT(HoaDonChiTiet hdct)
        {
            try
            {
                _context.HoaDonChiTiets.Add(hdct);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
