namespace HastaneRandevuOtomasyonu
{
    partial class RandevuAlmaPaneli
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
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label5 = new Label();
            txtRandevuNo = new TextBox();
            txtTc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimeRandevuTarih = new DateTimePicker();
            btnRandevuAl = new Button();
            btnGeri = new Button();
            btnRandevuIptal = new Button();
            cbRandevuSaat = new ComboBox();
            cbDrAd = new ComboBox();
            cbKlinik = new ComboBox();
            label8 = new Label();
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
            panel1.Size = new Size(1107, 50);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1057, 0);
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
            label1.Location = new Point(23, 10);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 1;
            label1.Text = "Randevu Alma Paneli";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(187, 347);
            label11.Name = "label11";
            label11.Size = new Size(146, 25);
            label11.TabIndex = 45;
            label11.Text = "Randevu Saati:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(224, 294);
            label12.Name = "label12";
            label12.Size = new Size(109, 25);
            label12.TabIndex = 42;
            label12.Text = "Doktor Adı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(268, 243);
            label13.Name = "label13";
            label13.Size = new Size(65, 25);
            label13.TabIndex = 41;
            label13.Text = "Klinik:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(183, 192);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 39;
            label5.Text = "Randevu Tarihi:";
            label5.Click += label5_Click;
            // 
            // txtRandevuNo
            // 
            txtRandevuNo.Location = new Point(339, 83);
            txtRandevuNo.Name = "txtRandevuNo";
            txtRandevuNo.Size = new Size(200, 27);
            txtRandevuNo.TabIndex = 38;
            txtRandevuNo.TextChanged += txtRandevuNo_TextChanged;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(339, 135);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(200, 27);
            txtTc.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(207, 87);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 36;
            label4.Text = "Randevu No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(200, 137);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 35;
            label3.Text = "TC Kimlik No:";
            // 
            // dateTimeRandevuTarih
            // 
            dateTimeRandevuTarih.Location = new Point(339, 190);
            dateTimeRandevuTarih.Name = "dateTimeRandevuTarih";
            dateTimeRandevuTarih.Size = new Size(138, 27);
            dateTimeRandevuTarih.TabIndex = 47;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.BackColor = Color.CornflowerBlue;
            btnRandevuAl.Cursor = Cursors.Hand;
            btnRandevuAl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRandevuAl.ForeColor = SystemColors.Window;
            btnRandevuAl.Location = new Point(360, 426);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(166, 40);
            btnRandevuAl.TabIndex = 53;
            btnRandevuAl.Text = "RANDEVU AL";
            btnRandevuAl.UseVisualStyleBackColor = false;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.MediumAquamarine;
            btnGeri.Cursor = Cursors.Hand;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.ForeColor = SystemColors.Window;
            btnGeri.Location = new Point(111, 426);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(101, 40);
            btnGeri.TabIndex = 54;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnRandevuIptal
            // 
            btnRandevuIptal.BackColor = Color.CornflowerBlue;
            btnRandevuIptal.Cursor = Cursors.Hand;
            btnRandevuIptal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRandevuIptal.ForeColor = SystemColors.Window;
            btnRandevuIptal.Location = new Point(732, 221);
            btnRandevuIptal.Name = "btnRandevuIptal";
            btnRandevuIptal.Size = new Size(204, 50);
            btnRandevuIptal.TabIndex = 55;
            btnRandevuIptal.Text = "RANDEVULARIM";
            btnRandevuIptal.UseVisualStyleBackColor = false;
            btnRandevuIptal.Click += btnRandevuIptal_Click;
            // 
            // cbRandevuSaat
            // 
            cbRandevuSaat.FormattingEnabled = true;
            cbRandevuSaat.Items.AddRange(new object[] { "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30" });
            cbRandevuSaat.Location = new Point(339, 348);
            cbRandevuSaat.Name = "cbRandevuSaat";
            cbRandevuSaat.Size = new Size(200, 28);
            cbRandevuSaat.TabIndex = 57;
            // 
            // cbDrAd
            // 
            cbDrAd.FormattingEnabled = true;
            cbDrAd.Location = new Point(339, 295);
            cbDrAd.Name = "cbDrAd";
            cbDrAd.Size = new Size(200, 28);
            cbDrAd.TabIndex = 58;
            // 
            // cbKlinik
            // 
            cbKlinik.FormattingEnabled = true;
            cbKlinik.Location = new Point(339, 243);
            cbKlinik.Name = "cbKlinik";
            cbKlinik.Size = new Size(200, 28);
            cbKlinik.TabIndex = 59;
            cbKlinik.SelectedIndexChanged += cbKlinik_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(607, 159);
            label8.Name = "label8";
            label8.Size = new Size(464, 36);
            label8.TabIndex = 60;
            label8.Text = "Randevularım butonu ile güncel randevularınızı görebilir aynı zamanda \r\niptal işlemini gerçekleştirebilirsiniz.\r\n";
            // 
            // RandevuAlmaPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 593);
            Controls.Add(label8);
            Controls.Add(cbKlinik);
            Controls.Add(cbDrAd);
            Controls.Add(cbRandevuSaat);
            Controls.Add(btnRandevuIptal);
            Controls.Add(btnGeri);
            Controls.Add(btnRandevuAl);
            Controls.Add(dateTimeRandevuTarih);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(txtRandevuNo);
            Controls.Add(txtTc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RandevuAlmaPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandevuAlmaPaneli";
            FormClosed += RandevuAlmaPaneli_FormClosed;
            Load += RandevuAlmaPaneli_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label5;
        private TextBox txtRandevuNo;
        private TextBox txtTc;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimeRandevuTarih;
        private Button btnRandevuAl;
        private Button btnGeri;
        private Button btnRandevuIptal;
        private ComboBox cbRandevuSaat;
        private ComboBox cbDrAd;
        private ComboBox cbKlinik;
        private Label label8;
    }
}