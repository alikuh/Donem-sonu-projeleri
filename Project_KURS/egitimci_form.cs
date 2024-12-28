using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Class
{

    public partial class egitimci_form : Form
    {
        public List<egitimci_sayfa> liste_egitimci;
        public string secilenBrans;
        public string secilenDers;

        public Dictionary<string, List<string>> bransDersleri = new Dictionary<string, List<string>>()
    {
        { "Lise", new List<string> { "Fizik", "Kimya", "Biyoloji" } },
        { "Yazılım", new List<string> { "C#", "Java", "Python", "Veritabanı Yönetimi" } },
        { "Ekonomi", new List<string> { "Mikroekonomi", "Makroekonomi", "Finansal Yönetim", "Muhasebe" } },
        { "Edebiyat", new List<string> { "Türk Edebiyatı", "Dünya Edebiyatı", "Şiir Analizi", "Tiyatro Tarihi" } }
    };

       
        public egitimci_form(List<egitimci_sayfa> liste_egitimci, string secilenBrans, string text, string text1)
        {
            InitializeComponent();
            this.liste_egitimci = liste_egitimci;

            
            comboBox1.Items.AddRange(bransDersleri.Keys.ToArray());

        }

        public egitimci_form(List<egitimci_sayfa> liste_egitimci, string secilenBrans, string text, string text1, int v, string text2) : this(liste_egitimci, secilenBrans, text, text1)
        {
        }

        
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenBrans = comboBox1.SelectedItem?.ToString();
            if (secilenBrans == null || !bransDersleri.ContainsKey(secilenBrans)) return;

           
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(bransDersleri[secilenBrans].ToArray());
        }

       
        public void yazdir()
        {
            label5.Text = $"Eğitimci Bilgileri:\n";
            label8.Text = $"";

            
            foreach (var egitimci in liste_egitimci)
            {
                label8.Text += $"Ad Soyad: {egitimci.ad} {egitimci.soyad}\n" +
                               $"Telefon: {egitimci.telNo}\n" +
                               $"Yaş: {egitimci.yas}\n" +
                               $"TC No: {egitimci.tcNo}\n\n";  
            }

            label3.Text += $"\n Egitimcinin Branşı: {secilenBrans}\n Egitimcinin Dersi: {secilenDers}";
        }
    

  
        public void button1_Click(object sender, EventArgs e)
        {
            
            string secilenBrans = comboBox1.SelectedItem?.ToString();
            string secilenDers = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(secilenBrans) || string.IsNullOrEmpty(secilenDers))
            {
                MessageBox.Show("Lütfen branş ve ders seçimini yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            label3.Text = $"Branş: {secilenBrans}\nDers: {secilenDers}";
        }


    }

       
    }

