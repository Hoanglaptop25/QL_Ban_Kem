using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class TaiKhoanServices
    {
        TaiKhoanRepos taiKhoanRepos = new TaiKhoanRepos();

        public TaiKhoanServices()
        {
            taiKhoanRepos = new TaiKhoanRepos();
        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return taiKhoanRepos.GetAllTaiKhoan();
        }
        public string CreateTaiKhoan(TaiKhoan tk)
        {
            if (taiKhoanRepos.CreateTaiKhoan(tk))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
    }
}
