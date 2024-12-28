
namespace Class
{
    partial class egitimci_form
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
            label1 = new Label();
            exit3 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exit3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 40);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Showcard Gothic", 16.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(542, 36);
            label1.TabIndex = 1;
            label1.Text = "Bütünsel Akademi: Egitimci kayıt";
            // 
            // exit3
            // 
            exit3.BackColor = Color.Brown;
            exit3.Dock = DockStyle.Right;
            exit3.Location = new Point(971, 0);
            exit3.Name = "exit3";
            exit3.Size = new Size(40, 40);
            exit3.TabIndex = 0;
            exit3.Text = "X";
            exit3.UseVisualStyleBackColor = false;
            exit3.Click += exit3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 467);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(155, 258);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
            button1.TabIndex = 2;
            button1.Text = "kaydol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 1;
            label4.Text = "Dersler:";
            label4.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 1;
            label2.Text = "BRANŞLAR:";
            label2.Click += label2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Lise Dersleri", "Yazılım Dersleri", "Ekonomi Dersleri", "Edebiyat Dersleri" });
            comboBox2.Location = new Point(154, 137);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(461, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 467);
            panel3.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Aqua;
            label8.Location = new Point(45, 79);
            label8.Name = "label8";
            label8.Size = new Size(167, 20);
            label8.TabIndex = 0;
            label8.Text = "egitimci bilgileri buraya";
            label8.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Aqua;
            label5.Location = new Point(45, 20);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 0;
            label5.Text = "Egitimci Bilgileri";
            label5.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aqua;
            label3.Location = new Point(45, 145);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 0;
            label3.Text = "kayıt ekranı";
            label3.Click += label3_Click;
            // 
            // egitimci_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1011, 507);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "egitimci_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "egitimci_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private void label3_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void exit3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button exit3;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Button button1;
        private Label label8;
        private Label label5;
    }
}