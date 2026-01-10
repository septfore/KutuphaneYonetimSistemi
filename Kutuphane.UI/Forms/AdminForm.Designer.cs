namespace Kutuphane.UI.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new Panel();
            label1 = new Label();
            xBtn = new Button();
            panel2 = new Panel();
            navPnl = new Panel();
            raporlarBtn = new Button();
            uyeEkleBtn = new Button();
            kitapEkleBtn = new Button();
            kitapIadeAlBtn = new Button();
            kitapOduncVerBtn = new Button();
            kitapAraBtn = new Button();
            pictureBox1 = new PictureBox();
            pnlFormAcici = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(xBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 46);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(37, 14);
            label1.Name = "label1";
            label1.Size = new Size(263, 23);
            label1.TabIndex = 3;
            label1.Text = "Kütüphane Yönetim Sistemi";
            // 
            // xBtn
            // 
            xBtn.BackColor = Color.WhiteSmoke;
            xBtn.FlatAppearance.BorderSize = 0;
            xBtn.FlatStyle = FlatStyle.Flat;
            xBtn.ForeColor = Color.Navy;
            xBtn.Location = new Point(1351, 7);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(38, 33);
            xBtn.TabIndex = 2;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = false;
            xBtn.Click += xBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(navPnl);
            panel2.Controls.Add(raporlarBtn);
            panel2.Controls.Add(uyeEkleBtn);
            panel2.Controls.Add(kitapEkleBtn);
            panel2.Controls.Add(kitapIadeAlBtn);
            panel2.Controls.Add(kitapOduncVerBtn);
            panel2.Controls.Add(kitapAraBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 854);
            panel2.TabIndex = 10;
            panel2.Leave += panel2_Leave;
            // 
            // navPnl
            // 
            navPnl.BackColor = Color.White;
            navPnl.Location = new Point(0, 125);
            navPnl.Name = "navPnl";
            navPnl.Size = new Size(3, 71);
            navPnl.TabIndex = 16;
            // 
            // raporlarBtn
            // 
            raporlarBtn.Dock = DockStyle.Top;
            raporlarBtn.FlatAppearance.BorderSize = 0;
            raporlarBtn.FlatStyle = FlatStyle.Flat;
            raporlarBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raporlarBtn.ForeColor = SystemColors.ButtonHighlight;
            raporlarBtn.Image = (Image)resources.GetObject("raporlarBtn.Image");
            raporlarBtn.ImageAlign = ContentAlignment.MiddleRight;
            raporlarBtn.Location = new Point(0, 480);
            raporlarBtn.Name = "raporlarBtn";
            raporlarBtn.Size = new Size(221, 71);
            raporlarBtn.TabIndex = 16;
            raporlarBtn.Text = "Raporlar";
            raporlarBtn.TextAlign = ContentAlignment.MiddleLeft;
            raporlarBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            raporlarBtn.UseVisualStyleBackColor = true;
            raporlarBtn.Click += raporlarBtn_Click;
            raporlarBtn.Leave += raporlarBtn_Leave;
            // 
            // uyeEkleBtn
            // 
            uyeEkleBtn.Dock = DockStyle.Top;
            uyeEkleBtn.FlatAppearance.BorderSize = 0;
            uyeEkleBtn.FlatStyle = FlatStyle.Flat;
            uyeEkleBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uyeEkleBtn.ForeColor = SystemColors.ButtonHighlight;
            uyeEkleBtn.Image = (Image)resources.GetObject("uyeEkleBtn.Image");
            uyeEkleBtn.ImageAlign = ContentAlignment.MiddleRight;
            uyeEkleBtn.Location = new Point(0, 409);
            uyeEkleBtn.Name = "uyeEkleBtn";
            uyeEkleBtn.Size = new Size(221, 71);
            uyeEkleBtn.TabIndex = 15;
            uyeEkleBtn.Text = "Üye Ekle";
            uyeEkleBtn.TextAlign = ContentAlignment.MiddleLeft;
            uyeEkleBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            uyeEkleBtn.UseVisualStyleBackColor = true;
            uyeEkleBtn.Click += uyeEkleBtn_Click;
            uyeEkleBtn.Leave += uyeEkleBtn_Leave;
            // 
            // kitapEkleBtn
            // 
            kitapEkleBtn.Dock = DockStyle.Top;
            kitapEkleBtn.FlatAppearance.BorderSize = 0;
            kitapEkleBtn.FlatStyle = FlatStyle.Flat;
            kitapEkleBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kitapEkleBtn.ForeColor = SystemColors.ButtonHighlight;
            kitapEkleBtn.Image = (Image)resources.GetObject("kitapEkleBtn.Image");
            kitapEkleBtn.ImageAlign = ContentAlignment.MiddleRight;
            kitapEkleBtn.Location = new Point(0, 338);
            kitapEkleBtn.Name = "kitapEkleBtn";
            kitapEkleBtn.Size = new Size(221, 71);
            kitapEkleBtn.TabIndex = 14;
            kitapEkleBtn.Text = "Kitap Ekle";
            kitapEkleBtn.TextAlign = ContentAlignment.MiddleLeft;
            kitapEkleBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            kitapEkleBtn.UseVisualStyleBackColor = true;
            kitapEkleBtn.Click += kitapEkleBtn_Click;
            kitapEkleBtn.Leave += kitapEkleBtn_Leave;
            // 
            // kitapIadeAlBtn
            // 
            kitapIadeAlBtn.Dock = DockStyle.Top;
            kitapIadeAlBtn.FlatAppearance.BorderSize = 0;
            kitapIadeAlBtn.FlatStyle = FlatStyle.Flat;
            kitapIadeAlBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kitapIadeAlBtn.ForeColor = SystemColors.ButtonHighlight;
            kitapIadeAlBtn.Image = (Image)resources.GetObject("kitapIadeAlBtn.Image");
            kitapIadeAlBtn.ImageAlign = ContentAlignment.MiddleRight;
            kitapIadeAlBtn.Location = new Point(0, 267);
            kitapIadeAlBtn.Name = "kitapIadeAlBtn";
            kitapIadeAlBtn.Size = new Size(221, 71);
            kitapIadeAlBtn.TabIndex = 13;
            kitapIadeAlBtn.Text = "Kitap İade Al";
            kitapIadeAlBtn.TextAlign = ContentAlignment.MiddleLeft;
            kitapIadeAlBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            kitapIadeAlBtn.UseVisualStyleBackColor = true;
            kitapIadeAlBtn.Click += kitapIadeAlBtn_Click_1;
            kitapIadeAlBtn.Leave += kitapIadeAlBtn_Leave;
            // 
            // kitapOduncVerBtn
            // 
            kitapOduncVerBtn.Dock = DockStyle.Top;
            kitapOduncVerBtn.FlatAppearance.BorderSize = 0;
            kitapOduncVerBtn.FlatStyle = FlatStyle.Flat;
            kitapOduncVerBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kitapOduncVerBtn.ForeColor = SystemColors.ButtonHighlight;
            kitapOduncVerBtn.Image = (Image)resources.GetObject("kitapOduncVerBtn.Image");
            kitapOduncVerBtn.ImageAlign = ContentAlignment.MiddleRight;
            kitapOduncVerBtn.Location = new Point(0, 196);
            kitapOduncVerBtn.Name = "kitapOduncVerBtn";
            kitapOduncVerBtn.Size = new Size(221, 71);
            kitapOduncVerBtn.TabIndex = 12;
            kitapOduncVerBtn.Text = "Kitap Ödünç Ver";
            kitapOduncVerBtn.TextAlign = ContentAlignment.MiddleLeft;
            kitapOduncVerBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            kitapOduncVerBtn.UseVisualStyleBackColor = true;
            kitapOduncVerBtn.Click += kitapOduncVerBtn_Click_1;
            kitapOduncVerBtn.Leave += kitapOduncVerBtn_Leave;
            // 
            // kitapAraBtn
            // 
            kitapAraBtn.Dock = DockStyle.Top;
            kitapAraBtn.FlatAppearance.BorderSize = 0;
            kitapAraBtn.FlatStyle = FlatStyle.Flat;
            kitapAraBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kitapAraBtn.ForeColor = SystemColors.ButtonHighlight;
            kitapAraBtn.Image = (Image)resources.GetObject("kitapAraBtn.Image");
            kitapAraBtn.ImageAlign = ContentAlignment.MiddleRight;
            kitapAraBtn.Location = new Point(0, 125);
            kitapAraBtn.Name = "kitapAraBtn";
            kitapAraBtn.Size = new Size(221, 71);
            kitapAraBtn.TabIndex = 11;
            kitapAraBtn.Text = "Kitap Ara";
            kitapAraBtn.TextAlign = ContentAlignment.MiddleLeft;
            kitapAraBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            kitapAraBtn.UseVisualStyleBackColor = true;
            kitapAraBtn.Click += kitapAraBtn_Click;
            kitapAraBtn.Leave += kitapAraBtn_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pnlFormAcici
            // 
            pnlFormAcici.BackColor = Color.AliceBlue;
            pnlFormAcici.Dock = DockStyle.Bottom;
            pnlFormAcici.ForeColor = Color.AliceBlue;
            pnlFormAcici.Location = new Point(221, 46);
            pnlFormAcici.Name = "pnlFormAcici";
            pnlFormAcici.Size = new Size(1179, 854);
            pnlFormAcici.TabIndex = 11;
            pnlFormAcici.Paint += pnlFormAcici_Paint;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 24);
            ClientSize = new Size(1400, 900);
            Controls.Add(pnlFormAcici);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button xBtn;
        private Panel panel2;
        private Panel navPnl;
        private Button raporlarBtn;
        private Button uyeEkleBtn;
        private Button kitapEkleBtn;
        private Button kitapIadeAlBtn;
        private Button kitapOduncVerBtn;
        private Button kitapAraBtn;
        private PictureBox pictureBox1;
        private Panel pnlFormAcici;
    }
}