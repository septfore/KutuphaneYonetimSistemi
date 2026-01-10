namespace Kutuphane.UI.Forms
{
    partial class frmKitapOduncVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapOduncVer));
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            yenileBtn = new Button();
            label10 = new Label();
            kitapIsmiTxt = new TextBox();
            label9 = new Label();
            button1 = new Button();
            kitaplarDgv = new DataGridView();
            baskiTxt = new TextBox();
            yayineviTxt = new TextBox();
            kitapAdiTxt = new TextBox();
            isbnTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            ogrYenileBtn = new Button();
            label6 = new Label();
            ogrNoAraTxt = new TextBox();
            label7 = new Label();
            button4 = new Button();
            uyelerDgv = new DataGridView();
            ePostaTxt = new TextBox();
            telNoTxt = new TextBox();
            kulNoTxt = new TextBox();
            kulAdiTxt = new TextBox();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            oduncVerBtn = new Button();
            oduncTarihiDtp = new DateTimePicker();
            label14 = new Label();
            teslimTarihiDtp = new DateTimePicker();
            label15 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgv).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uyelerDgv).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(30, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 40);
            panel2.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 5;
            label2.Text = "Ödünç Ver";
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
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(yenileBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(kitapIsmiTxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(30, 434);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 40);
            panel1.TabIndex = 15;
            // 
            // yenileBtn
            // 
            yenileBtn.BackColor = Color.FromArgb(18, 18, 24);
            yenileBtn.FlatAppearance.BorderSize = 0;
            yenileBtn.FlatStyle = FlatStyle.Flat;
            yenileBtn.Font = new Font("Nirmala UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yenileBtn.ForeColor = SystemColors.ButtonHighlight;
            yenileBtn.Image = (Image)resources.GetObject("yenileBtn.Image");
            yenileBtn.Location = new Point(406, 8);
            yenileBtn.Name = "yenileBtn";
            yenileBtn.Size = new Size(38, 29);
            yenileBtn.TabIndex = 36;
            yenileBtn.UseVisualStyleBackColor = false;
            yenileBtn.Click += yenileBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(133, 12);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 7;
            label10.Text = "Kitap İsmi : ";
            // 
            // kitapIsmiTxt
            // 
            kitapIsmiTxt.Location = new Point(222, 11);
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
            label9.Location = new Point(3, 7);
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
            // kitaplarDgv
            // 
            kitaplarDgv.BackgroundColor = Color.AliceBlue;
            kitaplarDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kitaplarDgv.GridColor = SystemColors.HotTrack;
            kitaplarDgv.Location = new Point(30, 492);
            kitaplarDgv.Name = "kitaplarDgv";
            kitaplarDgv.RowHeadersWidth = 45;
            kitaplarDgv.Size = new Size(517, 350);
            kitaplarDgv.TabIndex = 38;
            kitaplarDgv.CellClick += kitaplarDgv_CellClick;
            // 
            // baskiTxt
            // 
            baskiTxt.Location = new Point(110, 211);
            baskiTxt.Name = "baskiTxt";
            baskiTxt.Size = new Size(208, 25);
            baskiTxt.TabIndex = 46;
            // 
            // yayineviTxt
            // 
            yayineviTxt.Location = new Point(110, 167);
            yayineviTxt.Name = "yayineviTxt";
            yayineviTxt.Size = new Size(208, 25);
            yayineviTxt.TabIndex = 45;
            // 
            // kitapAdiTxt
            // 
            kitapAdiTxt.Location = new Point(110, 121);
            kitapAdiTxt.Name = "kitapAdiTxt";
            kitapAdiTxt.Size = new Size(208, 25);
            kitapAdiTxt.TabIndex = 44;
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(110, 77);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(208, 25);
            isbnTxt.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(29, 172);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 42;
            label5.Text = "Yayınevi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(30, 216);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 41;
            label4.Text = "Baskı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(29, 122);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 40;
            label3.Text = "Kitap Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(30, 79);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 39;
            label1.Text = "ISBN :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(ogrYenileBtn);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(ogrNoAraTxt);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(605, 434);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 40);
            panel3.TabIndex = 37;
            // 
            // ogrYenileBtn
            // 
            ogrYenileBtn.BackColor = Color.FromArgb(18, 18, 24);
            ogrYenileBtn.FlatAppearance.BorderSize = 0;
            ogrYenileBtn.FlatStyle = FlatStyle.Flat;
            ogrYenileBtn.Font = new Font("Nirmala UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ogrYenileBtn.ForeColor = SystemColors.ButtonHighlight;
            ogrYenileBtn.Image = (Image)resources.GetObject("ogrYenileBtn.Image");
            ogrYenileBtn.Location = new Point(406, 8);
            ogrYenileBtn.Name = "ogrYenileBtn";
            ogrYenileBtn.Size = new Size(38, 29);
            ogrYenileBtn.TabIndex = 36;
            ogrYenileBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(133, 12);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 7;
            label6.Text = "Kullanıcı No : ";
            // 
            // ogrNoAraTxt
            // 
            ogrNoAraTxt.Location = new Point(232, 11);
            ogrNoAraTxt.Name = "ogrNoAraTxt";
            ogrNoAraTxt.Size = new Size(168, 25);
            ogrNoAraTxt.TabIndex = 6;
            ogrNoAraTxt.TextChanged += ogrNoAraTxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(10, 7);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 5;
            label7.Text = "Kullanıcılar";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(18, 18, 24);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(0, 122, 255);
            button4.Location = new Point(1351, 7);
            button4.Name = "button4";
            button4.Size = new Size(38, 33);
            button4.TabIndex = 2;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            // 
            // uyelerDgv
            // 
            uyelerDgv.BackgroundColor = Color.AliceBlue;
            uyelerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uyelerDgv.Location = new Point(605, 492);
            uyelerDgv.Name = "uyelerDgv";
            uyelerDgv.RowHeadersWidth = 45;
            uyelerDgv.Size = new Size(540, 350);
            uyelerDgv.TabIndex = 57;
            uyelerDgv.CellClick += uyelerDgv_CellClick;
            // 
            // ePostaTxt
            // 
            ePostaTxt.Location = new Point(782, 165);
            ePostaTxt.Name = "ePostaTxt";
            ePostaTxt.Size = new Size(208, 25);
            ePostaTxt.TabIndex = 65;
            // 
            // telNoTxt
            // 
            telNoTxt.Location = new Point(782, 117);
            telNoTxt.Name = "telNoTxt";
            telNoTxt.Size = new Size(208, 25);
            telNoTxt.TabIndex = 64;
            // 
            // kulNoTxt
            // 
            kulNoTxt.Location = new Point(782, 210);
            kulNoTxt.Name = "kulNoTxt";
            kulNoTxt.Size = new Size(208, 25);
            kulNoTxt.TabIndex = 63;
            // 
            // kulAdiTxt
            // 
            kulAdiTxt.Location = new Point(782, 74);
            kulAdiTxt.Name = "kulAdiTxt";
            kulAdiTxt.Size = new Size(208, 25);
            kulAdiTxt.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(652, 166);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 61;
            label8.Text = "E-Posta :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(652, 119);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 60;
            label11.Text = "GSM No :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(652, 211);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 59;
            label12.Text = "Kullanıcı No :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(652, 75);
            label13.Name = "label13";
            label13.Size = new Size(99, 20);
            label13.TabIndex = 58;
            label13.Text = "Kullanıcı Adı :";
            // 
            // oduncVerBtn
            // 
            oduncVerBtn.BackColor = Color.Navy;
            oduncVerBtn.FlatAppearance.BorderSize = 0;
            oduncVerBtn.FlatStyle = FlatStyle.Flat;
            oduncVerBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oduncVerBtn.ForeColor = SystemColors.ButtonHighlight;
            oduncVerBtn.Location = new Point(471, 282);
            oduncVerBtn.Name = "oduncVerBtn";
            oduncVerBtn.Size = new Size(114, 49);
            oduncVerBtn.TabIndex = 66;
            oduncVerBtn.Text = "Ödünç Ver";
            oduncVerBtn.UseVisualStyleBackColor = false;
            oduncVerBtn.Click += oduncVerBtn_Click;
            // 
            // oduncTarihiDtp
            // 
            oduncTarihiDtp.Location = new Point(215, 273);
            oduncTarihiDtp.Name = "oduncTarihiDtp";
            oduncTarihiDtp.Size = new Size(205, 25);
            oduncTarihiDtp.TabIndex = 69;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(65, 273);
            label14.Name = "label14";
            label14.Size = new Size(144, 20);
            label14.TabIndex = 70;
            label14.Text = "Ödünç Verme Tarihi :";
            // 
            // teslimTarihiDtp
            // 
            teslimTarihiDtp.Location = new Point(215, 321);
            teslimTarihiDtp.Name = "teslimTarihiDtp";
            teslimTarihiDtp.Size = new Size(205, 25);
            teslimTarihiDtp.TabIndex = 71;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label15.ForeColor = Color.Navy;
            label15.Location = new Point(65, 321);
            label15.Name = "label15";
            label15.Size = new Size(97, 20);
            label15.TabIndex = 72;
            label15.Text = "Teslim Tarihi :";
            // 
            // frmKitapOduncVer
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(label15);
            Controls.Add(teslimTarihiDtp);
            Controls.Add(label14);
            Controls.Add(oduncTarihiDtp);
            Controls.Add(oduncVerBtn);
            Controls.Add(ePostaTxt);
            Controls.Add(telNoTxt);
            Controls.Add(kulNoTxt);
            Controls.Add(kulAdiTxt);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(uyelerDgv);
            Controls.Add(panel3);
            Controls.Add(baskiTxt);
            Controls.Add(yayineviTxt);
            Controls.Add(kitapAdiTxt);
            Controls.Add(isbnTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(kitaplarDgv);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKitapOduncVer";
            Text = "frmKitapOduncVer";
            Load += frmKitapOduncVer_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgv).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uyelerDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private Button yenileBtn;
        private Label label10;
        private TextBox kitapIsmiTxt;
        private Label label9;
        private Button button1;
        private DataGridView kitaplarDgv;
        private TextBox baskiTxt;
        private TextBox yayineviTxt;
        private TextBox kitapAdiTxt;
        private TextBox isbnTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Button ogrYenileBtn;
        private Label label6;
        private TextBox ogrNoAraTxt;
        private Label label7;
        private Button button4;
        private DataGridView uyelerDgv;
        private TextBox ePostaTxt;
        private TextBox telNoTxt;
        private TextBox kulNoTxt;
        private TextBox kulAdiTxt;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button oduncVerBtn;
        private DateTimePicker oduncTarihiDtp;
        private Label label14;
        private DateTimePicker teslimTarihiDtp;
        private Label label15;
    }
}