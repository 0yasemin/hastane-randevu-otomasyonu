namespace HastaneRandevuOtomasyonu
{
    partial class AdminGirisPaneli
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            adminGeri = new Button();
            button3 = new Button();
            txtBoxKadi = new TextBox();
            txtBoxKsifre = new TextBox();
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
            panel1.Size = new Size(657, 50);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(607, 0);
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
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 1;
            label1.Text = "Admin Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(230, 123);
            label2.Name = "label2";
            label2.Size = new Size(229, 29);
            label2.TabIndex = 2;
            label2.Text = "Admin Giriş Paneli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(89, 204);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 3;
            label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(149, 257);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 4;
            label4.Text = "Şifre:";
            // 
            // adminGeri
            // 
            adminGeri.BackColor = Color.MediumAquamarine;
            adminGeri.Cursor = Cursors.Hand;
            adminGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            adminGeri.ForeColor = SystemColors.Window;
            adminGeri.Location = new Point(107, 331);
            adminGeri.Name = "adminGeri";
            adminGeri.Size = new Size(100, 40);
            adminGeri.TabIndex = 7;
            adminGeri.Text = "GERİ";
            adminGeri.UseVisualStyleBackColor = false;
            adminGeri.Click += adminGeri_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.CornflowerBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(266, 331);
            button3.Name = "button3";
            button3.Size = new Size(155, 40);
            button3.TabIndex = 8;
            button3.Text = "GİRİŞ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtBoxKadi
            // 
            txtBoxKadi.Location = new Point(220, 205);
            txtBoxKadi.Name = "txtBoxKadi";
            txtBoxKadi.Size = new Size(260, 27);
            txtBoxKadi.TabIndex = 9;
            // 
            // txtBoxKsifre
            // 
            txtBoxKsifre.Location = new Point(220, 258);
            txtBoxKsifre.Name = "txtBoxKsifre";
            txtBoxKsifre.Size = new Size(260, 27);
            txtBoxKsifre.TabIndex = 10;
            txtBoxKsifre.TextChanged += txtBoxKsifre_TextChanged;
            // 
            // AdminGirisPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 507);
            Controls.Add(txtBoxKsifre);
            Controls.Add(txtBoxKadi);
            Controls.Add(button3);
            Controls.Add(adminGeri);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminGirisPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminGirisPaneli";
            Load += AdminGirisPaneli_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button adminGeri;
        private Button button3;
        private TextBox txtBoxKadi;
        private TextBox txtBoxKsifre;
    }
}