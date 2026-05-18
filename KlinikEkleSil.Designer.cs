namespace HastaneRandevuOtomasyonu
{
    partial class KlinikEkleSil
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
            txtKlinikAd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            adminGeri = new Button();
            dataGridView1 = new DataGridView();
            txtKlinikId = new TextBox();
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
            panel1.Size = new Size(979, 50);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(929, 0);
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
            label1.Size = new Size(274, 25);
            label1.TabIndex = 1;
            label1.Text = "Klinik Ekle-Sil-Güncelle Paneli";
            // 
            // txtKlinikAd
            // 
            txtKlinikAd.Location = new Point(229, 204);
            txtKlinikAd.Name = "txtKlinikAd";
            txtKlinikAd.Size = new Size(260, 27);
            txtKlinikAd.TabIndex = 27;
            txtKlinikAd.TextChanged += txtKlinikAd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(125, 150);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 25;
            label2.Text = "Klinik ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(115, 206);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 24;
            label3.Text = "Klinik Adı:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.MediumAquamarine;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.ForeColor = SystemColors.Window;
            btnGuncelle.ImeMode = ImeMode.NoControl;
            btnGuncelle.Location = new Point(583, 204);
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
            btnSil.Location = new Point(583, 150);
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
            btnEkle.Location = new Point(583, 95);
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
            adminGeri.Location = new Point(607, 260);
            adminGeri.Name = "adminGeri";
            adminGeri.Size = new Size(100, 40);
            adminGeri.TabIndex = 28;
            adminGeri.Text = "GERİ";
            adminGeri.UseVisualStyleBackColor = false;
            adminGeri.Click += adminGeri_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(979, 214);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtKlinikId
            // 
            txtKlinikId.Location = new Point(229, 148);
            txtKlinikId.Name = "txtKlinikId";
            txtKlinikId.Size = new Size(260, 27);
            txtKlinikId.TabIndex = 33;
            txtKlinikId.TextChanged += txtKlinikId_TextChanged;
            // 
            // KlinikEkleSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 547);
            Controls.Add(txtKlinikId);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(adminGeri);
            Controls.Add(txtKlinikAd);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KlinikEkleSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KlinikEkleSil";
            Load += KlinikEkleSil_Load;
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
        private TextBox txtKlinikAd;
       // private TextBox txtkli;
        private Label label2;
        private Label label3;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button adminGeri;
        private DataGridView dataGridView1;
        private TextBox txtKlinikId;
    }
}