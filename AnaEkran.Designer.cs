namespace HastaneRandevuOtomasyonu
{
    partial class AnaEkran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            AnaAdminGiris = new Button();
            AnaDoktorGiris = new Button();
            AnaHastaGiris = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 50);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(702, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(189, 137);
            label2.Name = "label2";
            label2.Size = new Size(372, 29);
            label2.TabIndex = 1;
            label2.Text = "HASTANE RANDEVU SİSTEMİ";
            // 
            // AnaAdminGiris
            // 
            AnaAdminGiris.BackColor = Color.CornflowerBlue;
            AnaAdminGiris.Cursor = Cursors.Hand;
            AnaAdminGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AnaAdminGiris.ForeColor = Color.White;
            AnaAdminGiris.Location = new Point(97, 227);
            AnaAdminGiris.Name = "AnaAdminGiris";
            AnaAdminGiris.Size = new Size(150, 70);
            AnaAdminGiris.TabIndex = 2;
            AnaAdminGiris.Text = "ADMİN GİRİŞ";
            AnaAdminGiris.UseVisualStyleBackColor = false;
            AnaAdminGiris.Click += AnaAdminGiris_Click;
            // 
            // AnaDoktorGiris
            // 
            AnaDoktorGiris.BackColor = Color.CornflowerBlue;
            AnaDoktorGiris.Cursor = Cursors.Hand;
            AnaDoktorGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AnaDoktorGiris.ForeColor = Color.White;
            AnaDoktorGiris.Location = new Point(506, 227);
            AnaDoktorGiris.Name = "AnaDoktorGiris";
            AnaDoktorGiris.Size = new Size(150, 70);
            AnaDoktorGiris.TabIndex = 3;
            AnaDoktorGiris.Text = "DOKTOR GİRİŞ";
            AnaDoktorGiris.UseVisualStyleBackColor = false;
            AnaDoktorGiris.Click += AnaDoktorGiris_Click;
            // 
            // AnaHastaGiris
            // 
            AnaHastaGiris.BackColor = Color.CornflowerBlue;
            AnaHastaGiris.Cursor = Cursors.Hand;
            AnaHastaGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AnaHastaGiris.ForeColor = Color.White;
            AnaHastaGiris.Location = new Point(305, 227);
            AnaHastaGiris.Name = "AnaHastaGiris";
            AnaHastaGiris.Size = new Size(150, 70);
            AnaHastaGiris.TabIndex = 4;
            AnaHastaGiris.Text = "HASTA GİRİŞ";
            AnaHastaGiris.UseVisualStyleBackColor = false;
            AnaHastaGiris.Click += AnaHastaGiris_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(752, 409);
            Controls.Add(AnaHastaGiris);
            Controls.Add(AnaDoktorGiris);
            Controls.Add(AnaAdminGiris);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AnaEkran_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button AnaAdminGiris;
        private Button AnaDoktorGiris;
        private Button AnaHastaGiris;
    }
}
