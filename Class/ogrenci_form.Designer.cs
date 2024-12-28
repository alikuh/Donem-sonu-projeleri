
namespace Class
{
    partial class ogrenci_form
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
            exit2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
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
            panel1.Controls.Add(exit2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Showcard Gothic", 16.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(534, 36);
            label1.TabIndex = 1;
            label1.Text = "Bütünsel Akademi: Ögrenci kayıt";
            // 
            // exit2
            // 
            exit2.BackColor = Color.Brown;
            exit2.Dock = DockStyle.Right;
            exit2.Location = new Point(971, 0);
            exit2.Name = "exit2";
            exit2.Size = new Size(40, 40);
            exit2.TabIndex = 0;
            exit2.Text = "X";
            exit2.UseVisualStyleBackColor = false;
            exit2.Click += exit2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 467);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(223, 251);
            button1.Name = "button1";
            button1.Size = new Size(99, 67);
            button1.TabIndex = 2;
            button1.Text = "kayıt yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 1;
            label5.Text = "EGitimci :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 1;
            label4.Text = "Ders :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 1;
            label2.Text = "Katagori :";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(171, 175);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 0;
            comboBox3.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Matematik", "Fizik", "Kimya", "Biyoloji", "C#", "Java", "Python", "Veritabanı Yönetimi", "Mikroekonomi", "Makroekonomi", "Finansal ", "Yönetim", "Muhasebe", "Türk Edebiyatı", "Dünya Edebiyatı", "Şiir Analizi", "Tiyatro Tarihi" });
            comboBox2.Location = new Point(171, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lise Dersleri", "Yazılım Dersleri", "Ekonomi Dersleri", "Edebiyat Dersleri" });
            comboBox1.Location = new Point(171, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(461, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 467);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aqua;
            label3.Location = new Point(140, 53);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 0;
            label3.Text = "kayıt ekranı";
            // 
            // ogrenci_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1011, 507);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ogrenci_form";
            Text = "ogrenci_form";
            Load += ogrenci_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private void ogrenci_form_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        #endregion

        private Panel panel1;
        private Button exit2;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel3;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
    }
}