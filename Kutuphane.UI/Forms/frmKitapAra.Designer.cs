namespace Kutuphane.UI.Forms
{
    partial class frmKitapAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapAra));
            label1 = new Label();
            panel1 = new Panel();
            yenileBtn = new Button();
            kitapAdiTxt = new TextBox();
            xBtn = new Button();
            kitaplarDgw = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgw).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(328, 13);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 1;
            label1.Text = "Kitap İsmi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(yenileBtn);
            panel1.Controls.Add(kitapAdiTxt);
            panel1.Controls.Add(xBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 46);
            panel1.TabIndex = 10;
            // 
            // yenileBtn
            // 
            yenileBtn.BackColor = Color.FromArgb(18, 18, 24);
            yenileBtn.FlatAppearance.BorderSize = 0;
            yenileBtn.FlatStyle = FlatStyle.Flat;
            yenileBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yenileBtn.ForeColor = SystemColors.ButtonHighlight;
            yenileBtn.Image = (Image)resources.GetObject("yenileBtn.Image");
            yenileBtn.ImageAlign = ContentAlignment.MiddleRight;
            yenileBtn.Location = new Point(700, 13);
            yenileBtn.Name = "yenileBtn";
            yenileBtn.Size = new Size(83, 25);
            yenileBtn.TabIndex = 4;
            yenileBtn.Text = "Yenile";
            yenileBtn.TextAlign = ContentAlignment.MiddleLeft;
            yenileBtn.UseVisualStyleBackColor = false;
            yenileBtn.Click += yenileBtn_Click;
            // 
            // kitapAdiTxt
            // 
            kitapAdiTxt.Location = new Point(421, 13);
            kitapAdiTxt.Name = "kitapAdiTxt";
            kitapAdiTxt.Size = new Size(261, 25);
            kitapAdiTxt.TabIndex = 3;
            kitapAdiTxt.TextChanged += kitapAdiTxt_TextChanged;
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
            // kitaplarDgw
            // 
            kitaplarDgw.BackgroundColor = Color.AliceBlue;
            kitaplarDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kitaplarDgw.Location = new Point(32, 104);
            kitaplarDgw.Name = "kitaplarDgw";
            kitaplarDgw.RowHeadersWidth = 45;
            kitaplarDgw.Size = new Size(1115, 709);
            kitaplarDgw.TabIndex = 11;
            // 
            // frmKitapAra
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1179, 854);
            Controls.Add(kitaplarDgw);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKitapAra";
            Text = "frmKitapAra";
            Load += frmKitapAra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kitaplarDgw).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button xBtn;
        private TextBox kitapAdiTxt;
        private Button yenileBtn;
        private DataGridView kitaplarDgw;
    }
}