namespace GUI.View
{
    partial class Frm_HoaDon
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
            dtgHoaDonChiTiet = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            cbbTrangThaiHd = new ComboBox();
            dateDenNgay = new DateTimePicker();
            dateTuNgay = new DateTimePicker();
            btn_TimHoaDon = new Button();
            txt_TimHoaDon = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtgHoaDon = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDonChiTiet).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgHoaDonChiTiet);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(1585, 473);
            panel1.TabIndex = 1;
            // 
            // dtgHoaDonChiTiet
            // 
            dtgHoaDonChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoaDonChiTiet.Location = new Point(3, 76);
            dtgHoaDonChiTiet.Name = "dtgHoaDonChiTiet";
            dtgHoaDonChiTiet.RowHeadersWidth = 51;
            dtgHoaDonChiTiet.Size = new Size(1579, 390);
            dtgHoaDonChiTiet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(645, 17);
            label1.Name = "label1";
            label1.Size = new Size(301, 50);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn chi tiết";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(cbbTrangThaiHd);
            panel2.Controls.Add(dateDenNgay);
            panel2.Controls.Add(dateTuNgay);
            panel2.Controls.Add(btn_TimHoaDon);
            panel2.Controls.Add(txt_TimHoaDon);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtgHoaDon);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1585, 483);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1409, 67);
            button2.Name = "button2";
            button2.Size = new Size(156, 42);
            button2.TabIndex = 10;
            button2.Text = "Lọc";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // cbbTrangThaiHd
            // 
            cbbTrangThaiHd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbTrangThaiHd.FormattingEnabled = true;
            cbbTrangThaiHd.Location = new Point(1242, 65);
            cbbTrangThaiHd.Name = "cbbTrangThaiHd";
            cbbTrangThaiHd.Size = new Size(151, 45);
            cbbTrangThaiHd.TabIndex = 9;
            // 
            // dateDenNgay
            // 
            dateDenNgay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateDenNgay.Location = new Point(964, 66);
            dateDenNgay.Name = "dateDenNgay";
            dateDenNgay.Size = new Size(266, 27);
            dateDenNgay.TabIndex = 8;
            // 
            // dateTuNgay
            // 
            dateTuNgay.Location = new Point(677, 66);
            dateTuNgay.Name = "dateTuNgay";
            dateTuNgay.Size = new Size(266, 27);
            dateTuNgay.TabIndex = 7;
            // 
            // btn_TimHoaDon
            // 
            btn_TimHoaDon.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimHoaDon.Location = new Point(520, 66);
            btn_TimHoaDon.Name = "btn_TimHoaDon";
            btn_TimHoaDon.Size = new Size(145, 43);
            btn_TimHoaDon.TabIndex = 6;
            btn_TimHoaDon.Text = "Tìm";
            btn_TimHoaDon.UseVisualStyleBackColor = true;
            // 
            // txt_TimHoaDon
            // 
            txt_TimHoaDon.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TimHoaDon.Location = new Point(15, 66);
            txt_TimHoaDon.Name = "txt_TimHoaDon";
            txt_TimHoaDon.Size = new Size(490, 43);
            txt_TimHoaDon.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.Location = new Point(1235, 13);
            label5.Name = "label5";
            label5.Size = new Size(158, 38);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(964, 13);
            label4.Name = "label4";
            label4.Size = new Size(150, 38);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(677, 13);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(15, 13);
            label2.Name = "label2";
            label2.Size = new Size(185, 38);
            label2.TabIndex = 1;
            label2.Text = "Mã hóa đơn:";
            // 
            // dtgHoaDon
            // 
            dtgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoaDon.Location = new Point(3, 128);
            dtgHoaDon.Name = "dtgHoaDon";
            dtgHoaDon.RowHeadersWidth = 51;
            dtgHoaDon.Size = new Size(1579, 352);
            dtgHoaDon.TabIndex = 0;
            // 
            // Frm_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_HoaDon";
            Text = "Hóa đơn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDonChiTiet).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView dtgHoaDonChiTiet;
        private Panel panel2;
        private TextBox txt_TimHoaDon;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dtgHoaDon;
        private Button button2;
        private ComboBox cbbTrangThaiHd;
        private DateTimePicker dateDenNgay;
        private DateTimePicker dateTuNgay;
        private Button btn_TimHoaDon;
    }
}