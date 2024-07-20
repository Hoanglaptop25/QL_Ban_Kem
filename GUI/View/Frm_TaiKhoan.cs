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
    public partial class Frm_TaiKhoan : Form
    {
        TaiKhoanServices taiKhoanServices;
        public Frm_TaiKhoan()
        {
            InitializeComponent();
            taiKhoanServices = new TaiKhoanServices();
        }
        public void LoadTaiKhoan()
        {
            dtg_QuanLyNhanVien.Rows.Clear();
            var nhanvien = taiKhoanServices.GetAllTaiKhoan();
            dtg_QuanLyNhanVien.ColumnCount = 7;
            dtg_QuanLyNhanVien.Columns[0].HeaderText = "Mã tài khoản";
            dtg_QuanLyNhanVien.Columns[1].HeaderText = "Tên tài khoản";
            dtg_QuanLyNhanVien.Columns[2].HeaderText = "Mật khẩu";
            dtg_QuanLyNhanVien.Columns[3].HeaderText = "Quyền";
            dtg_QuanLyNhanVien.Columns[4].HeaderText = "SĐT";
            dtg_QuanLyNhanVien.Columns[5].HeaderText = "Giới tính";
            foreach(var tk in nhanvien)
            {
                string gioiTinhHienThi = tk.GioiTinh == 0 ? "Nam" : "Nữ";
                string quyen = tk.Quyen == 0 ? "Quản lý" : "Nhân viên";
                dtg_QuanLyNhanVien.Rows.Add(tk.Id ,tk.TenTaiKhoan, tk.MatKhau, quyen, tk.SDT, gioiTinhHienThi, tk.TrangThai);
            }
            dtg_QuanLyNhanVien.Columns[6].HeaderText = "Trạng thái";
            
           
        }
        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            string tentk = txt_TaiKhoan.Text;
            string matkhau = txt_MatKhau.Text;
            int quyen = cbb_Quyen.SelectedIndex;
            string SDT = txt_SDT.Text;
            int gioitinh = -1;
            if (rd_Nam.Checked)
            {
                gioitinh = 0;

            }else if (rd_Nu.Checked)
            {
                gioitinh = 1;
            }
            int trangthai = cbb_TrangThaiNhanVien.SelectedIndex;
            TaiKhoan tk = new TaiKhoan() { TenTaiKhoan = tentk,MatKhau = matkhau,Quyen = quyen,SDT = SDT,GioiTinh = gioitinh,TrangThai = trangthai};
            MessageBox.Show(taiKhoanServices.CreateTaiKhoan(tk));
            LoadTaiKhoan();
        }

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }
    }
}
