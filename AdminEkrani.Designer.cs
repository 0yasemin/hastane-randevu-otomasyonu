namespace HastaneRandevuOtomasyonu
{
    partial class AdminEkrani
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
            label3 = new Label();
            btnAdminEkle = new Button();
            btnKlinikEkle = new Button();
            btnDoktorEkle = new Button();
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
            panel1.Size = new Size(690, 50);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(640, 0);
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
            label1.Size = new Size(188, 25);
            label1.TabIndex = 1;
            label1.Text = "Admin Ekran Paneli ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(99, 143);
            label3.Name = "label3";
            label3.Size = new Size(480, 29);
            label3.TabIndex = 4;
            label3.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // btnAdminEkle
            // 
            btnAdminEkle.BackColor = Color.MediumAquamarine;
            btnAdminEkle.Cursor = Cursors.Hand;
            btnAdminEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdminEkle.ForeColor = SystemColors.Window;
            btnAdminEkle.ImeMode = ImeMode.NoControl;
            btnAdminEkle.Location = new Point(66, 238);
            btnAdminEkle.Name = "btnAdminEkle";
            btnAdminEkle.Size = new Size(247, 55);
            btnAdminEkle.TabIndex = 14;
            btnAdminEkle.Text = "ADMİN EKLE-SİL-GÜNCELLE";
            btnAdminEkle.UseVisualStyleBackColor = false;
            btnAdminEkle.Click += btnAdminEkle_Click;
            // 
            // btnKlinikEkle
            // 
            btnKlinikEkle.BackColor = Color.MediumAquamarine;
            btnKlinikEkle.Cursor = Cursors.Hand;
            btnKlinikEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKlinikEkle.ForeColor = SystemColors.Window;
            btnKlinikEkle.ImeMode = ImeMode.NoControl;
            btnKlinikEkle.Location = new Point(220, 336);
            btnKlinikEkle.Name = "btnKlinikEkle";
            btnKlinikEkle.Size = new Size(247, 55);
            btnKlinikEkle.TabIndex = 15;
            btnKlinikEkle.Text = "KLİNİK EKLE-SİL-GÜNCELLE";
            btnKlinikEkle.UseVisualStyleBackColor = false;
            btnKlinikEkle.Click += btnKlinikEkle_Click;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.BackColor = Color.MediumAquamarine;
            btnDoktorEkle.Cursor = Cursors.Hand;
            btnDoktorEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDoktorEkle.ForeColor = SystemColors.Window;
            btnDoktorEkle.ImeMode = ImeMode.NoControl;
            btnDoktorEkle.Location = new Point(358, 238);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(247, 55);
            btnDoktorEkle.TabIndex = 16;
            btnDoktorEkle.Text = "DOKTOR EKLE-SİL-GÜNCELLE";
            btnDoktorEkle.UseVisualStyleBackColor = false;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 520);
            Controls.Add(btnDoktorEkle);
            Controls.Add(btnKlinikEkle);
            Controls.Add(btnAdminEkle);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminEkrani";
            Load += AdminEkrani_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label3;
        private Button btnAdminEkle;
        private Button btnKlinikEkle;
        private Button btnDoktorEkle;
    }
}