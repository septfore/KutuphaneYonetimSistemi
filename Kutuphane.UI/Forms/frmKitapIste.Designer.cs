namespace Kutuphane.UI.Forms
{
    partial class frmKitapOduncAl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapOduncAl));
            panel1 = new Panel();
            xBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            gonderBtn = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(xBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 40);
            panel1.TabIndex = 11;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 1;
            label1.Text = "Kitap İste";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 14.2641506F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(428, 127);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 24;
            label2.Text = "İstekleriniz bizim için önemli";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(422, 254);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 25);
            textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 25);
            textBox2.TabIndex = 26;
            // 
            // gonderBtn
            // 
            gonderBtn.Location = new Point(479, 605);
            gonderBtn.Name = "gonderBtn";
            gonderBtn.Size = new Size(160, 80);
            gonderBtn.TabIndex = 27;
            gonderBtn.Text = "Gönder";
            gonderBtn.UseVisualStyleBackColor = true;
            gonderBtn.Click += gonderBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(434, 422);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 220);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 29;
            label3.Text = "Kitap Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 315);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 30;
            label4.Text = "Kitap Yazarı:";
            // 
            // frmKitapOduncAl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(gonderBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKitapOduncAl";
            Text = "frmKitapOduncAl";
            Load += frmKitapOduncAl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button xBtn;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button gonderBtn;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label4;
    }
}