namespace Kutuphane.UI.Forms
{
    partial class frmUyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeEkle));
            panel1 = new Panel();
            yenileBtn = new Button();
            label10 = new Label();
            kulNoAraTxt = new TextBox();
            label9 = new Label();
            button1 = new Button();
            uyelerDgv = new DataGridView();
            temizleBtn = new Button();
            guncelleBtn = new Button();
            silBtn = new Button();
            sifreTxt = new TextBox();
            kulNoTxt = new TextBox();
            ePostaTxt = new TextBox();
            telNoTxt = new TextBox();
            kulSoyadiTxt = new TextBox();
            kulAdiTxt = new TextBox();
            kaydetBtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            label8 = new Label();
            uyelikTarihiDtp = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uyelerDgv).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(yenileBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(kulNoAraTxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(32, 312);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 40);
            panel1.TabIndex = 38;
            // 
            // yenileBtn
            // 
            yenileBtn.BackColor = Color.FromArgb(18, 18, 24);
            yenileBtn.FlatAppearance.BorderSize = 0;
            yenileBtn.FlatStyle = FlatStyle.Flat;
            yenileBtn.Font = new Font("Nirmala UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yenileBtn.ForeColor = SystemColors.ButtonHighlight;
            yenileBtn.Image = (Image)resources.GetObject("yenileBtn.Image");
            yenileBtn.Location = new Point(652, 6);
            yenileBtn.Name = "yenileBtn";
            yenileBtn.Size = new Size(40, 29);
            yenileBtn.TabIndex = 36;
            yenileBtn.UseVisualStyleBackColor = false;
            yenileBtn.Click += yenileBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(319, 10);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 7;
            label10.Text = "Kullanıcı Numarası : ";
            // 
            // kulNoAraTxt
            // 
            kulNoAraTxt.Location = new Point(468, 9);
            kulNoAraTxt.Name = "kulNoAraTxt";
            kulNoAraTxt.Size = new Size(168, 25);
            kulNoAraTxt.TabIndex = 6;
            kulNoAraTxt.TextChanged += kulNoAraTxt_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(74, 25);
            label9.TabIndex = 5;
            label9.Text = "Üyeler";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 18, 24);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(0, 122, 255);
            button1.Location = new Point(1351, 7);
            button1.Name = "button1";
            button1.Size = new Size(38, 33);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // uyelerDgv
            // 
            uyelerDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uyelerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uyelerDgv.Location = new Point(48, 369);
            uyelerDgv.Name = "uyelerDgv";
            uyelerDgv.RowHeadersWidth = 45;
            uyelerDgv.Size = new Size(1099, 457);
            uyelerDgv.TabIndex = 56;
            uyelerDgv.CellClick += uyelerDgv_CellClick;
            // 
            // temizleBtn
            // 
            temizleBtn.BackColor = Color.Navy;
            temizleBtn.FlatAppearance.BorderSize = 0;
            temizleBtn.FlatStyle = FlatStyle.Flat;
            temizleBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temizleBtn.ForeColor = SystemColors.ButtonHighlight;
            temizleBtn.Location = new Point(1023, 164);
            temizleBtn.Name = "temizleBtn";
            temizleBtn.Size = new Size(110, 49);
            temizleBtn.TabIndex = 55;
            temizleBtn.Text = "Temizle";
            temizleBtn.UseVisualStyleBackColor = false;
            temizleBtn.Click += temizleBtn_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.BackColor = Color.Navy;
            guncelleBtn.FlatAppearance.BorderSize = 0;
            guncelleBtn.FlatStyle = FlatStyle.Flat;
            guncelleBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guncelleBtn.ForeColor = SystemColors.ButtonHighlight;
            guncelleBtn.Location = new Point(1023, 87);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(110, 49);
            guncelleBtn.TabIndex = 54;
            guncelleBtn.Text = "Güncelle";
            guncelleBtn.UseVisualStyleBackColor = false;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // silBtn
            // 
            silBtn.BackColor = Color.Navy;
            silBtn.FlatAppearance.BorderSize = 0;
            silBtn.FlatStyle = FlatStyle.Flat;
            silBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            silBtn.ForeColor = SystemColors.ButtonHighlight;
            silBtn.Location = new Point(876, 166);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(114, 49);
            silBtn.TabIndex = 53;
            silBtn.Text = "Sil";
            silBtn.UseVisualStyleBackColor = false;
            silBtn.Click += silBtn_Click;
            // 
            // sifreTxt
            // 
            sifreTxt.Location = new Point(606, 134);
            sifreTxt.Name = "sifreTxt";
            sifreTxt.Size = new Size(208, 25);
            sifreTxt.TabIndex = 52;
            // 
            // kulNoTxt
            // 
            kulNoTxt.Location = new Point(606, 87);
            kulNoTxt.Name = "kulNoTxt";
            kulNoTxt.Size = new Size(208, 25);
            kulNoTxt.TabIndex = 51;
            // 
            // ePostaTxt
            // 
            ePostaTxt.Location = new Point(178, 222);
            ePostaTxt.Name = "ePostaTxt";
            ePostaTxt.Size = new Size(208, 25);
            ePostaTxt.TabIndex = 50;
            // 
            // telNoTxt
            // 
            telNoTxt.Location = new Point(178, 180);
            telNoTxt.Name = "telNoTxt";
            telNoTxt.Size = new Size(208, 25);
            telNoTxt.TabIndex = 49;
            // 
            // kulSoyadiTxt
            // 
            kulSoyadiTxt.Location = new Point(178, 132);
            kulSoyadiTxt.Name = "kulSoyadiTxt";
            kulSoyadiTxt.Size = new Size(208, 25);
            kulSoyadiTxt.TabIndex = 48;
            // 
            // kulAdiTxt
            // 
            kulAdiTxt.Location = new Point(178, 88);
            kulAdiTxt.Name = "kulAdiTxt";
            kulAdiTxt.Size = new Size(208, 25);
            kulAdiTxt.TabIndex = 47;
            // 
            // kaydetBtn
            // 
            kaydetBtn.BackColor = Color.Navy;
            kaydetBtn.FlatAppearance.BorderSize = 0;
            kaydetBtn.FlatStyle = FlatStyle.Flat;
            kaydetBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kaydetBtn.ForeColor = SystemColors.ButtonHighlight;
            kaydetBtn.Location = new Point(876, 87);
            kaydetBtn.Name = "kaydetBtn";
            kaydetBtn.Size = new Size(114, 49);
            kaydetBtn.TabIndex = 46;
            kaydetBtn.Text = "Kaydet";
            kaydetBtn.UseVisualStyleBackColor = false;
            kaydetBtn.Click += kaydetBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(505, 135);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 43;
            label7.Text = "Şifre : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(505, 89);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 42;
            label6.Text = "Kullanıcı No : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(48, 222);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 41;
            label5.Text = "E-Posta :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(48, 180);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 40;
            label4.Text = "GSM No :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(47, 132);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 39;
            label3.Text = "Kullanıcı Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(48, 89);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 37;
            label1.Text = "Kullanıcı Adı :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(32, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 40);
            panel2.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 5;
            label2.Text = "Üye Ekle";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(18, 18, 24);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0, 122, 255);
            button2.Location = new Point(1351, 7);
            button2.Name = "button2";
            button2.Size = new Size(38, 33);
            button2.TabIndex = 2;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(505, 193);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 57;
            label8.Text = "Üyelik Tarihi :";
            // 
            // uyelikTarihiDtp
            // 
            uyelikTarihiDtp.CalendarTitleForeColor = Color.Navy;
            uyelikTarihiDtp.CalendarTrailingForeColor = Color.Navy;
            uyelikTarihiDtp.Location = new Point(606, 188);
            uyelikTarihiDtp.Name = "uyelikTarihiDtp";
            uyelikTarihiDtp.Size = new Size(208, 25);
            uyelikTarihiDtp.TabIndex = 58;
            // 
            // frmUyeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(uyelikTarihiDtp);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(uyelerDgv);
            Controls.Add(temizleBtn);
            Controls.Add(guncelleBtn);
            Controls.Add(silBtn);
            Controls.Add(sifreTxt);
            Controls.Add(kulNoTxt);
            Controls.Add(ePostaTxt);
            Controls.Add(telNoTxt);
            Controls.Add(kulSoyadiTxt);
            Controls.Add(kulAdiTxt);
            Controls.Add(kaydetBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            ForeColor = Color.LavenderBlush;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUyeEkle";
            Text = "frmUyeEkle";
            Load += frmUyeEkle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uyelerDgv).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button yenileBtn;
        private Label label10;
        private TextBox kulNoAraTxt;
        private Label label9;
        private Button button1;
        private DataGridView uyelerDgv;
        private Button temizleBtn;
        private Button guncelleBtn;
        private Button silBtn;
        private TextBox sifreTxt;
        private TextBox kulNoTxt;
        private TextBox ePostaTxt;
        private TextBox telNoTxt;
        private TextBox kulSoyadiTxt;
        private TextBox kulAdiTxt;
        private Button kaydetBtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button button2;
        private Label label8;
        private DateTimePicker uyelikTarihiDtp;
    }
}