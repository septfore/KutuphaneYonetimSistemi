namespace Kutuphane.UI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            kullaniciAdiTxt = new TextBox();
            pictureBox3 = new PictureBox();
            sifreTxt = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            xBtn = new Button();
            girisYapBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(67, 261);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // kullaniciAdiTxt
            // 
            kullaniciAdiTxt.BackColor = Color.AliceBlue;
            kullaniciAdiTxt.BorderStyle = BorderStyle.None;
            kullaniciAdiTxt.Font = new Font("Microsoft YaHei UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kullaniciAdiTxt.ForeColor = Color.Navy;
            kullaniciAdiTxt.Location = new Point(140, 274);
            kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            kullaniciAdiTxt.Size = new Size(252, 20);
            kullaniciAdiTxt.TabIndex = 2;
            kullaniciAdiTxt.Text = "Kullanıcı Numarası";
            kullaniciAdiTxt.MouseClick += kullaniciAdiTxt_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(67, 349);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // sifreTxt
            // 
            sifreTxt.BackColor = Color.AliceBlue;
            sifreTxt.BorderStyle = BorderStyle.None;
            sifreTxt.Font = new Font("Microsoft YaHei UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreTxt.ForeColor = Color.Navy;
            sifreTxt.Location = new Point(140, 359);
            sifreTxt.Name = "sifreTxt";
            sifreTxt.Size = new Size(252, 20);
            sifreTxt.TabIndex = 4;
            sifreTxt.Text = "Şifre";
            sifreTxt.MouseClick += sifreTxt_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Location = new Point(140, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 5);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(140, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 5);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(xBtn);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 46);
            panel3.TabIndex = 7;
            // 
            // xBtn
            // 
            xBtn.BackColor = Color.White;
            xBtn.FlatAppearance.BorderSize = 0;
            xBtn.FlatStyle = FlatStyle.Flat;
            xBtn.Font = new Font("Segoe UI Black", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 162);
            xBtn.ForeColor = Color.Navy;
            xBtn.Location = new Point(423, 5);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(38, 33);
            xBtn.TabIndex = 0;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = false;
            xBtn.Click += xBtn_Click;
            // 
            // girisYapBtn
            // 
            girisYapBtn.BackColor = Color.Navy;
            girisYapBtn.FlatAppearance.BorderSize = 0;
            girisYapBtn.FlatStyle = FlatStyle.Flat;
            girisYapBtn.Font = new Font("Microsoft YaHei", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisYapBtn.ForeColor = SystemColors.ButtonHighlight;
            girisYapBtn.Location = new Point(116, 466);
            girisYapBtn.Name = "girisYapBtn";
            girisYapBtn.Size = new Size(237, 48);
            girisYapBtn.TabIndex = 8;
            girisYapBtn.Text = "Giriş Yap";
            girisYapBtn.UseVisualStyleBackColor = false;
            girisYapBtn.Click += girisYapBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(473, 591);
            Controls.Add(girisYapBtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sifreTxt);
            Controls.Add(pictureBox3);
            Controls.Add(kullaniciAdiTxt);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox kullaniciAdiTxt;
        private PictureBox pictureBox3;
        private TextBox sifreTxt;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button xBtn;
        private Button girisYapBtn;
    }
}