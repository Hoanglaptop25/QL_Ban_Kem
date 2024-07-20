namespace GUI.View
{
    partial class Frm_DoanhThu
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
            label1 = new Label();
            panel1 = new Panel();
            cbbTrangThaiTk = new ComboBox();
            cbbLoaiSPThongKe = new ComboBox();
            date_DenNgayTK = new DateTimePicker();
            date_TuNgayTK = new DateTimePicker();
            btn_LocThongKe = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtgThongKeSanPham = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongKeSanPham).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(419, 60);
            label1.TabIndex = 0;
            label1.Text = "Thống kê doanh số";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbTrangThaiTk);
            panel1.Controls.Add(cbbLoaiSPThongKe);
            panel1.Controls.Add(date_DenNgayTK);
            panel1.Controls.Add(date_TuNgayTK);
            panel1.Controls.Add(btn_LocThongKe);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtgThongKeSanPham);
            panel1.Location = new Point(12, 590);
            panel1.Name = "panel1";
            panel1.Size = new Size(1585, 377);
            panel1.TabIndex = 1;
            // 
            // cbbTrangThaiTk
            // 
            cbbTrangThaiTk.Font = new Font("Segoe UI", 12F);
            cbbTrangThaiTk.FormattingEnabled = true;
            cbbTrangThaiTk.Location = new Point(1266, 235);
            cbbTrangThaiTk.Name = "cbbTrangThaiTk";
            cbbTrangThaiTk.Size = new Size(311, 36);
            cbbTrangThaiTk.TabIndex = 10;
            // 
            // cbbLoaiSPThongKe
            // 
            cbbLoaiSPThongKe.Font = new Font("Segoe UI", 12F);
            cbbLoaiSPThongKe.FormattingEnabled = true;
            cbbLoaiSPThongKe.Location = new Point(919, 235);
            cbbLoaiSPThongKe.Name = "cbbLoaiSPThongKe";
            cbbLoaiSPThongKe.Size = new Size(316, 36);
            cbbLoaiSPThongKe.TabIndex = 9;
            // 
            // date_DenNgayTK
            // 
            date_DenNgayTK.CalendarFont = new Font("Segoe UI", 9F);
            date_DenNgayTK.Font = new Font("Segoe UI", 12F);
            date_DenNgayTK.Location = new Point(1266, 122);
            date_DenNgayTK.Name = "date_DenNgayTK";
            date_DenNgayTK.Size = new Size(311, 34);
            date_DenNgayTK.TabIndex = 8;
            // 
            // date_TuNgayTK
            // 
            date_TuNgayTK.CalendarFont = new Font("Segoe UI", 9F);
            date_TuNgayTK.Font = new Font("Segoe UI", 12F);
            date_TuNgayTK.Location = new Point(919, 122);
            date_TuNgayTK.Name = "date_TuNgayTK";
            date_TuNgayTK.Size = new Size(316, 34);
            date_TuNgayTK.TabIndex = 7;
            // 
            // btn_LocThongKe
            // 
            btn_LocThongKe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LocThongKe.Location = new Point(1171, 287);
            btn_LocThongKe.Name = "btn_LocThongKe";
            btn_LocThongKe.Size = new Size(136, 73);
            btn_LocThongKe.TabIndex = 6;
            btn_LocThongKe.Text = "Lọc";
            btn_LocThongKe.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(1266, 185);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(919, 185);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 4;
            label5.Text = "Loại sản phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(1266, 65);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(919, 65);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 1;
            label2.Text = "Thống kê sản phẩm:";
            // 
            // dtgThongKeSanPham
            // 
            dtgThongKeSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgThongKeSanPham.Location = new Point(3, 65);
            dtgThongKeSanPham.Name = "dtgThongKeSanPham";
            dtgThongKeSanPham.RowHeadersWidth = 51;
            dtgThongKeSanPham.Size = new Size(888, 309);
            dtgThongKeSanPham.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(1585, 512);
            panel2.TabIndex = 2;
            // 
            // Frm_DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Frm_DoanhThu";
            Text = "Doanh thu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongKeSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Button btn_LocThongKe;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dtgThongKeSanPham;
        private ComboBox cbbTrangThaiTk;
        private ComboBox cbbLoaiSPThongKe;
        private DateTimePicker date_DenNgayTK;
        private DateTimePicker date_TuNgayTK;
        private Panel panel2;
    }
}