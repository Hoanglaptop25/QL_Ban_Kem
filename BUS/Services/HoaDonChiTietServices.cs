using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonChiTietServices
    {
        HoaDonChiTietRepos hoaDonChiTietRepos = new HoaDonChiTietRepos();

        public HoaDonChiTietServices()
        {
            hoaDonChiTietRepos = new HoaDonChiTietRepos();
        }
        public List<HoaDonChiTiet> GetAllHDCT()
        {
            return hoaDonChiTietRepos.GetAllHDCT();
        }
        public string CreateHDCT(HoaDonChiTiet hdct)
        {
            if (hoaDonChiTietRepos.CreateHDCT(hdct))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
    }
}
