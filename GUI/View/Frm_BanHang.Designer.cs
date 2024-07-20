namespace GUI.View
{
	partial class Frm_BanHang
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
            cbb_SanPham = new ComboBox();
            btn_TimSanPham = new Button();
            txt_TimSanPham = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dtg_TaoHoaDon = new DataGridView();
            btn_SuaHoaDon = new Button();
            btn_TaoHoaDon = new Button();
            panel4 = new Panel();
            btn_TachHoaDon = new Button();
            btn_ThanhToan = new Button();
            button1 = new Button();
            txtTienThua = new TextBox();
            txt_TienKhachTra = new TextBox();
            cbb_LoaiThanhToan = new ComboBox();
            cbb_ListBan = new ComboBox();
            txt_TongTienHoaDon = new TextBox();
            txt_TongTienSP = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            dtg_HoaDonCho = new DataGridView();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_TaoHoaDon).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDonCho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbb_SanPham);
            panel1.Controls.Add(btn_TimSanPham);
            panel1.Controls.Add(txt_TimSanPham);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 90);
            panel1.TabIndex = 1;
            // 
            // cbb_SanPham
            // 
            cbb_SanPham.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_SanPham.FormattingEnabled = true;
            cbb_SanPham.Location = new Point(594, 37);
            cbb_SanPham.Name = "cbb_SanPham";
            cbb_SanPham.Size = new Size(216, 39);
            cbb_SanPham.TabIndex = 4;
            // 
            // btn_TimSanPham
            // 
            btn_TimSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btn_TimSanPham.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimSanPham.Location = new Point(475, 38);
            btn_TimSanPham.Name = "btn_TimSanPham";
            btn_TimSanPham.Size = new Size(94, 38);
            btn_TimSanPham.TabIndex = 3;
            btn_TimSanPham.Text = "Tìm";
            btn_TimSanPham.UseVisualStyleBackColor = false;
            // 
            // txt_TimSanPham
            // 
            txt_TimSanPham.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TimSanPham.Location = new Point(9, 38);
            txt_TimSanPham.Name = "txt_TimSanPham";
            txt_TimSanPham.Size = new Size(441, 38);
            txt_TimSanPham.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(594, 7);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 1;
            label2.Text = "Loại sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtg_TaoHoaDon);
            panel2.Controls.Add(btn_SuaHoaDon);
            panel2.Controls.Add(btn_TaoHoaDon);
            panel2.Location = new Point(822, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 481);
            panel2.TabIndex = 2;
            // 
            // dtg_TaoHoaDon
            // 
            dtg_TaoHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_TaoHoaDon.Location = new Point(6, 54);
            dtg_TaoHoaDon.Name = "dtg_TaoHoaDon";
            dtg_TaoHoaDon.RowHeadersWidth = 51;
            dtg_TaoHoaDon.Size = new Size(772, 421);
            dtg_TaoHoaDon.TabIndex = 2;
            // 
            // btn_SuaHoaDon
            // 
            btn_SuaHoaDon.BackColor = Color.FromArgb(255, 192, 192);
            btn_SuaHoaDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SuaHoaDon.Location = new Point(681, 10);
            btn_SuaHoaDon.Name = "btn_SuaHoaDon";
            btn_SuaHoaDon.Size = new Size(94, 38);
            btn_SuaHoaDon.TabIndex = 1;
            btn_SuaHoaDon.Text = "Sửa";
            btn_SuaHoaDon.UseVisualStyleBackColor = false;
            // 
            // btn_TaoHoaDon
            // 
            btn_TaoHoaDon.BackColor = Color.FromArgb(255, 192, 192);
            btn_TaoHoaDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TaoHoaDon.Location = new Point(581, 10);
            btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            btn_TaoHoaDon.Size = new Size(94, 38);
            btn_TaoHoaDon.TabIndex = 0;
            btn_TaoHoaDon.Text = "Tạo";
            btn_TaoHoaDon.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_TachHoaDon);
            panel4.Controls.Add(btn_ThanhToan);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(txtTienThua);
            panel4.Controls.Add(txt_TienKhachTra);
            panel4.Controls.Add(cbb_LoaiThanhToan);
            panel4.Controls.Add(cbb_ListBan);
            panel4.Controls.Add(txt_TongTienHoaDon);
            panel4.Controls.Add(txt_TongTienSP);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(822, 489);
            panel4.Name = "panel4";
            panel4.Size = new Size(782, 487);
            panel4.TabIndex = 4;
            // 
            // btn_TachHoaDon
            // 
            btn_TachHoaDon.BackColor = Color.FromArgb(255, 192, 192);
            btn_TachHoaDon.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TachHoaDon.Location = new Point(285, 337);
            btn_TachHoaDon.Name = "btn_TachHoaDon";
            btn_TachHoaDon.Size = new Size(220, 122);
            btn_TachHoaDon.TabIndex = 14;
            btn_TachHoaDon.Text = "Tách hóa đơn";
            btn_TachHoaDon.UseVisualStyleBackColor = false;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.FromArgb(255, 192, 192);
            btn_ThanhToan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThanhToan.Location = new Point(546, 337);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(220, 122);
            btn_ThanhToan.TabIndex = 13;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(18, 337);
            button1.Name = "button1";
            button1.Size = new Size(220, 122);
            button1.TabIndex = 12;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtTienThua
            // 
            txtTienThua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTienThua.Location = new Point(581, 199);
            txtTienThua.Name = "txtTienThua";
            txtTienThua.Size = new Size(194, 38);
            txtTienThua.TabIndex = 11;
            // 
            // txt_TienKhachTra
            // 
            txt_TienKhachTra.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_TienKhachTra.Location = new Point(244, 199);
            txt_TienKhachTra.Name = "txt_TienKhachTra";
            txt_TienKhachTra.Size = new Size(203, 38);
            txt_TienKhachTra.TabIndex = 10;
            // 
            // cbb_LoaiThanhToan
            // 
            cbb_LoaiThanhToan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbb_LoaiThanhToan.FormattingEnabled = true;
            cbb_LoaiThanhToan.Location = new Point(244, 267);
            cbb_LoaiThanhToan.Name = "cbb_LoaiThanhToan";
            cbb_LoaiThanhToan.Size = new Size(531, 39);
            cbb_LoaiThanhToan.TabIndex = 9;
            // 
            // cbb_ListBan
            // 
            cbb_ListBan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbb_ListBan.FormattingEnabled = true;
            cbb_ListBan.Location = new Point(244, 134);
            cbb_ListBan.Name = "cbb_ListBan";
            cbb_ListBan.Size = new Size(531, 39);
            cbb_ListBan.TabIndex = 8;
            // 
            // txt_TongTienHoaDon
            // 
            txt_TongTienHoaDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_TongTienHoaDon.Location = new Point(244, 71);
            txt_TongTienHoaDon.Name = "txt_TongTienHoaDon";
            txt_TongTienHoaDon.Size = new Size(531, 38);
            txt_TongTienHoaDon.TabIndex = 7;
            // 
            // txt_TongTienSP
            // 
            txt_TongTienSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_TongTienSP.Location = new Point(244, 9);
            txt_TongTienSP.Name = "txt_TongTienSP";
            txt_TongTienSP.Size = new Size(531, 38);
            txt_TongTienSP.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 142);
            label9.Name = "label9";
            label9.Size = new Size(61, 31);
            label9.TabIndex = 5;
            label9.Text = "Bàn:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 275);
            label8.Name = "label8";
            label8.Size = new Size(189, 31);
            label8.TabIndex = 4;
            label8.Text = "Loại thanh toán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(453, 202);
            label7.Name = "label7";
            label7.Size = new Size(122, 31);
            label7.TabIndex = 3;
            label7.Text = "Tiền thừa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 202);
            label6.Name = "label6";
            label6.Size = new Size(172, 31);
            label6.TabIndex = 2;
            label6.Text = "Tiền khách trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 78);
            label5.Name = "label5";
            label5.Size = new Size(218, 31);
            label5.TabIndex = 1;
            label5.Text = "Tổng tiền hóa đơn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 12);
            label4.Name = "label4";
            label4.Size = new Size(232, 31);
            label4.TabIndex = 0;
            label4.Text = "Tổng tiền sản phẩm:";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtg_HoaDonCho);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 650);
            panel5.Name = "panel5";
            panel5.Size = new Size(813, 326);
            panel5.TabIndex = 5;
            // 
            // dtg_HoaDonCho
            // 
            dtg_HoaDonCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HoaDonCho.Location = new Point(9, 41);
            dtg_HoaDonCho.Name = "dtg_HoaDonCho";
            dtg_HoaDonCho.RowHeadersWidth = 51;
            dtg_HoaDonCho.Size = new Size(793, 282);
            dtg_HoaDonCho.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 10);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 0;
            label3.Text = "Hóa đơn chờ:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(3, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(813, 546);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Frm_BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_BanHang";
            Text = "Bán hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_TaoHoaDon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDonCho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Panel panel2;
		private ComboBox cbb_SanPham;
		private Button btn_TimSanPham;
		private TextBox txt_TimSanPham;
		private Label label2;
		private Label label1;
		private Panel panel4;
		private Panel panel5;
		private Button btn_TaoHoaDon;
		private DataGridView dtg_HoaDonCho;
		private Label label3;
		private TableLayoutPanel tableLayoutPanel1;
		private Button btn_SuaHoaDon;
		private DataGridView dtg_TaoHoaDon;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private ComboBox cbb_ListBan;
		private TextBox txt_TongTienHoaDon;
		private TextBox txt_TongTienSP;
		private TextBox txtTienThua;
		private TextBox txt_TienKhachTra;
		private ComboBox cbb_LoaiThanhToan;
		private Button btn_ThanhToan;
		private Button button1;
		private Button btn_TachHoaDon;
	}
}