namespace GUI.View
{
    partial class Frm_SanPham
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
            rtb_MoTaSanPham = new RichTextBox();
            label5 = new Label();
            btn_CapNhatSanPham = new Button();
            txt_DonGia = new TextBox();
            btn_ThemSanPham = new Button();
            label10 = new Label();
            cbb_TrangThaiSP = new ComboBox();
            txt_SoLuongSP = new TextBox();
            cbb_LoaiSP = new ComboBox();
            txt_TenSP = new TextBox();
            txt_MaSP = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_TaiKhoan = new PictureBox();
            panel2 = new Panel();
            label11 = new Label();
            cbb_TrangThaiSPTimKiem = new ComboBox();
            cbb_LoaiSpTimKiem = new ComboBox();
            btn_TimSanPham = new Button();
            txt_TenSPTimKiem = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dtg_QuanLySP = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLySP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rtb_MoTaSanPham);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_CapNhatSanPham);
            panel1.Controls.Add(txt_DonGia);
            panel1.Controls.Add(btn_ThemSanPham);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbb_TrangThaiSP);
            panel1.Controls.Add(txt_SoLuongSP);
            panel1.Controls.Add(cbb_LoaiSP);
            panel1.Controls.Add(txt_TenSP);
            panel1.Controls.Add(txt_MaSP);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptb_TaiKhoan);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 974);
            panel1.TabIndex = 1;
            // 
            // rtb_MoTaSanPham
            // 
            rtb_MoTaSanPham.Location = new Point(225, 708);
            rtb_MoTaSanPham.Name = "rtb_MoTaSanPham";
            rtb_MoTaSanPham.Size = new Size(483, 77);
            rtb_MoTaSanPham.TabIndex = 20;
            rtb_MoTaSanPham.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(45, 801);
            label5.Name = "label5";
            label5.Size = new Size(128, 31);
            label5.TabIndex = 19;
            label5.Text = "Trạng thái:";
            // 
            // btn_CapNhatSanPham
            // 
            btn_CapNhatSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btn_CapNhatSanPham.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CapNhatSanPham.Location = new Point(405, 862);
            btn_CapNhatSanPham.Name = "btn_CapNhatSanPham";
            btn_CapNhatSanPham.Size = new Size(237, 85);
            btn_CapNhatSanPham.TabIndex = 17;
            btn_CapNhatSanPham.Text = "Cập nhật";
            btn_CapNhatSanPham.UseVisualStyleBackColor = false;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DonGia.Location = new Point(225, 588);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.Size = new Size(483, 38);
            txt_DonGia.TabIndex = 15;
            // 
            // btn_ThemSanPham
            // 
            btn_ThemSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btn_ThemSanPham.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThemSanPham.Location = new Point(96, 862);
            btn_ThemSanPham.Name = "btn_ThemSanPham";
            btn_ThemSanPham.Size = new Size(237, 85);
            btn_ThemSanPham.TabIndex = 16;
            btn_ThemSanPham.Text = "Thêm";
            btn_ThemSanPham.UseVisualStyleBackColor = false;
            btn_ThemSanPham.Click += btn_ThemSanPham_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.Location = new Point(45, 516);
            label10.Name = "label10";
            label10.Size = new Size(174, 31);
            label10.TabIndex = 14;
            label10.Text = "Loại sản phẩm:";
            // 
            // cbb_TrangThaiSP
            // 
            cbb_TrangThaiSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_TrangThaiSP.FormattingEnabled = true;
            cbb_TrangThaiSP.Location = new Point(225, 796);
            cbb_TrangThaiSP.Name = "cbb_TrangThaiSP";
            cbb_TrangThaiSP.Size = new Size(483, 39);
            cbb_TrangThaiSP.TabIndex = 13;
            // 
            // txt_SoLuongSP
            // 
            txt_SoLuongSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_SoLuongSP.Location = new Point(225, 657);
            txt_SoLuongSP.Name = "txt_SoLuongSP";
            txt_SoLuongSP.Size = new Size(483, 38);
            txt_SoLuongSP.TabIndex = 10;
            // 
            // cbb_LoaiSP
            // 
            cbb_LoaiSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_LoaiSP.FormattingEnabled = true;
            cbb_LoaiSP.Location = new Point(225, 513);
            cbb_LoaiSP.Name = "cbb_LoaiSP";
            cbb_LoaiSP.Size = new Size(483, 39);
            cbb_LoaiSP.TabIndex = 9;
            // 
            // txt_TenSP
            // 
            txt_TenSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenSP.Location = new Point(225, 440);
            txt_TenSP.Name = "txt_TenSP";
            txt_TenSP.Size = new Size(483, 38);
            txt_TenSP.TabIndex = 8;
            // 
            // txt_MaSP
            // 
            txt_MaSP.Enabled = false;
            txt_MaSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MaSP.Location = new Point(225, 364);
            txt_MaSP.Name = "txt_MaSP";
            txt_MaSP.Size = new Size(483, 38);
            txt_MaSP.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(45, 731);
            label6.Name = "label6";
            label6.Size = new Size(83, 31);
            label6.TabIndex = 6;
            label6.Text = "Mô tả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(45, 660);
            label4.Name = "label4";
            label4.Size = new Size(117, 31);
            label4.TabIndex = 4;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(45, 588);
            label3.Name = "label3";
            label3.Size = new Size(104, 31);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(45, 440);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(45, 367);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm:";
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
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cbb_TrangThaiSPTimKiem);
            panel2.Controls.Add(cbb_LoaiSpTimKiem);
            panel2.Controls.Add(btn_TimSanPham);
            panel2.Controls.Add(txt_TenSPTimKiem);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dtg_QuanLySP);
            panel2.Location = new Point(749, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 974);
            panel2.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(226, 51);
            label11.Name = "label11";
            label11.Size = new Size(411, 60);
            label11.TabIndex = 8;
            label11.Text = "Quản Lý Sản Phẩm";
            // 
            // cbb_TrangThaiSPTimKiem
            // 
            cbb_TrangThaiSPTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_TrangThaiSPTimKiem.FormattingEnabled = true;
            cbb_TrangThaiSPTimKiem.Location = new Point(677, 239);
            cbb_TrangThaiSPTimKiem.Name = "cbb_TrangThaiSPTimKiem";
            cbb_TrangThaiSPTimKiem.Size = new Size(159, 39);
            cbb_TrangThaiSPTimKiem.TabIndex = 7;
            // 
            // cbb_LoaiSpTimKiem
            // 
            cbb_LoaiSpTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_LoaiSpTimKiem.FormattingEnabled = true;
            cbb_LoaiSpTimKiem.Location = new Point(497, 239);
            cbb_LoaiSpTimKiem.Name = "cbb_LoaiSpTimKiem";
            cbb_LoaiSpTimKiem.Size = new Size(174, 39);
            cbb_LoaiSpTimKiem.TabIndex = 6;
            // 
            // btn_TimSanPham
            // 
            btn_TimSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btn_TimSanPham.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimSanPham.Location = new Point(330, 238);
            btn_TimSanPham.Name = "btn_TimSanPham";
            btn_TimSanPham.Size = new Size(155, 38);
            btn_TimSanPham.TabIndex = 5;
            btn_TimSanPham.Text = "Tìm";
            btn_TimSanPham.UseVisualStyleBackColor = false;
            // 
            // txt_TenSPTimKiem
            // 
            txt_TenSPTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenSPTimKiem.Location = new Point(13, 238);
            txt_TenSPTimKiem.Name = "txt_TenSPTimKiem";
            txt_TenSPTimKiem.Size = new Size(300, 38);
            txt_TenSPTimKiem.TabIndex = 4;
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
            label8.Location = new Point(497, 184);
            label8.Name = "label8";
            label8.Size = new Size(174, 31);
            label8.TabIndex = 2;
            label8.Text = "Loại sản phẩm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(13, 184);
            label7.Name = "label7";
            label7.Size = new Size(166, 31);
            label7.TabIndex = 1;
            label7.Text = "Tên sản phẩm:";
            // 
            // dtg_QuanLySP
            // 
            dtg_QuanLySP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_QuanLySP.Location = new Point(3, 324);
            dtg_QuanLySP.Name = "dtg_QuanLySP";
            dtg_QuanLySP.RowHeadersWidth = 51;
            dtg_QuanLySP.Size = new Size(842, 647);
            dtg_QuanLySP.TabIndex = 0;
            // 
            // Frm_SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_SanPham";
            Text = "Sản phẩm";
            Load += Frm_SanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLySP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Button btn_CapNhatSanPham;
		private Button btn_ThemSanPham;
		private Label label10;
		private ComboBox cbb_TrangThaiSP;
		private TextBox txt_SoLuongSP;
		private ComboBox cbb_LoaiSP;
		private TextBox txt_TenSP;
		private TextBox txt_MaSP;
		private Label label6;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private PictureBox ptb_TaiKhoan;
		private TextBox txt_DonGia;
		private Label label5;
		private Panel panel2;
		private Label label11;
		private ComboBox cbb_TrangThaiSPTimKiem;
		private ComboBox cbb_LoaiSpTimKiem;
		private Button btn_TimSanPham;
		private TextBox txt_TenSPTimKiem;
		private Label label9;
		private Label label8;
		private Label label7;
		private DataGridView dtg_QuanLySP;
		private RichTextBox rtb_MoTaSanPham;
	}
}