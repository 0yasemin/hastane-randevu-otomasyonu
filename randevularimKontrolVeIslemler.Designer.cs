namespace HastaneRandevuOtomasyonu
{
    partial class randevularimKontrolVeIslemler
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
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            btnRandevuIptal = new Button();
            btnGeri = new Button();
            dataGridView1 = new DataGridView();
            txtRandevuNo = new TextBox();
            label4 = new Label();
            txtTc = new TextBox();
            label3 = new Label();
            btnAra = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 50);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 50);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(775, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 10);
            label2.Name = "label2";
            label2.Size = new Size(284, 25);
            label2.TabIndex = 1;
            label2.Text = "Randevu Arama ve İptal  Paneli";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 10);
            label1.Name = "label1";
            label1.Size = new Size(288, 25);
            label1.TabIndex = 1;
            label1.Text = "Randevularım Ve İşemler Paneli";
            // 
            // btnRandevuIptal
            // 
            btnRandevuIptal.BackColor = Color.CornflowerBlue;
            btnRandevuIptal.Cursor = Cursors.Hand;
            btnRandevuIptal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRandevuIptal.ForeColor = SystemColors.Window;
            btnRandevuIptal.Location = new Point(601, 268);
            btnRandevuIptal.Name = "btnRandevuIptal";
            btnRandevuIptal.Size = new Size(166, 40);
            btnRandevuIptal.TabIndex = 57;
            btnRandevuIptal.Text = "RANDEVU İPTAL ET";
            btnRandevuIptal.UseVisualStyleBackColor = false;
            btnRandevuIptal.Click += btnRandevuIptal_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.MediumAquamarine;
            btnGeri.Cursor = Cursors.Hand;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.ForeColor = SystemColors.Window;
            btnGeri.Location = new Point(102, 268);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(101, 40);
            btnGeri.TabIndex = 56;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(825, 198);
            dataGridView1.TabIndex = 58;
            // 
            // txtRandevuNo
            // 
            txtRandevuNo.Location = new Point(338, 127);
            txtRandevuNo.Name = "txtRandevuNo";
            txtRandevuNo.Size = new Size(200, 27);
            txtRandevuNo.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(206, 129);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 59;
            label4.Text = "Randevu No:";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(338, 194);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(200, 27);
            txtTc.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(199, 196);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 61;
            label3.Text = "TC Kimlik No:";
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.CornflowerBlue;
            btnAra.Cursor = Cursors.Hand;
            btnAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAra.ForeColor = SystemColors.Window;
            btnAra.Location = new Point(354, 268);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(166, 40);
            btnAra.TabIndex = 63;
            btnAra.Text = "RANDEVU ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // randevularimKontrolVeIslemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 533);
            Controls.Add(btnAra);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(txtRandevuNo);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnRandevuIptal);
            Controls.Add(btnGeri);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "randevularimKontrolVeIslemler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "randevularimKontrolVeIslemler";
            Load += randevularimKontrolVeIslemler_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
      //  private Button button1;
        private Label label1;
        private Button btnRandevuIptal;
        private Button btnGeri;
        private DataGridView dataGridView1;
        private TextBox txtRandevuNo;
        private Label label4;
        private TextBox txtTc;
        private Label label3;
        private Button btnAra;
        private Panel panel2;
        private Button button1;
        private Label label2;
    }
}