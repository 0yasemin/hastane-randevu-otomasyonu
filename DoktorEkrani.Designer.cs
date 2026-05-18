namespace HastaneRandevuOtomasyonu
{
    partial class DoktorEkrani
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
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            panel1.Size = new Size(1120, 50);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1070, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 1;
            label1.Text = "Doktor Ekranı";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(783, 379);
            dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 72);
            label2.Name = "label2";
            label2.Size = new Size(276, 29);
            label2.TabIndex = 12;
            label2.Text = "Randevu Alan Hastalar";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumAquamarine;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Window;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(920, 126);
            button2.Name = "button2";
            button2.Size = new Size(143, 40);
            button2.TabIndex = 13;
            button2.Text = "TAHLİL İSTE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumAquamarine;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Window;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(920, 239);
            button3.Name = "button3";
            button3.Size = new Size(143, 40);
            button3.TabIndex = 14;
            button3.Text = "TABURCU ET";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumAquamarine;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Window;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(920, 359);
            button4.Name = "button4";
            button4.Size = new Size(143, 40);
            button4.TabIndex = 15;
            button4.Text = "YATIŞ VER";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.CornflowerBlue;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button5.ForeColor = SystemColors.Window;
            button5.Location = new Point(948, 465);
            button5.Name = "button5";
            button5.Size = new Size(86, 40);
            button5.TabIndex = 17;
            button5.Text = "GERİ";
            button5.UseVisualStyleBackColor = false;
            // 
            // DoktorEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 563);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoktorEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorEkrani";
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
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}