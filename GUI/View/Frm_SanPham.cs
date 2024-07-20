using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class Frm_SanPham : Form
    {
        SanPhamServices SanPhamServices;
        public Frm_SanPham()
        {
            SanPhamServices = new SanPhamServices();
            InitializeComponent();

        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            string tensp = txt_TenSP.Text;
            int gia = Convert.ToInt32(txt_DonGia.Text);
            int soluong = Convert.ToInt32(txt_SoLuongSP.Text);
            int trangthai = cbb_TrangThaiSP.SelectedIndex;
            SanPham sp = new SanPham() { GiaSanPham = gia,TenSanPham = tensp,SoLuong = soluong,TrangThai = trangthai};
            MessageBox.Show(SanPhamServices.CreateSanPham(sp));
            LoadSanPham();
        }
        public void LoadSanPham()
        {
            dtg_QuanLySP.Rows.Clear();
            var sp = SanPhamServices.GetAllSanPham();
            dtg_QuanLySP.ColumnCount = 5;
            dtg_QuanLySP.Columns[0].HeaderText = "Mã sản phẩm";
            dtg_QuanLySP.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_QuanLySP.Columns[2].HeaderText = "Giá sản phẩm";
            dtg_QuanLySP.Columns[3].HeaderText = "Số lượng";
            dtg_QuanLySP.Columns[4].HeaderText = "Trạng thái";
            foreach (var data in sp)
            {
                dtg_QuanLySP.Rows.Add(data.Id, data.TenSanPham, data.GiaSanPham, data.SoLuong, data.TrangThai);
            }
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
    }
}
