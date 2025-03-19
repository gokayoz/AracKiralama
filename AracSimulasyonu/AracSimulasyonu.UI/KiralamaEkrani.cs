using AracSimulasyonu.UI.Core;
using AracSimulasyonu.UI.Enums;
using AracSimulasyonu.UI.Interfaces;
using MaterialSkin.Controls;
using MaterialSkin;

namespace AracSimulasyonu.UI
{
    public partial class KiralamaEkrani : MaterialForm
    {
        private List<IArac> Araclar = new();
        private List<KiralamaBilgisi> KiralananAraclar = new();

        public KiralamaEkrani()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; 
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500,      
                Primary.Teal700,    
                Primary.Teal200,      
                Accent.Orange400,     
                TextShade.WHITE);     
        }

        private void KiralamaEkrani_Load(object sender, EventArgs e)
        {
            Araclar = new List<IArac>
            {
                new Araba("Toyota Corolla", AracTipi.Sedan, 500),
                new Araba("BMW X5", AracTipi.SUV, 1200),
                new Araba("Volkswagen Golf", AracTipi.Hatchback, 600),
                new Araba("Audi A5", AracTipi.Coupe, 900),
                new Araba("Ford Mustang", AracTipi.Cabriolet, 1500),
                new Araba("Toyota Hilux", AracTipi.Pickup, 850),
                new Araba("Mercedes Vito", AracTipi.Minivan, 700),
                new Araba("Volvo V60", AracTipi.StationWagon, 750),
                new Araba("Honda Civic", AracTipi.Sedan, 550),
                new Araba("Nissan Qashqai", AracTipi.SUV, 950),
                new Araba("Ducati Panigale", AracTipi.Motorsiklet, 400),
                new Araba("Renault Kangoo", AracTipi.Panelvan, 650),
                new Araba("Beneteau Oceanis", AracTipi.Yelkenli, 5000),
                new Araba("Sunseeker Predator", AracTipi.MotorYat, 15000),
                new Araba("Volkswagen California", AracTipi.Karavan, 1200),
                new Araba("Scania R500", AracTipi.Çekici, 2000),
                new Araba("Yamaha Raptor", AracTipi.ATV, 700),
                new Araba("Hyundai Elantra", AracTipi.Sedan, 520),
                new Araba("Land Rover Discovery", AracTipi.SUV, 1100),
                new Araba("Opel Astra", AracTipi.Hatchback, 580)
            };
            foreach (var arac in Araclar)
            {
                cmbAraclar.Items.Add(arac.AracBilgisiGoster());
            }
        }
        private void btnKiralamaYap_Click(object sender, EventArgs e)
        {
            if (cmbAraclar.SelectedIndex == -1 || !int.TryParse(txtGunSayisi.Text, out int gunSayisi) || gunSayisi < 0)
            {
                MessageBox.Show("Lütfen bir araç seçiniz veya geçerli bir araç süresi giriniz!");
                return;
            }
            IArac secilenArac = Araclar[cmbAraclar.SelectedIndex];

            if (!secilenArac.MusaitMi)
            {
                MessageBox.Show("Seçili araç þu anda kirada!", "Kiralama Uyarýsý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            decimal toplamUcret = secilenArac.GunlukUcret * gunSayisi;

            if (gunSayisi >= 5)
            {
                toplamUcret *= 0.9m;
            }

            KiralamaBilgisi yeniKiralama = new()
            {
                AracModel = secilenArac.Model,
                GunSayisi = gunSayisi,
                ToplamUcret = toplamUcret
            };

            KiralananAraclar.Add(yeniKiralama);
            lbKiralamaGecmisi.Items.Add(yeniKiralama);

            secilenArac.MusaitMi = false;

            cmbAraclar.Items[cmbAraclar.SelectedIndex] = $"{secilenArac.Model}-" +
                $"{secilenArac.Tip} Günlük Ücret: {secilenArac.GunlukUcret}-Kiralandý. ";

            txtToplamUcret.Text = $"{toplamUcret}";

            MessageBox.Show("Araç baþarýyla kiralandý!", "Kiralama Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
