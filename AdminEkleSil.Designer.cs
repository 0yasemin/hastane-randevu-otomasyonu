namespace HastaneRandevuOtomasyonu
{
    partial class AdminEkleSil
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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            adminGeri = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtAdminTC = new TextBox();
            txtAdminAd = new TextBox();
            txtAdminSifre = new TextBox();
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
            panel1.Size = new Size(846, 50);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(796, 0);
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
            label1.Size = new Size(283, 25);
            label1.TabIndex = 1;
            label1.Text = "Admin Ekle-Sil-Güncelle Paneli";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(846, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(94, 206);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 12;
            label4.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(44, 153);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 11;
            label3.Text = "Admin Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(44, 97);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 15;
            label2.Text = "Admin TC:";
            // 
            // adminGeri
            // 
            adminGeri.BackColor = Color.CornflowerBlue;
            adminGeri.Cursor = Cursors.Hand;
            adminGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            adminGeri.ForeColor = SystemColors.Window;
            adminGeri.Location = new Point(597, 263);
            adminGeri.Name = "adminGeri";
            adminGeri.Size = new Size(100, 40);
            adminGeri.TabIndex = 17;
            adminGeri.Text = "GERİ";
            adminGeri.UseVisualStyleBackColor = false;
            adminGeri.Click += adminGeri_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MediumAquamarine;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.Window;
            btnEkle.ImeMode = ImeMode.NoControl;
            btnEkle.Location = new Point(573, 98);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(143, 40);
            btnEkle.TabIndex = 19;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.MediumAquamarine;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.ForeColor = SystemColors.Window;
            btnSil.ImeMode = ImeMode.NoControl;
            btnSil.Location = new Point(573, 153);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(143, 40);
            btnSil.TabIndex = 20;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.MediumAquamarine;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.ForeColor = SystemColors.Window;
            btnGuncelle.ImeMode = ImeMode.NoControl;
            btnGuncelle.Location = new Point(573, 207);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(143, 40);
            btnGuncelle.TabIndex = 21;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtAdminTC
            // 
            txtAdminTC.Location = new Point(177, 98);
            txtAdminTC.Name = "txtAdminTC";
            txtAdminTC.Size = new Size(260, 27);
            txtAdminTC.TabIndex = 22;
            // 
            // txtAdminAd
            // 
            txtAdminAd.Location = new Point(177, 154);
            txtAdminAd.Name = "txtAdminAd";
            txtAdminAd.Size = new Size(260, 27);
            txtAdminAd.TabIndex = 23;
            // 
            // txtAdminSifre
            // 
            txtAdminSifre.Location = new Point(177, 207);
            txtAdminSifre.Name = "txtAdminSifre";
            txtAdminSifre.Size = new Size(260, 27);
            txtAdminSifre.TabIndex = 24;
            // 
            // AdminEkleSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 546);
            Controls.Add(txtAdminSifre);
            Controls.Add(txtAdminAd);
            Controls.Add(txtAdminTC);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(adminGeri);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminEkleSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminEkleSil";
            Load += AdminEkleSil_Load;
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
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button adminGeri;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtAdminTC;
        private TextBox txtAdminAd;
        private TextBox txtAdminSifre;
    }
}