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
    public partial class Yetkili_form : Form
    {
        private List<Ogrenci> ogrenciListesi = new List<Ogrenci>
    {
        new Ogrenci("Ahmet Yılmaz", "Matematik", "Memati Hoca"),
        new Ogrenci("Mehmet Demir", "Fizik", "Murat Hoca"),
        new Ogrenci("Ayşe Kaya", "Kimya", "Kerim Hoca"),
        new Ogrenci("Fatma Çelik", "Biyoloji", "Zülfikar Hoca"),
        new Ogrenci("Ali Kuh", "C#","Güncel Sarıman"),
        new Ogrenci("Ali Can", "C#", "Ali Hoca"),
        new Ogrenci("Emine Öztürk", "Java", "Esra Hoca"),
        new Ogrenci("Serkan Eren", "Python", "Meryem Hoca"),
        new Ogrenci("Seda Güneş", "Veritabanı Yönetimi", "Seda Hoca"),
        new Ogrenci("Zeynep Çelik", "Mikroekonomi", "İsmail Hoca"),
        new Ogrenci("Mustafa Koç", "Makroekonomi", "Dilek Hoca"),
    };

        private void PopulateOgrenciComboBox()
        {
            comboBox3.Items.AddRange(ogrenciListesi.Select(o => o.AdSoyad).ToArray());
        }
        private void GuncelleTumListeLabel()
        {
            string tumListe = string.Join("\n", ogrenciListesi.Select(o => $"{o.AdSoyad} - {o.Ders} ({o.Egitmen})"));
            label7.Text = tumListe;
        }

        public Yetkili_form()
        {
            InitializeComponent();
            PopulateOgrenciComboBox();
            GuncelleTumListeLabel();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yetkili_form_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Clear(); 
            foreach (var ogrenci in ogrenciListesi)
            {
                comboBox3.Items.Add(ogrenci.AdSoyad); 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenOgrenci = comboBox3.SelectedItem?.ToString();
            if (secilenOgrenci == null) return;

            var ogrenci = ogrenciListesi.FirstOrDefault(o => o.AdSoyad == secilenOgrenci);

            if (ogrenci != null)
            {
                label2.Text = $"Ders: {ogrenci.Ders}\nEğitmen: {ogrenci.Egitmen}";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
