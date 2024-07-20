using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonRepos
    {
        AppDbContext _context = new AppDbContext();

        public HoaDonRepos()
        {
            _context = new AppDbContext();
        }
        public List<HoaDon> GetAllHoaDon()
        {
            return _context.HoaDons.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public HoaDon GetById(int id)
        {
            return _context.HoaDons.Find(id);
        }
        public bool CreateSP(HoaDon hd)
        {
            try
            {
                _context.HoaDons.Add(hd);
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
