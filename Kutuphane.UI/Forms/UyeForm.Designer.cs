namespace Kutuphane.UI.Forms
{
    partial class UyeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeForm));
            panel1 = new Panel();
            label1 = new Label();
            xBtn = new Button();
            panel2 = new Panel();
            navPnl = new Panel();
            kitapOduncAlBtn = new Button();
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
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(37, 14);
            label1.Name = "label1";
            label1.Size = new Size(263, 23);
            label1.TabIndex = 2;
            label1.Text = "Kütüphane Yönetim Sistemi";
            // 
            // xBtn
            // 
            xBtn.BackColor = Color.FromArgb(18, 18, 24);
            xBtn.FlatAppearance.BorderSize = 0;
            xBtn.FlatStyle = FlatStyle.Flat;
            xBtn.ForeColor = Color.FromArgb(0, 122, 255);
            xBtn.Location = new Point(1351, 7);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(38, 33);
            xBtn.TabIndex = 1;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = false;
            xBtn.Click += xBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(navPnl);
            panel2.Controls.Add(kitapOduncAlBtn);
            panel2.Controls.Add(kitapAraBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 854);
            panel2.TabIndex = 9;
            // 
            // navPnl
            // 
            navPnl.BackColor = Color.White;
            navPnl.Location = new Point(0, 130);
            navPnl.Name = "navPnl";
            navPnl.Size = new Size(3, 71);
            navPnl.TabIndex = 15;
            navPnl.Paint += navPnl_Paint;
            // 
            // kitapOduncAlBtn
            // 
            kitapOduncAlBtn.Dock = DockStyle.Top;
            kitapOduncAlBtn.FlatAppearance.BorderSize = 0;
            kitapOduncAlBtn.FlatStyle = FlatStyle.Flat;
            kitapOduncAlBtn.Font = new Font("Nirmala UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kitapOduncAlBtn.ForeColor = SystemColors.ButtonHighlight;
            kitapOduncAlBtn.Image = (Image)resources.GetObject("kitapOduncAlBtn.Image");
            kitapOduncAlBtn.ImageAlign = ContentAlignment.MiddleRight;
            kitapOduncAlBtn.Location = new Point(0, 201);
            kitapOduncAlBtn.Name = "kitapOduncAlBtn";
            kitapOduncAlBtn.Size = new Size(221, 71);
            kitapOduncAlBtn.TabIndex = 14;
            kitapOduncAlBtn.Text = "Kitap İste";
            kitapOduncAlBtn.TextAlign = ContentAlignment.MiddleLeft;
            kitapOduncAlBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            kitapOduncAlBtn.UseVisualStyleBackColor = true;
            kitapOduncAlBtn.Click += kitapOduncAlBtn_Click;
            kitapOduncAlBtn.Leave += kitapOduncAlBtn_Leave;
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
            kitapAraBtn.Location = new Point(0, 130);
            kitapAraBtn.Name = "kitapAraBtn";
            kitapAraBtn.Size = new Size(221, 71);
            kitapAraBtn.TabIndex = 13;
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
            pictureBox1.Size = new Size(221, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlFormAcici
            // 
            pnlFormAcici.BackColor = Color.AliceBlue;
            pnlFormAcici.Dock = DockStyle.Bottom;
            pnlFormAcici.Location = new Point(221, 46);
            pnlFormAcici.Name = "pnlFormAcici";
            pnlFormAcici.Size = new Size(1179, 854);
            pnlFormAcici.TabIndex = 10;
            pnlFormAcici.Paint += pnlFormAcici_Paint;
            // 
            // UyeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 24);
            ClientSize = new Size(1400, 900);
            Controls.Add(pnlFormAcici);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UyeForm";
            Text = "KullaniciForm";
            Load += UyeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button xBtn;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button kitapAraBtn;
        private Button kitapOduncAlBtn;
        private Panel navPnl;
        private Panel pnlFormAcici;
    }
}