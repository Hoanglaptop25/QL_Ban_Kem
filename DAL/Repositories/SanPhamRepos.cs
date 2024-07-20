using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SanPhamRepos
    {
        AppDbContext _context = new AppDbContext();

        public SanPhamRepos()
        {
            _context = new AppDbContext();
        }
        public List<SanPham> GetAllSanPham()
        {
            return _context.sanPhams.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public SanPham GetById(int id)
        {
            return _context.sanPhams.Find(id);
        }
        public bool CreateSP(SanPham sp)
        {
            try
            {
                _context.sanPhams.Add(sp);
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
