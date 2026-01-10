namespace Kutuphane.UI.Forms
{
    partial class frmEnCokKitapAlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnCokKitapAlan));
            label2 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            dgvUyeler = new DataGridView();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 5;
            label2.Text = "En Çok Kitap Alanlar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(25, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 40);
            panel2.TabIndex = 15;
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
            // dgvUyeler
            // 
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(25, 90);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 45;
            dgvUyeler.Size = new Size(1115, 616);
            dgvUyeler.TabIndex = 16;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1061, 737);
            button1.Name = "button1";
            button1.Size = new Size(79, 51);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEnCokKitapAlan
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(button1);
            Controls.Add(dgvUyeler);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEnCokKitapAlan";
            Text = "frmEnCokKitapAlan";
            Load += frmEnCokKitapAlan_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Button button2;
        private DataGridView dgvUyeler;
        private Button button1;
    }
}