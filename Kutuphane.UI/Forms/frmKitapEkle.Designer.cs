namespace Kutuphane.UI.Forms
{
    partial class frmKitapEkle
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
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            turuCombo = new ComboBox();
            kaydetBtn = new Button();
            isbnTxt = new TextBox();
            kitapAdiTxt = new TextBox();
            yazarTxt = new TextBox();
            yayinEviTxt = new TextBox();
            basimYiliTxt = new TextBox();
            baskiTxt = new TextBox();
            silBtn = new Button();
            guncelleBtn = new Button();
            temizleBtn = new Button();
            kitaplarDgv = new DataGridView();
            panel1 = new Panel();
            yenileBtn = new Button();
            label10 = new Label();
            kitapIsmiTxt = new TextBox();
            label9 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(30, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 40);
            panel2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 5;
            label2.Text = "Kitap Ekle";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(46, 86);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 14;
            label1.Text = "ISBN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(45, 129);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 15;
            label3.Text = "Kitap Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(46, 177);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 16;
            label4.Text = "Yazar :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(46, 219);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 17;
            label5.Text = "Yayınevi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(503, 86);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 18;
            label6.Text = "Basım Yılı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(503, 132);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 19;
            label7.Text = "Baskı : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(503, 179);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 20;
            label8.Text = "Türü : ";
            // 
            // turuCombo
            // 
            turuCombo.FormattingEnabled = true;
            turuCombo.Items.AddRange(new object[] { "Roman", "Öykü", "Novella", "Klasik roman", "Dram", "Polisiye", "Dedektif romanı", "Gerilim", "Psikolojik gerilim", "Korku", "Fantastik", "Epik fantezi", "Karanlık fantezi", "Bilimkurgu", "Distopya", "Ütopya", "Siberpunk", "Steampunk", "Tarihi kurgu", "Romantik kurgu", "Dram-romantik", "Aksiyon-macera", "Genç yetişkin ", "Çocuk edebiyatı", "Masal", "Mitoloji uyarlamaları", "Folklor", "Absürd kurgu", "Sürreal kurgu", "Gotik edebiyat", "Parodi", "Mizah kurgu", "Savaş temalı kurgu", "Suç romanı", "Casusluk romanı", "Aile draması", "Deneysel edebiyat", "Tarih", "Dünya tarihi", "Osmanlı tarihi", "Avrupa tarihi", "Savaş tarihçiliği", "Arkeoloji", "Antropoloji", "Sosyoloji", "Psikoloji", "Klinik psikoloji", "Popüler psikoloji", "Felsefe", "Etik", "Mantık", "Din / İlahiyat", "Mitoloji", "Bilim (genel)", "Fizik", "Kimya", "Biyoloji", "Genetik", "Evrim", "Astronomi", "Astrofizik", "Jeoloji", "Çevre bilimi", "Ekoloji", "Matematik", "Uygulamalı matematik", "İstatistik", "Ekonomi", "Finans", "Muhasebe", "İşletme", "Girişimcilik", "Pazarlama", "Yönetim", "Kişisel gelişim", "Liderlik", "Üretkenlik", "Kariyer gelişimi", "Eğitim", "Dil öğrenimi", "Dilbilim", "Siyaset", "Uluslararası ilişkiler", "Hukuk", "Ceza hukuku", "Medeni hukuk", "Tıp", "Hemşirelik", "Diş hekimliği", "Sağlık bilimler", "Spor bilimi", "Beslenme", "Diyet kitapları", "Yemek kitapları", "Rehber kitaplar", "El sanatları", "Hobi kitapları", "Sanat tarihi", "Resim", "Heykel", "Fotoğrafçılık", "Mimarlık", "Tasarım", "Moda", "Kültür araştırmaları", "Gezi kitapları", "Anı", "Günlük", "Otobiyografi", "Biyografi", "Mektuplar", "Deneme", "Eleştiri", "Araştırma–inceleme", "Bilgisayar bilimi", "Yazılım geliştirme", "Veri bilimi", "Veri tabanı", "Siber güvenlik", "Ağ teknolojileri", "Yapay zekâ", "Mühendislik (genel)", "Elektrik–Elektronik", "Makine mühendisliği", "İnşaat mühendisliği", "Endüstri mühendisliği", "Mimarlık mühendisliği", "Eğitim bilimleri", "Medya çalışmaları", "İletişim", "Gazetecilik", "Sosyal hizmet", "Hukuki araştırmalar", "Laboratuvar kitapları", "Teknik çizim", "Mesleki eğitim kitapları", "Ansiklopedi", "Sözlük", "Atlas", "Katalog", "Referans kitapları", "Çizgi roman", "Manga", "Grafik roman", "Boyama kitapları", "Test kitapları", "Sınav hazırlık kitapları (YKS, KPSS vb.)", "Akademik makale derlemeleri", "Konferans bildirileri", "Kütüphane arşiv belgeleri" });
            turuCombo.Location = new Point(589, 177);
            turuCombo.Name = "turuCombo";
            turuCombo.Size = new Size(208, 25);
            turuCombo.TabIndex = 21;
            // 
            // kaydetBtn
            // 
            kaydetBtn.BackColor = Color.Navy;
            kaydetBtn.FlatAppearance.BorderSize = 0;
            kaydetBtn.FlatStyle = FlatStyle.Flat;
            kaydetBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kaydetBtn.ForeColor = SystemColors.ButtonHighlight;
            kaydetBtn.Location = new Point(874, 84);
            kaydetBtn.Name = "kaydetBtn";
            kaydetBtn.Size = new Size(114, 49);
            kaydetBtn.TabIndex = 22;
            kaydetBtn.Text = "Kaydet";
            kaydetBtn.UseVisualStyleBackColor = false;
            kaydetBtn.Click += kaydetBtn_Click;
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(126, 84);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(208, 25);
            isbnTxt.TabIndex = 26;
            // 
            // kitapAdiTxt
            // 
            kitapAdiTxt.Location = new Point(126, 128);
            kitapAdiTxt.Name = "kitapAdiTxt";
            kitapAdiTxt.Size = new Size(208, 25);
            kitapAdiTxt.TabIndex = 27;
            // 
            // yazarTxt
            // 
            yazarTxt.Location = new Point(126, 174);
            yazarTxt.Name = "yazarTxt";
            yazarTxt.Size = new Size(208, 25);
            yazarTxt.TabIndex = 28;
            // 
            // yayinEviTxt
            // 
            yayinEviTxt.Location = new Point(126, 218);
            yayinEviTxt.Name = "yayinEviTxt";
            yayinEviTxt.Size = new Size(208, 25);
            yayinEviTxt.TabIndex = 29;
            // 
            // basimYiliTxt
            // 
            basimYiliTxt.Location = new Point(589, 84);
            basimYiliTxt.Name = "basimYiliTxt";
            basimYiliTxt.Size = new Size(208, 25);
            basimYiliTxt.TabIndex = 30;
            // 
            // baskiTxt
            // 
            baskiTxt.Location = new Point(589, 132);
            baskiTxt.Name = "baskiTxt";
            baskiTxt.Size = new Size(208, 25);
            baskiTxt.TabIndex = 31;
            // 
            // silBtn
            // 
            silBtn.BackColor = Color.Navy;
            silBtn.FlatAppearance.BorderSize = 0;
            silBtn.FlatStyle = FlatStyle.Flat;
            silBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            silBtn.ForeColor = SystemColors.ButtonHighlight;
            silBtn.Location = new Point(874, 163);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(114, 49);
            silBtn.TabIndex = 32;
            silBtn.Text = "Sil";
            silBtn.UseVisualStyleBackColor = false;
            // 
            // guncelleBtn
            // 
            guncelleBtn.BackColor = Color.Navy;
            guncelleBtn.FlatAppearance.BorderSize = 0;
            guncelleBtn.FlatStyle = FlatStyle.Flat;
            guncelleBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guncelleBtn.ForeColor = SystemColors.ButtonHighlight;
            guncelleBtn.Location = new Point(1021, 84);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(110, 49);
            guncelleBtn.TabIndex = 33;
            guncelleBtn.Text = "Güncelle";
            guncelleBtn.UseVisualStyleBackColor = false;
            guncelleBtn.Click += guncelleBtn_Click_1;
            // 
            // temizleBtn
            // 
            temizleBtn.BackColor = Color.Navy;
            temizleBtn.FlatAppearance.BorderSize = 0;
            temizleBtn.FlatStyle = FlatStyle.Flat;
            temizleBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temizleBtn.ForeColor = SystemColors.ButtonHighlight;
            temizleBtn.Location = new Point(1021, 161);
            temizleBtn.Name = "temizleBtn";
            temizleBtn.Size = new Size(110, 49);
            temizleBtn.TabIndex = 34;
            temizleBtn.Text = "Temizle";
            temizleBtn.UseVisualStyleBackColor = false;
            // 
            // kitaplarDgv
            // 
            kitaplarDgv.BackgroundColor = Color.AliceBlue;
            kitaplarDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kitaplarDgv.GridColor = SystemColors.HotTrack;
            kitaplarDgv.Location = new Point(46, 366);
            kitaplarDgv.Name = "kitaplarDgv";
            kitaplarDgv.RowHeadersWidth = 45;
            kitaplarDgv.Size = new Size(1099, 457);
            kitaplarDgv.TabIndex = 35;
            kitaplarDgv.CellDoubleClick += kitaplarDgv_CellDoubleClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(yenileBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(kitapIsmiTxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(30, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 40);
            panel1.TabIndex = 14;
            // 
            // yenileBtn
            // 
            yenileBtn.BackColor = Color.FromArgb(18, 18, 24);
            yenileBtn.FlatAppearance.BorderSize = 0;
            yenileBtn.FlatStyle = FlatStyle.Flat;
            yenileBtn.Font = new Font("Nirmala UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yenileBtn.ForeColor = SystemColors.ButtonHighlight;
            yenileBtn.Location = new Point(652, 6);
            yenileBtn.Name = "yenileBtn";
            yenileBtn.Size = new Size(76, 29);
            yenileBtn.TabIndex = 36;
            yenileBtn.Text = "Yenile";
            yenileBtn.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(379, 10);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 7;
            label10.Text = "Kitap İsmi : ";
            // 
            // kitapIsmiTxt
            // 
            kitapIsmiTxt.Location = new Point(468, 9);
            kitapIsmiTxt.Name = "kitapIsmiTxt";
            kitapIsmiTxt.Size = new Size(168, 25);
            kitapIsmiTxt.TabIndex = 6;
            kitapIsmiTxt.TextChanged += kitapIsmiTxt_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 5;
            label9.Text = "Kitaplar";
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
            // frmKitapEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(panel1);
            Controls.Add(kitaplarDgv);
            Controls.Add(temizleBtn);
            Controls.Add(guncelleBtn);
            Controls.Add(silBtn);
            Controls.Add(baskiTxt);
            Controls.Add(basimYiliTxt);
            Controls.Add(yayinEviTxt);
            Controls.Add(yazarTxt);
            Controls.Add(kitapAdiTxt);
            Controls.Add(isbnTxt);
            Controls.Add(kaydetBtn);
            Controls.Add(turuCombo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKitapEkle";
            Text = "frmKitapEkle";
            Load += frmKitapEkle_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button button2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox turuCombo;
        private Button kaydetBtn;
        private TextBox isbnTxt;
        private TextBox kitapAdiTxt;
        private TextBox yazarTxt;
        private TextBox yayinEviTxt;
        private TextBox basimYiliTxt;
        private TextBox baskiTxt;
        private Button silBtn;
        private Button guncelleBtn;
        private Button temizleBtn;
        private DataGridView kitaplarDgv;
        private Panel panel1;
        private Label label9;
        private Button button1;
        private Button yenileBtn;
        private Label label10;
        private TextBox kitapIsmiTxt;
    }
}