using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GiamGiaRepos
    {
        AppDbContext _context = new AppDbContext();

        public GiamGiaRepos()
        {
            _context = new AppDbContext();
        }
        public List<GiamGia> GetAllGiamGia()
        {
            return _context.giamGias.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public GiamGia GetById(int id)
        {
            return _context.giamGias.Find(id);
        }
        public bool CreateGiamGia(GiamGia gg)
        {
            try
            {
                _context.giamGias.Add(gg);
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
