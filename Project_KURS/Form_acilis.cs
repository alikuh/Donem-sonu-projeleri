using Class;

namespace Project_KURS
{
    public partial class Form_acilis : Form
    {




        public void Kaydet()
        {

        }

        public Form_acilis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_yetkili.Visible = !panel_yetkili.Visible;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel_ogrnci.Visible = !panel_ogrnci.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_egitim.Visible = !panel_egitim.Visible;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox11.Clear();
        }
        List<Class.ogrenci> liste_ogrenci = new List<Class.ogrenci>();
        private void button5_Click(object sender, EventArgs e)
        {

            
            ogrenci yeni_ogrenci = new ogrenci()
            {
                ad = textBox1.Text.Trim(),
                soyad = textBox2.Text.Trim(),
                telNo = textBox3.Text.Trim(),
                yas = int.TryParse(textBox4.Text.Trim(), out int yas) ? yas : 0,
                tcNo = textBox11.Text.Trim()
            };

            // Öðrenci bilgilerini doðrula
            if (!yeni_ogrenci.KontrolAdSoyad())
            {
                MessageBox.Show("Ad ve Soyad alanlarý boþ olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!yeni_ogrenci.KontrolTelNo())
            {
                MessageBox.Show("Geçerli bir telefon numarasý giriniz (10 haneli, rakamlar yalnýzca)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!yeni_ogrenci.KontrolYas())
            {
                MessageBox.Show("Yaþ geçerli bir sayý olmalý ve 10'ten küçük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!yeni_ogrenci.KontrolTcNo())
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarasý giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            liste_ogrenci.Add(yeni_ogrenci);

            
            MessageBox.Show("Öðrenci baþarýyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            temizle();

            
            ogrenci_form ogrenci_form = new ogrenci_form();
            ogrenci_form.Show();

        }
        public void temizle2()
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox12.Clear();
        }
        public static List<Class.egitimci_sayfa> liste_egitimci = new List<Class.egitimci_sayfa>();

        public void button6_Click(object sender, EventArgs e)
        {
            egitimci_sayfa yeni_egitimci = new egitimci_sayfa()
            {
                ad = textBox5.Text.Trim(),
                soyad = textBox6.Text.Trim(),
                telNo = textBox7.Text.Trim(),
                yas = int.TryParse(textBox8.Text.Trim(), out int yas) ? yas : 0,
                tcNo = textBox12.Text.Trim()
            };

            if (!yeni_egitimci.kontrolAdSoyad())
            {
                MessageBox.Show("Ad ve Soyad alanlarý boþ olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!yeni_egitimci.kontrolTelNo())
            {
                MessageBox.Show("Geçerli bir telefon numarasý giriniz (10 haneli, rakamlar yalnýzca)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!yeni_egitimci.kontrolYas())
            {
                MessageBox.Show("Yaþ geçerli bir sayý olmalý ve 80'den büyük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!yeni_egitimci.kontrolTcNo())
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarasý giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            egitimci_form egitimci_Form = new egitimci_form(liste_egitimci, textBox5.Text, textBox6.Text, textBox7.Text, int.Parse(textBox8.Text), textBox12.Text);
            egitimci_Form.Show();
            MessageBox.Show("Eðitimci baþarýyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle2();
        }


        List<Class.yetkili_sayfa> liste_yetkili = new List<Class.yetkili_sayfa>();
        private object comboBox1;
        private object comboBox2;

        private void button7_Click(object sender, EventArgs e)
        {
            string girilenEmail = textBox9.Text.Trim();
            string girilenSifre = textBox10.Text.Trim();

           
            yetkili_sayfa dogruYetkili = new yetkili_sayfa("alikuh3131", "12345678");

          
            if (girilenEmail == dogruYetkili.e_posta && girilenSifre == dogruYetkili.sifre)
            {
               
                Yetkili_form yetkiliForm = new Yetkili_form();
                yetkiliForm.Show();
            }
            else
            {
                
                MessageBox.Show("E-posta veya þifre yanlýþ!", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
