namespace Kutuphane.UI.Forms
{
    partial class frmKitapIadeAl
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
            txtEposta = new TextBox();
            txtGsm = new TextBox();
            txtKulNo = new TextBox();
            txtAdSoyad = new TextBox();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtBaski = new TextBox();
            txtYayinevi = new TextBox();
            txtKitapAdi = new TextBox();
            txtIsbn = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            dgvIadeler = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            button1 = new Button();
            dtpIadeTarihi = new DateTimePicker();
            label7 = new Label();
            dtpOduncTarihi = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            dtpTeslimPlan = new DateTimePicker();
            btnIadeAl = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIadeler).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(782, 656);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(208, 25);
            txtEposta.TabIndex = 82;
            // 
            // txtGsm
            // 
            txtGsm.Location = new Point(782, 608);
            txtGsm.Name = "txtGsm";
            txtGsm.Size = new Size(208, 25);
            txtGsm.TabIndex = 81;
            // 
            // txtKulNo
            // 
            txtKulNo.Location = new Point(782, 701);
            txtKulNo.Name = "txtKulNo";
            txtKulNo.Size = new Size(208, 25);
            txtKulNo.TabIndex = 80;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(782, 565);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(208, 25);
            txtAdSoyad.TabIndex = 79;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(652, 657);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 78;
            label8.Text = "E-Posta :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(652, 610);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 77;
            label11.Text = "GSM No :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(652, 702);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 76;
            label12.Text = "Kullanıcı No :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(652, 566);
            label13.Name = "label13";
            label13.Size = new Size(99, 20);
            label13.TabIndex = 75;
            label13.Text = "Kullanıcı Adı :";
            // 
            // txtBaski
            // 
            txtBaski.Location = new Point(129, 698);
            txtBaski.Name = "txtBaski";
            txtBaski.Size = new Size(208, 25);
            txtBaski.TabIndex = 74;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(130, 654);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(208, 25);
            txtYayinevi.TabIndex = 73;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(131, 610);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(208, 25);
            txtKitapAdi.TabIndex = 72;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(131, 568);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(208, 25);
            txtIsbn.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(29, 656);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 70;
            label5.Text = "Yayınevi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(30, 700);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 69;
            label4.Text = "Baskı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(29, 611);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 68;
            label3.Text = "Kitap Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(31, 570);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 67;
            label1.Text = "ISBN :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(30, 503);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 40);
            panel2.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "İade Al";
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
            // dgvIadeler
            // 
            dgvIadeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIadeler.Location = new Point(29, 74);
            dgvIadeler.Name = "dgvIadeler";
            dgvIadeler.RowHeadersWidth = 45;
            dgvIadeler.Size = new Size(1115, 403);
            dgvIadeler.TabIndex = 83;
            dgvIadeler.CellClick += dgvIadeler_CellClick;
            dgvIadeler.RowPrePaint += dgvIadeler_RowPrePaint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(29, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 40);
            panel1.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(16, 8);
            label6.Name = "label6";
            label6.Size = new Size(223, 25);
            label6.TabIndex = 5;
            label6.Text = "Ödünçte Olan Kitaplar";
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
            // dtpIadeTarihi
            // 
            dtpIadeTarihi.Location = new Point(131, 743);
            dtpIadeTarihi.Name = "dtpIadeTarihi";
            dtpIadeTarihi.Size = new Size(208, 25);
            dtpIadeTarihi.TabIndex = 84;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(30, 745);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 85;
            label7.Text = "İade Tarihi :";
            // 
            // dtpOduncTarihi
            // 
            dtpOduncTarihi.Location = new Point(130, 786);
            dtpOduncTarihi.Name = "dtpOduncTarihi";
            dtpOduncTarihi.Size = new Size(208, 25);
            dtpOduncTarihi.TabIndex = 86;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(27, 789);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 87;
            label9.Text = "Ödünç Tarihi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(12, 824);
            label10.Name = "label10";
            label10.Size = new Size(165, 20);
            label10.TabIndex = 89;
            label10.Text = "Planlanan Teslim Tarihi :";
            // 
            // dtpTeslimPlan
            // 
            dtpTeslimPlan.Location = new Point(181, 824);
            dtpTeslimPlan.Name = "dtpTeslimPlan";
            dtpTeslimPlan.Size = new Size(208, 25);
            dtpTeslimPlan.TabIndex = 88;
            // 
            // btnIadeAl
            // 
            btnIadeAl.BackColor = Color.Navy;
            btnIadeAl.FlatAppearance.BorderSize = 0;
            btnIadeAl.FlatStyle = FlatStyle.Flat;
            btnIadeAl.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIadeAl.ForeColor = SystemColors.ButtonHighlight;
            btnIadeAl.Location = new Point(813, 774);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(114, 49);
            btnIadeAl.TabIndex = 90;
            btnIadeAl.Text = "İade Al";
            btnIadeAl.UseVisualStyleBackColor = false;
            btnIadeAl.Click += btnIadeAl_Click;
            // 
            // frmKitapIadeAl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(btnIadeAl);
            Controls.Add(label10);
            Controls.Add(dtpTeslimPlan);
            Controls.Add(label9);
            Controls.Add(dtpOduncTarihi);
            Controls.Add(label7);
            Controls.Add(dtpIadeTarihi);
            Controls.Add(panel1);
            Controls.Add(dgvIadeler);
            Controls.Add(txtEposta);
            Controls.Add(txtGsm);
            Controls.Add(txtKulNo);
            Controls.Add(txtAdSoyad);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(txtBaski);
            Controls.Add(txtYayinevi);
            Controls.Add(txtKitapAdi);
            Controls.Add(txtIsbn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKitapIadeAl";
            Text = "frmKitapIadeAl";
            Load += frmKitapIadeAl_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIadeler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEposta;
        private TextBox txtGsm;
        private TextBox txtKulNo;
        private TextBox txtAdSoyad;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtBaski;
        private TextBox txtYayinevi;
        private TextBox txtKitapAdi;
        private TextBox txtIsbn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button button2;
        private DataGridView dgvIadeler;
        private Panel panel1;
        private Label label6;
        private Button button1;
        private DateTimePicker dtpIadeTarihi;
        private Label label7;
        private DateTimePicker dtpOduncTarihi;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpTeslimPlan;
        private Button btnIadeAl;
    }
}