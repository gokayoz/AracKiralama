using AracKiralama.UI.Models;
using MaterialSkin.Controls;

namespace AracKiralama.UI
{
    public partial class KiralamaEkrani : MaterialForm
    {
        private List<Araba> arabalar = new();
        public KiralamaEkrani()
        {
            InitializeComponent();
            Araclar();
        }

        public void Araclar()
        {
            cmbAracSecimi.SelectedIndexChanged -= cmbAracSecimi_SelectedIndexChanged;

            arabalar.Add(new Araba
            {
                Model = "Toyota Corolla",
                Marka = "Toyota",
                Renk = "Beyaz",
                GunlukUcret = 150,
                Musaitlik = true,
                AracTipi = AracTipi.Sedan
            });

            arabalar.Add(new Araba
            {
                Model = "BMW X5",
                Marka = "BMW",
                Renk = "Siyah",
                GunlukUcret = 400,
                Musaitlik = true,
                AracTipi = AracTipi.SUV
            });

            arabalar.Add(new Araba
            {
                Model = "Volkswagen Golf",
                Marka = "Volkswagen",
                Renk = "Kýrmýzý",
                GunlukUcret = 200,
                Musaitlik = true,
                AracTipi = AracTipi.Hatchback
            });

            arabalar.Add(new Araba
            {
                Model = "Audi A4",
                Marka = "Audi",
                Renk = "Gri",
                GunlukUcret = 250,
                Musaitlik = true,
                AracTipi = AracTipi.Sedan
            });

            arabalar.Add(new Araba
            {
                Model = "Mercedes-Benz E-Class",
                Marka = "Mercedes-Benz",
                Renk = "Beyaz",
                GunlukUcret = 350,
                Musaitlik = true,
                AracTipi = AracTipi.Sedan
            });

            arabalar.Add(new Araba
            {
                Model = "Ford Focus",
                Marka = "Ford",
                Renk = "Mavi",
                GunlukUcret = 180,
                Musaitlik = true,
                AracTipi = AracTipi.Hatchback
            });

            arabalar.Add(new Araba
            {
                Model = "Chevrolet Tahoe",
                Marka = "Chevrolet",
                Renk = "Siyah",
                GunlukUcret = 420,
                Musaitlik = true,
                AracTipi = AracTipi.SUV
            });

            arabalar.Add(new Araba
            {
                Model = "Honda Civic",
                Marka = "Honda",
                Renk = "Yeþil",
                GunlukUcret = 160,
                Musaitlik = true,
                AracTipi = AracTipi.Sedan
            });

            arabalar.Add(new Araba
            {
                Model = "Porsche 911",
                Marka = "Porsche",
                Renk = "Kýrmýzý",
                GunlukUcret = 600,
                Musaitlik = true,
                AracTipi = AracTipi.Coupe
            });

            arabalar.Add(new Araba
            {
                Model = "Tesla Model S",
                Marka = "Tesla",
                Renk = "Gümüþ",
                GunlukUcret = 500,
                Musaitlik = true,
                AracTipi = AracTipi.Electric
            });

            cmbAracSecimi.DataSource = arabalar;
            cmbAracSecimi.DisplayMember = "Model";
            cmbAracSecimi.ValueMember = "Model";

            cmbAracSecimi.SelectedItem = null;

            cmbAracSecimi.SelectedIndexChanged += cmbAracSecimi_SelectedIndexChanged;
        }
      
        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGunSayisi.Text))
            {
                MessageBox.Show("Gün sayýsý giriniz!");
                return;
            }

            Araba secilenAraba = cmbAracSecimi.SelectedItem as Araba;

            if (secilenAraba != null && secilenAraba.Musaitlik)
            {
                if (int.TryParse(txtGunSayisi.Text, out int gunSayisi))
                {
                    KiralamaBilgisi kiralamaBilgisi = new()
                    {
                        Arac = secilenAraba,
                        GunSayisi = gunSayisi
                    };

                    kiralamaBilgisi.ToplamUcretHesapla();

                    lblModel.Text = $"Model: {secilenAraba.Model}";
                    lblMarka.Text = $"Marka: {secilenAraba.Marka}";
                    lblRenk.Text = $"Renk: {secilenAraba.Renk}";
                    lblGunlukUcret.Text = $"Günlük Ücret: {secilenAraba.GunlukUcret}TL";
                    lblToplamUcret.Text = $"Toplam Kiralama Ücretiniz: {kiralamaBilgisi.ToplamUcret}TL";
                }
                else
                {
                    MessageBox.Show("Geçerli bir gün sayýsý giriniz!");
                }
            }
        }

        private void cmbAracSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Araba secilenAraba = cmbAracSecimi.SelectedItem as Araba;

            if (secilenAraba != null)
            {
                secilenAraba.AracBilgilerGoster();
            }
        }
    }
}
