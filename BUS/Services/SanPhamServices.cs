using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamServices
    {
        SanPhamRepos sanPhamRepos = new SanPhamRepos();

        public SanPhamServices()
        {
            sanPhamRepos = new SanPhamRepos();
        }
        public List<SanPham> GetAllSanPham()
        {
            return sanPhamRepos.GetAllSanPham();
        }
        public string CreateSanPham(SanPham sp)
        {
            if (sanPhamRepos.CreateSP(sp))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }

    }
}
