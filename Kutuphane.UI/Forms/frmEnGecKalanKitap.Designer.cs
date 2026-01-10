namespace Kutuphane.UI.Forms
{
    partial class frmEnGecKalanKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnGecKalanKitap));
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            dgv = new DataGridView();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
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
            panel2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(223, 25);
            label2.TabIndex = 5;
            label2.Text = "En Geç Kalan Kitaplar";
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
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(30, 78);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 45;
            dgv.Size = new Size(1115, 616);
            dgv.TabIndex = 17;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1061, 720);
            button1.Name = "button1";
            button1.Size = new Size(84, 51);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEnGecKalanKitap
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(button1);
            Controls.Add(dgv);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEnGecKalanKitap";
            Text = "frmEnGecKalanKitap";
            Load += frmEnGecKalanKitap_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button button2;
        private DataGridView dgv;
        private Button button1;
    }
}