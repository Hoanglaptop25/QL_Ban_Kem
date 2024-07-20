namespace GUI.View
{
    partial class Frm_Login
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
            TextBox txtUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            panel1 = new Panel();
            btn_Login = new Button();
            radio_SavePass = new RadioButton();
            txtPassWord = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbClose = new Label();
            txtUser = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(255, 128, 128);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(94, 160);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Nhập tài khoản";
            txtUser.Size = new Size(180, 24);
            txtUser.TabIndex = 1;
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(radio_SavePass);
            panel1.Controls.Add(txtPassWord);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbClose);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(410, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 400);
            panel1.TabIndex = 0;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(255, 128, 128);
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderColor = Color.White;
            btn_Login.FlatAppearance.BorderSize = 2;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(71, 334);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(203, 45);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // radio_SavePass
            // 
            radio_SavePass.AutoSize = true;
            radio_SavePass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_SavePass.ForeColor = Color.White;
            radio_SavePass.Location = new Point(94, 280);
            radio_SavePass.Name = "radio_SavePass";
            radio_SavePass.Size = new Size(146, 27);
            radio_SavePass.TabIndex = 3;
            radio_SavePass.TabStop = true;
            radio_SavePass.Text = "Nhớ mật khẩu";
            radio_SavePass.UseVisualStyleBackColor = true;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.FromArgb(255, 128, 128);
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassWord.ForeColor = Color.White;
            txtPassWord.Location = new Point(94, 235);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.PlaceholderText = "Nhập mật khẩu";
            txtPassWord.Size = new Size(180, 24);
            txtPassWord.TabIndex = 2;
            txtPassWord.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(94, 258);
            label2.Name = "label2";
            label2.Size = new Size(180, 2);
            label2.TabIndex = 7;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(94, 183);
            label1.Name = "label1";
            label1.Size = new Size(180, 2);
            label1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 219);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = PRL.Properties.Resources.user;
            pictureBox2.Location = new Point(27, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbClose
            // 
            lbClose.AutoSize = true;
            lbClose.Cursor = Cursors.Hand;
            lbClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClose.Location = new Point(289, 0);
            lbClose.Name = "lbClose";
            lbClose.Size = new Size(21, 23);
            lbClose.TabIndex = 5;
            lbClose.Text = "X";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 400);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbClose;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtUser;
        private Label label1;
        private TextBox txtPassWord;
        private Label label2;
        private RadioButton radio_SavePass;
        private Button btn_Login;
    }
}