namespace Kutuphane.UI.Forms
{
    partial class frmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            label4 = new Label();
            label3 = new Label();
            btnFiltrele = new Button();
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            panelGrafik = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            lblEnCokAlanSayi = new Label();
            lblEnCokAlan = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            lblGecikmeGun = new Label();
            lblEnGecKalan = new Label();
            label7 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            lblBuAy = new Label();
            lblToplamOdunx = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 327);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 17;
            label4.Text = "Bitiş Tarihi Seç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 327);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 16;
            label3.Text = "Başlangıç Tarihi Seç";
            // 
            // btnFiltrele
            // 
            btnFiltrele.BackColor = Color.RoyalBlue;
            btnFiltrele.FlatStyle = FlatStyle.Flat;
            btnFiltrele.ForeColor = Color.WhiteSmoke;
            btnFiltrele.Image = (Image)resources.GetObject("btnFiltrele.Image");
            btnFiltrele.ImageAlign = ContentAlignment.MiddleRight;
            btnFiltrele.Location = new Point(560, 346);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(94, 33);
            btnFiltrele.TabIndex = 15;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.TextAlign = ContentAlignment.MiddleLeft;
            btnFiltrele.UseVisualStyleBackColor = false;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(321, 347);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(221, 25);
            dtpBitis.TabIndex = 14;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.CalendarForeColor = Color.WhiteSmoke;
            dtpBaslangic.CalendarMonthBackground = Color.RoyalBlue;
            dtpBaslangic.CalendarTitleBackColor = Color.RoyalBlue;
            dtpBaslangic.CalendarTitleForeColor = Color.WhiteSmoke;
            dtpBaslangic.CalendarTrailingForeColor = Color.RoyalBlue;
            dtpBaslangic.Location = new Point(46, 347);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(221, 25);
            dtpBaslangic.TabIndex = 13;
            // 
            // panelGrafik
            // 
            panelGrafik.Location = new Point(46, 389);
            panelGrafik.Name = "panelGrafik";
            panelGrafik.Size = new Size(1070, 357);
            panelGrafik.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblEnCokAlanSayi);
            panel3.Controls.Add(lblEnCokAlan);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(424, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 179);
            panel3.TabIndex = 11;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(559, 260);
            button2.Name = "button2";
            button2.Size = new Size(41, 40);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(188, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblEnCokAlanSayi
            // 
            lblEnCokAlanSayi.AutoSize = true;
            lblEnCokAlanSayi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEnCokAlanSayi.ForeColor = Color.WhiteSmoke;
            lblEnCokAlanSayi.Location = new Point(23, 136);
            lblEnCokAlanSayi.Name = "lblEnCokAlanSayi";
            lblEnCokAlanSayi.Size = new Size(168, 19);
            lblEnCokAlanSayi.TabIndex = 7;
            lblEnCokAlanSayi.Text = "Bugüne kadar X kitap aldı.";
            // 
            // lblEnCokAlan
            // 
            lblEnCokAlan.AutoSize = true;
            lblEnCokAlan.Font = new Font("Segoe UI", 19.6981125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEnCokAlan.ForeColor = Color.WhiteSmoke;
            lblEnCokAlan.Location = new Point(14, 62);
            lblEnCokAlan.Name = "lblEnCokAlan";
            lblEnCokAlan.Size = new Size(34, 40);
            lblEnCokAlan.TabIndex = 7;
            lblEnCokAlan.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 4;
            label2.Text = "En Çok Kitap Alan";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(lblGecikmeGun);
            panel2.Controls.Add(lblEnGecKalan);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(800, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 179);
            panel2.TabIndex = 10;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(937, 260);
            button3.Name = "button3";
            button3.Size = new Size(41, 40);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(186, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // lblGecikmeGun
            // 
            lblGecikmeGun.AutoSize = true;
            lblGecikmeGun.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGecikmeGun.ForeColor = Color.WhiteSmoke;
            lblGecikmeGun.Location = new Point(17, 136);
            lblGecikmeGun.Name = "lblGecikmeGun";
            lblGecikmeGun.Size = new Size(89, 19);
            lblGecikmeGun.TabIndex = 8;
            lblGecikmeGun.Text = "x gün gecikti.";
            // 
            // lblEnGecKalan
            // 
            lblEnGecKalan.AutoSize = true;
            lblEnGecKalan.Font = new Font("Segoe UI", 19.6981125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEnGecKalan.ForeColor = Color.WhiteSmoke;
            lblEnGecKalan.Location = new Point(17, 62);
            lblEnGecKalan.Name = "lblEnGecKalan";
            lblEnGecKalan.Size = new Size(34, 40);
            lblEnGecKalan.TabIndex = 8;
            lblEnGecKalan.Text = "X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(17, 15);
            label7.Name = "label7";
            label7.Size = new Size(138, 21);
            label7.TabIndex = 8;
            label7.Text = "En Geç Kalan Kitap";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblBuAy);
            panel1.Controls.Add(lblToplamOdunx);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 179);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(177, 260);
            button1.Name = "button1";
            button1.Size = new Size(41, 40);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblBuAy
            // 
            lblBuAy.AutoSize = true;
            lblBuAy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBuAy.ForeColor = Color.WhiteSmoke;
            lblBuAy.Location = new Point(20, 136);
            lblBuAy.Name = "lblBuAy";
            lblBuAy.Size = new Size(128, 19);
            lblBuAy.TabIndex = 5;
            lblBuAy.Text = "Bu ay X kitap alındı.";
            // 
            // lblToplamOdunx
            // 
            lblToplamOdunx.AutoSize = true;
            lblToplamOdunx.Font = new Font("Segoe UI", 19.6981125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamOdunx.ForeColor = Color.WhiteSmoke;
            lblToplamOdunx.Location = new Point(20, 62);
            lblToplamOdunx.Name = "lblToplamOdunx";
            lblToplamOdunx.Size = new Size(34, 40);
            lblToplamOdunx.TabIndex = 4;
            lblToplamOdunx.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(195, 21);
            label1.TabIndex = 3;
            label1.Text = "Toplam Verilen Kitap Sayısı";
            // 
            // frmRaporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1163, 813);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnFiltrele);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(panelGrafik);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRaporlar";
            Text = "frmRaporlar";
            Load += frmRaporlar_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Button btnFiltrele;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private Panel panelGrafik;
        private Panel panel3;
        private Button button2;
        private PictureBox pictureBox2;
        private Label lblEnCokAlanSayi;
        private Label lblEnCokAlan;
        private Label label2;
        private Panel panel2;
        private Button button3;
        private PictureBox pictureBox3;
        private Label lblGecikmeGun;
        private Label lblEnGecKalan;
        private Label label7;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label lblBuAy;
        private Label lblToplamOdunx;
        private Label label1;
    }
}