namespace Kutuphane.UI.Forms
{
    partial class AcilisForm
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 122, 255);
            label1.Location = new Point(103, 114);
            label1.Name = "label1";
            label1.Size = new Size(341, 35);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Yönetim Sistemi";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(28, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 28);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 255);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 28);
            panel2.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // AcilisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 24);
            ClientSize = new Size(559, 334);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(18, 18, 24);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcilisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AcilisForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}