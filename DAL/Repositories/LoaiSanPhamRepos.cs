using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{

    public class LoaiSanPhamRepos
    {
        AppDbContext _context = new AppDbContext();
        public LoaiSanPhamRepos()
        {
            _context = new AppDbContext();
        }
        public List<LoaiSanPham> GetAllLoaiSanPham()
        {
            return _context.loaiSanPhams.ToList();
        }
        public LoaiSanPham GetById(int id)
        {
            return _context.loaiSanPhams.Find(id);
        }
        public bool CreateLoaiSP(LoaiSanPham lsp)
        {
            try
            {
                _context.loaiSanPhams.Add(lsp);
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
