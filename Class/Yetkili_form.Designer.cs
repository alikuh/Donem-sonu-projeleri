namespace Class
{
    partial class Yetkili_form
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
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            exit3 = new Button();
            panel3 = new Panel();
            label7 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 413);
            panel2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(142, 51);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 51);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 0;
            label5.Text = "öğrenci arat:";
            label5.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exit3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 40);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Showcard Gothic", 16.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(428, 36);
            label1.TabIndex = 1;
            label1.Text = "Bütünsel Akademi: Yetkili";
            // 
            // exit3
            // 
            exit3.BackColor = Color.Brown;
            exit3.Dock = DockStyle.Right;
            exit3.Location = new Point(953, 0);
            exit3.Name = "exit3";
            exit3.Size = new Size(40, 40);
            exit3.TabIndex = 0;
            exit3.Text = "X";
            exit3.UseVisualStyleBackColor = false;
            exit3.Click += exit3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(349, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(644, 413);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 79);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 0;
            label7.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 28);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci";
            // 
            // Yetkili_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(993, 453);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Yetkili_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yetkili_form";
            Load += Yetkili_form_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button exit3;
        private Panel panel3;
        private Label label2;
        private ComboBox comboBox3;
        private Label label5;
        private Label label7;
    }
}