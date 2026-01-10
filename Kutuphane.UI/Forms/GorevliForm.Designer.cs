namespace Kutuphane.UI.Forms
{
    partial class GorevliForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevliForm));
            panel1 = new Panel();
            label1 = new Label();
            xBtn = new Button();
            panel2 = new Panel();
            navPnl = new Panel();
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
            label1.TabIndex = 3;
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
            xBtn.TabIndex = 2;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = false;
            xBtn.Click += xBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(navPnl);
            panel2.Controls.Add(kitapIadeAlBtn);
            panel2.Controls.Add(kitapOduncVerBtn);
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
            navPnl.TabIndex = 16;
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
            kitapIadeAlBtn.Location = new Point(0, 272);
            kitapIadeAlBtn.Name = "kitapIadeAlBtn";
            kitapIadeAlBtn.Size = new Size(221, 71);
            kitapIadeAlBtn.TabIndex = 15;
            kitapIadeAlBtn.Text = "Kitap İade Al";
            kitapIadeAlBtn.TextAlign = ContentAlignment.MiddleLeft;
            kitapIadeAlBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            kitapIadeAlBtn.UseVisualStyleBackColor = true;
            kitapIadeAlBtn.Click += kitapIadeAlBtn_Click;
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
            kitapOduncVerBtn.Location = new Point(0, 201);
            kitapOduncVerBtn.Name = "kitapOduncVerBtn";
            kitapOduncVerBtn.Size = new Size(221, 71);
            kitapOduncVerBtn.TabIndex = 14;
            kitapOduncVerBtn.Text = "Kitap Ödünç Ver";
            kitapOduncVerBtn.TextAlign = ContentAlignment.MiddleLeft;
            kitapOduncVerBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            kitapOduncVerBtn.UseVisualStyleBackColor = true;
            kitapOduncVerBtn.Click += kitapOduncVerBtn_Click;
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
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlFormAcici
            // 
            pnlFormAcici.BackColor = Color.AliceBlue;
            pnlFormAcici.Dock = DockStyle.Bottom;
            pnlFormAcici.Location = new Point(221, 46);
            pnlFormAcici.Name = "pnlFormAcici";
            pnlFormAcici.Size = new Size(1179, 854);
            pnlFormAcici.TabIndex = 11;
            pnlFormAcici.Paint += pnlFormAcici_Paint;
            // 
            // GorevliForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 24);
            ClientSize = new Size(1400, 900);
            Controls.Add(pnlFormAcici);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GorevliForm";
            Text = "GorevliFormcs";
            Load += GorevliForm_Load;
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
        private Button kitapIadeAlBtn;
        private Button kitapOduncVerBtn;
        private Button kitapAraBtn;
        private Panel navPnl;
        private Panel pnlFormAcici;
    }
}