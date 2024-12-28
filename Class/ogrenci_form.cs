using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class ogrenci_form : Form
    {

        public ogrenci_form()
        {
            InitializeComponent();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string secilenDers = comboBox2.SelectedItem.ToString();

                comboBox3.Items.Clear();

                if (dersHoca.ContainsKey(secilenDers))
                {
                    comboBox3.Items.Add(dersHoca[secilenDers]);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir ders seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        Dictionary<string, string> dersHoca = new Dictionary<string, string>
{
    { "Matematik", "Ahmet Yılmaz" },
    { "Fizik", "Mehmet Demir" },
    { "Kimya", "Ayşe Kaya" },
    { "Biyoloji", "Fatma Çelik" },
    { "C#", "Ali kuh" },
    { "Java", "Emine Öztürk" },
    { "Python", "Serkan Eren" },
    { "Veritabanı Yönetimi", "Seda Güneş" },
    { "Mikroekonomi", "Zeynep Çelik" },
    { "Makroekonomi", "Mustafa Koç" },
    { "Finansal Yönetim", "Büşra Şahin" },
    { "Muhasebe", "İbrahim Öz" },
    { "Türk Edebiyatı", "Kemal Aslan" },
    { "Dünya Edebiyatı", "Selin Doğan" },
    { "Şiir Analizi", "Nihal Karaca" },
    { "Tiyatro Tarihi", "Can Yıldız" }
};
        private void button1_Click(object sender, EventArgs e)
        {
            string secilenBrans = comboBox1.SelectedItem?.ToString();
            string secilenDers = comboBox2.SelectedItem?.ToString();
            string secilenHoca = comboBox3.SelectedItem?.ToString();

            
            if (string.IsNullOrEmpty(secilenBrans))
            {
                MessageBox.Show("Lütfen bir branş seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(secilenDers))
            {
                MessageBox.Show("Lütfen bir ders seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            if (string.IsNullOrEmpty(secilenHoca))
            {
                
            }

          
            label3.Text = $"Branş: {secilenBrans}\n" +
                          $"Ders: {secilenDers}\n" +
                          $"Hoca: {secilenHoca}";
        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string secilenDers = comboBox2.SelectedItem.ToString();

              
                comboBox3.Items.Clear();

               
                if (dersHoca.ContainsKey(secilenDers))
                {
                    comboBox3.Items.Add(dersHoca[secilenDers]);  // Hoca ekle
                    MessageBox.Show($"Seçilen dersin hocası: {dersHoca[secilenDers]}"); // Hoca bilgisi ekranda
                }
            }
            
        }
            




        }
    }
