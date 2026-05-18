namespace HastaneRandevuOtomasyonu
{
    partial class HastaGirisPaneli
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
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            txtHastaSifre = new TextBox();
            txtHastaTC = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(265, 101);
            label2.Name = "label2";
            label2.Size = new Size(222, 29);
            label2.TabIndex = 12;
            label2.Text = "Hasta Giriş Paneli";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 49);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(661, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(50, 49);
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
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 1;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // button3
            // 
            button3.BackColor = Color.CornflowerBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(297, 297);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(170, 40);
            button3.TabIndex = 22;
            button3.Text = "GİRİŞ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumAquamarine;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(191, 434);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(95, 40);
            button2.TabIndex = 21;
            button2.Text = "GERİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtHastaSifre
            // 
            txtHastaSifre.Location = new Point(252, 227);
            txtHastaSifre.Margin = new Padding(3, 4, 3, 4);
            txtHastaSifre.Name = "txtHastaSifre";
            txtHastaSifre.Size = new Size(260, 27);
            txtHastaSifre.TabIndex = 20;
            // 
            // txtHastaTC
            // 
            txtHastaTC.Location = new Point(252, 174);
            txtHastaTC.Margin = new Padding(3, 4, 3, 4);
            txtHastaTC.Name = "txtHastaTC";
            txtHastaTC.Size = new Size(260, 27);
            txtHastaTC.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(181, 229);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 18;
            label4.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(193, 176);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 17;
            label3.Text = "TC:";
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(332, 434);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(106, 40);
            button4.TabIndex = 23;
            button4.Text = "ÜYE OL";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(297, 391);
            label8.Name = "label8";
            label8.Size = new Size(173, 16);
            label8.TabIndex = 37;
            label8.Text = "İlk giriş için Üye Ol’a tıklayın.";
            label8.Click += label8_Click;
            // 
            // HastaGirisPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 549);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtHastaSifre);
            Controls.Add(txtHastaTC);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HastaGirisPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaGirisPaneli";
            Load += HastaGirisPaneli_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button2;
        private TextBox txtHastaSifre;
        private TextBox txtHastaTC;
        private Label label4;
        private Label label3;
        private Button button4;
        private Label label8;
    }
}