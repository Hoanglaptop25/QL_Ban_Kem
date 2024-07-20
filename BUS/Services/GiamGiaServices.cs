using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class GiamGiaServices
    {
        GiamGiaRepos giamGiaRepos = new GiamGiaRepos();

        public GiamGiaServices()
        {
            giamGiaRepos = new GiamGiaRepos();
        }
        public List<GiamGia> GetAllGiamGia()
        {
            return giamGiaRepos.GetAllGiamGia();
        }
        public string CreateGiamGia(GiamGia gg)
        {
            if (giamGiaRepos.CreateGiamGia(gg))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
    }
}
