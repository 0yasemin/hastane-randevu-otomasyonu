namespace HastaneRandevuOtomasyonu
{
    partial class DoktorEkleSil
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
            txtDoktorAdS = new TextBox();
            txtDoktorId = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            adminGeri = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txtDSifre = new TextBox();
            label5 = new Label();
            comboBoxKlinik = new ComboBox();
            txtKullaniciAd = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(1121, 50);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1071, 0);
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
            label1.Size = new Size(284, 25);
            label1.TabIndex = 1;
            label1.Text = "Doktor Ekle-Sil-Güncelle Paneli";
            // 
            // txtDoktorAdS
            // 
            txtDoktorAdS.Location = new Point(232, 136);
            txtDoktorAdS.Name = "txtDoktorAdS";
            txtDoktorAdS.Size = new Size(260, 27);
            txtDoktorAdS.TabIndex = 33;
            // 
            // txtDoktorId
            // 
            txtDoktorId.Location = new Point(232, 79);
            txtDoktorId.Name = "txtDoktorId";
            txtDoktorId.Size = new Size(260, 27);
            txtDoktorId.TabIndex = 32;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.MediumAquamarine;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.ForeColor = SystemColors.Window;
            btnGuncelle.ImeMode = ImeMode.NoControl;
            btnGuncelle.Location = new Point(638, 240);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(143, 40);
            btnGuncelle.TabIndex = 31;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.MediumAquamarine;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.ForeColor = SystemColors.Window;
            btnSil.ImeMode = ImeMode.NoControl;
            btnSil.Location = new Point(638, 178);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(143, 40);
            btnSil.TabIndex = 30;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MediumAquamarine;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.Window;
            btnEkle.ImeMode = ImeMode.NoControl;
            btnEkle.Location = new Point(638, 112);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(143, 40);
            btnEkle.TabIndex = 29;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // adminGeri
            // 
            adminGeri.BackColor = Color.CornflowerBlue;
            adminGeri.Cursor = Cursors.Hand;
            adminGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            adminGeri.ForeColor = SystemColors.Window;
            adminGeri.Location = new Point(660, 295);
            adminGeri.Name = "adminGeri";
            adminGeri.Size = new Size(100, 40);
            adminGeri.TabIndex = 28;
            adminGeri.Text = "GERİ";
            adminGeri.UseVisualStyleBackColor = false;
            adminGeri.Click += adminGeri_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(127, 86);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 27;
            label2.Text = "Doktor ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(161, 190);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 26;
            label4.Text = "Klinik:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(51, 135);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 25;
            label3.Text = "Doktor Adı Soyadı:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1121, 221);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtDSifre
            // 
            txtDSifre.Location = new Point(232, 309);
            txtDSifre.Name = "txtDSifre";
            txtDSifre.Size = new Size(260, 27);
            txtDSifre.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(168, 308);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 36;
            label5.Text = "Şifre:";
            // 
            // comboBoxKlinik
            // 
            comboBoxKlinik.FormattingEnabled = true;
            comboBoxKlinik.Location = new Point(232, 190);
            comboBoxKlinik.Name = "comboBoxKlinik";
            comboBoxKlinik.Size = new Size(260, 28);
            comboBoxKlinik.TabIndex = 38;
            comboBoxKlinik.SelectedIndexChanged += comboBoxKlinik_SelectedIndexChanged;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(232, 253);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(260, 27);
            txtKullaniciAd.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(101, 253);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 39;
            label6.Text = "Kullanıcı Adı:";
            // 
            // DoktorEkleSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 610);
            Controls.Add(txtKullaniciAd);
            Controls.Add(label6);
            Controls.Add(comboBoxKlinik);
            Controls.Add(txtDSifre);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(txtDoktorAdS);
            Controls.Add(txtDoktorId);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(adminGeri);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoktorEkleSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorEkleSil";
            Load += DoktorEkleSil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox txtDoktorAdS;
        private TextBox txtDoktorId;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button adminGeri;
        private Label label2;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txtDSifre;
        private Label label5;
        private ComboBox comboBoxKlinik;
        private TextBox txtKullaniciAd;
        private Label label6;
    }
}