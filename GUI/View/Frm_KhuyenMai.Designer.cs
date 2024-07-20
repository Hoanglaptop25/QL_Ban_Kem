namespace GUI.View
{
    partial class Frm_KhuyenMai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            btn_CapNhatKm = new Button();
            txt_GiaTriKM = new TextBox();
            btn_ThemKM = new Button();
            label10 = new Label();
            cbb_TrangThaiKM = new ComboBox();
            cbb_LoaiKM = new ComboBox();
            txt_TenKM = new TextBox();
            txt_MaKM = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_TaiKhoan = new PictureBox();
            panel2 = new Panel();
            label11 = new Label();
            cbb_TrangThaiKMTimKiem = new ComboBox();
            cbb_LoaiKMTimKiem = new ComboBox();
            btn_TimKM = new Button();
            txt_TenKMTimKiem = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dtgKhuyenMai = new DataGridView();
            cbbLoaiSPKM = new ComboBox();
            btnTimSPKm = new Button();
            txt_TenSpKM = new TextBox();
            label12 = new Label();
            label13 = new Label();
            dtgSanPhamKm = new DataGridView();
            dateNgayBatDauKM = new DateTimePicker();
            dateNgayKetThucKm = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKhuyenMai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgSanPhamKm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateNgayKetThucKm);
            panel1.Controls.Add(dateNgayBatDauKM);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_CapNhatKm);
            panel1.Controls.Add(txt_GiaTriKM);
            panel1.Controls.Add(btn_ThemKM);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbb_TrangThaiKM);
            panel1.Controls.Add(cbb_LoaiKM);
            panel1.Controls.Add(txt_TenKM);
            panel1.Controls.Add(txt_MaKM);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptb_TaiKhoan);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 974);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(20, 801);
            label5.Name = "label5";
            label5.Size = new Size(128, 31);
            label5.TabIndex = 19;
            label5.Text = "Trạng thái:";
            // 
            // btn_CapNhatKm
            // 
            btn_CapNhatKm.BackColor = Color.FromArgb(255, 192, 192);
            btn_CapNhatKm.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CapNhatKm.Location = new Point(405, 862);
            btn_CapNhatKm.Name = "btn_CapNhatKm";
            btn_CapNhatKm.Size = new Size(237, 85);
            btn_CapNhatKm.TabIndex = 17;
            btn_CapNhatKm.Text = "Cập nhật";
            btn_CapNhatKm.UseVisualStyleBackColor = false;
            // 
            // txt_GiaTriKM
            // 
            txt_GiaTriKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_GiaTriKM.Location = new Point(225, 588);
            txt_GiaTriKM.Name = "txt_GiaTriKM";
            txt_GiaTriKM.PasswordChar = '*';
            txt_GiaTriKM.Size = new Size(483, 38);
            txt_GiaTriKM.TabIndex = 15;
            // 
            // btn_ThemKM
            // 
            btn_ThemKM.BackColor = Color.FromArgb(255, 192, 192);
            btn_ThemKM.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThemKM.Location = new Point(96, 862);
            btn_ThemKM.Name = "btn_ThemKM";
            btn_ThemKM.Size = new Size(237, 85);
            btn_ThemKM.TabIndex = 16;
            btn_ThemKM.Text = "Thêm";
            btn_ThemKM.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.Location = new Point(20, 516);
            label10.Name = "label10";
            label10.Size = new Size(196, 31);
            label10.TabIndex = 14;
            label10.Text = "Loại khuyến mại:";
            // 
            // cbb_TrangThaiKM
            // 
            cbb_TrangThaiKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_TrangThaiKM.FormattingEnabled = true;
            cbb_TrangThaiKM.Location = new Point(225, 796);
            cbb_TrangThaiKM.Name = "cbb_TrangThaiKM";
            cbb_TrangThaiKM.Size = new Size(483, 39);
            cbb_TrangThaiKM.TabIndex = 13;
            // 
            // cbb_LoaiKM
            // 
            cbb_LoaiKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_LoaiKM.FormattingEnabled = true;
            cbb_LoaiKM.Location = new Point(225, 513);
            cbb_LoaiKM.Name = "cbb_LoaiKM";
            cbb_LoaiKM.Size = new Size(483, 39);
            cbb_LoaiKM.TabIndex = 9;
            // 
            // txt_TenKM
            // 
            txt_TenKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenKM.Location = new Point(225, 440);
            txt_TenKM.Name = "txt_TenKM";
            txt_TenKM.PasswordChar = '*';
            txt_TenKM.Size = new Size(483, 38);
            txt_TenKM.TabIndex = 8;
            // 
            // txt_MaKM
            // 
            txt_MaKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MaKM.Location = new Point(225, 364);
            txt_MaKM.Name = "txt_MaKM";
            txt_MaKM.Size = new Size(483, 38);
            txt_MaKM.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(20, 731);
            label6.Name = "label6";
            label6.Size = new Size(170, 31);
            label6.TabIndex = 6;
            label6.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(20, 660);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 4;
            label4.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(20, 588);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 3;
            label3.Text = "Giá trị:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(20, 440);
            label2.Name = "label2";
            label2.Size = new Size(188, 31);
            label2.TabIndex = 2;
            label2.Text = "Tên khuyến mại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(20, 367);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã khuyến mại:";
            // 
            // ptb_TaiKhoan
            // 
            ptb_TaiKhoan.Location = new Point(187, 9);
            ptb_TaiKhoan.Name = "ptb_TaiKhoan";
            ptb_TaiKhoan.Size = new Size(371, 323);
            ptb_TaiKhoan.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_TaiKhoan.TabIndex = 0;
            ptb_TaiKhoan.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgSanPhamKm);
            panel2.Controls.Add(cbbLoaiSPKM);
            panel2.Controls.Add(btnTimSPKm);
            panel2.Controls.Add(txt_TenSpKM);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(dtgKhuyenMai);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cbb_TrangThaiKMTimKiem);
            panel2.Controls.Add(cbb_LoaiKMTimKiem);
            panel2.Controls.Add(btn_TimKM);
            panel2.Controls.Add(txt_TenKMTimKiem);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(750, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 974);
            panel2.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(226, 51);
            label11.Name = "label11";
            label11.Size = new Size(454, 60);
            label11.TabIndex = 8;
            label11.Text = "Quản Lý Khuyến Mại";
            // 
            // cbb_TrangThaiKMTimKiem
            // 
            cbb_TrangThaiKMTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_TrangThaiKMTimKiem.FormattingEnabled = true;
            cbb_TrangThaiKMTimKiem.Location = new Point(677, 239);
            cbb_TrangThaiKMTimKiem.Name = "cbb_TrangThaiKMTimKiem";
            cbb_TrangThaiKMTimKiem.Size = new Size(159, 39);
            cbb_TrangThaiKMTimKiem.TabIndex = 7;
            // 
            // cbb_LoaiKMTimKiem
            // 
            cbb_LoaiKMTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_LoaiKMTimKiem.FormattingEnabled = true;
            cbb_LoaiKMTimKiem.Location = new Point(470, 239);
            cbb_LoaiKMTimKiem.Name = "cbb_LoaiKMTimKiem";
            cbb_LoaiKMTimKiem.Size = new Size(201, 39);
            cbb_LoaiKMTimKiem.TabIndex = 6;
            // 
            // btn_TimKM
            // 
            btn_TimKM.BackColor = Color.FromArgb(255, 192, 192);
            btn_TimKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimKM.Location = new Point(330, 238);
            btn_TimKM.Name = "btn_TimKM";
            btn_TimKM.Size = new Size(134, 38);
            btn_TimKM.TabIndex = 5;
            btn_TimKM.Text = "Tìm";
            btn_TimKM.UseVisualStyleBackColor = false;
            // 
            // txt_TenKMTimKiem
            // 
            txt_TenKMTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenKMTimKiem.Location = new Point(13, 238);
            txt_TenKMTimKiem.Name = "txt_TenKMTimKiem";
            txt_TenKMTimKiem.Size = new Size(300, 38);
            txt_TenKMTimKiem.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.Location = new Point(677, 184);
            label9.Name = "label9";
            label9.Size = new Size(128, 31);
            label9.TabIndex = 3;
            label9.Text = "Trạng thái:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.Location = new Point(470, 184);
            label8.Name = "label8";
            label8.Size = new Size(196, 31);
            label8.TabIndex = 2;
            label8.Text = "Loại khuyến mại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(13, 184);
            label7.Name = "label7";
            label7.Size = new Size(188, 31);
            label7.TabIndex = 1;
            label7.Text = "Tên khuyến mại:";
            // 
            // dtgKhuyenMai
            // 
            dtgKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgKhuyenMai.Location = new Point(13, 290);
            dtgKhuyenMai.Name = "dtgKhuyenMai";
            dtgKhuyenMai.RowHeadersWidth = 51;
            dtgKhuyenMai.Size = new Size(823, 257);
            dtgKhuyenMai.TabIndex = 9;
            // 
            // cbbLoaiSPKM
            // 
            cbbLoaiSPKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbLoaiSPKM.FormattingEnabled = true;
            cbbLoaiSPKM.Location = new Point(470, 615);
            cbbLoaiSPKM.Name = "cbbLoaiSPKM";
            cbbLoaiSPKM.Size = new Size(201, 39);
            cbbLoaiSPKM.TabIndex = 14;
            // 
            // btnTimSPKm
            // 
            btnTimSPKm.BackColor = Color.FromArgb(255, 192, 192);
            btnTimSPKm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimSPKm.Location = new Point(330, 614);
            btnTimSPKm.Name = "btnTimSPKm";
            btnTimSPKm.Size = new Size(134, 38);
            btnTimSPKm.TabIndex = 13;
            btnTimSPKm.Text = "Tìm";
            btnTimSPKm.UseVisualStyleBackColor = false;
            // 
            // txt_TenSpKM
            // 
            txt_TenSpKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenSpKM.Location = new Point(13, 614);
            txt_TenSpKM.Name = "txt_TenSpKM";
            txt_TenSpKM.Size = new Size(300, 38);
            txt_TenSpKM.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label12.Location = new Point(470, 560);
            label12.Name = "label12";
            label12.Size = new Size(174, 31);
            label12.TabIndex = 11;
            label12.Text = "Loại sản phẩm:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label13.Location = new Point(13, 560);
            label13.Name = "label13";
            label13.Size = new Size(166, 31);
            label13.TabIndex = 10;
            label13.Text = "Tên sản phẩm:";
            // 
            // dtgSanPhamKm
            // 
            dtgSanPhamKm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSanPhamKm.Location = new Point(13, 675);
            dtgSanPhamKm.Name = "dtgSanPhamKm";
            dtgSanPhamKm.RowHeadersWidth = 51;
            dtgSanPhamKm.Size = new Size(823, 289);
            dtgSanPhamKm.TabIndex = 15;
            // 
            // dateNgayBatDauKM
            // 
            dateNgayBatDauKM.Font = new Font("Segoe UI", 13.8F);
            dateNgayBatDauKM.Location = new Point(225, 664);
            dateNgayBatDauKM.Name = "dateNgayBatDauKM";
            dateNgayBatDauKM.Size = new Size(483, 38);
            dateNgayBatDauKM.TabIndex = 20;
            // 
            // dateNgayKetThucKm
            // 
            dateNgayKetThucKm.Font = new Font("Segoe UI", 13.8F);
            dateNgayKetThucKm.Location = new Point(225, 735);
            dateNgayKetThucKm.Name = "dateNgayKetThucKm";
            dateNgayKetThucKm.Size = new Size(483, 38);
            dateNgayKetThucKm.TabIndex = 21;
            // 
            // Frm_KhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_KhuyenMai";
            Text = "Khuyến mại";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKhuyenMai).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgSanPhamKm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button btn_CapNhatKm;
        private TextBox txt_GiaTriKM;
        private Button btn_ThemKM;
        private Label label10;
        private ComboBox cbb_TrangThaiKM;
        private ComboBox cbb_LoaiKM;
        private TextBox txt_TenKM;
        private TextBox txt_MaKM;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox ptb_TaiKhoan;
        private Panel panel2;
        private DataGridView dtgKhuyenMai;
        private Label label11;
        private ComboBox cbb_TrangThaiKMTimKiem;
        private ComboBox cbb_LoaiKMTimKiem;
        private Button btn_TimKM;
        private TextBox txt_TenKMTimKiem;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker dateNgayKetThucKm;
        private DateTimePicker dateNgayBatDauKM;
        private DataGridView dtgSanPhamKm;
        private ComboBox cbbLoaiSPKM;
        private Button btnTimSPKm;
        private TextBox txt_TenSpKM;
        private Label label12;
        private Label label13;
    }
}