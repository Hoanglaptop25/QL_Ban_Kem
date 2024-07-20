using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonSevices
    {
        HoaDonRepos hoaDonRepos = new HoaDonRepos();

        public HoaDonSevices()
        {
            hoaDonRepos = new HoaDonRepos();
        }
        public List<HoaDon> GetAllHoaDon()
        {
            return hoaDonRepos.GetAllHoaDon();
        }
    }
}
