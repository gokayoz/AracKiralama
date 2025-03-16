using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.UI.Models
{
    public class KiralamaBilgisi
    {
        public Araba Arac { get; set; }
        public int GunSayisi { get; set; }
        public decimal ToplamUcret { get; set; }

        public void ToplamUcretHesapla()
        {
            if (Arac.Musaitlik)
            {
                ToplamUcret = Arac.GunlukUcret * GunSayisi;
                Arac.Musaitlik = false;

                MessageBox.Show($"Kiralama Bilgisi:\n" +
                                $"Araç: {Arac.Model}\n" +
                                $"Gün Sayısı: {GunSayisi} gün\n" +
                                $"Toplam Ücret: {ToplamUcret}");
            }
            else
            {
                MessageBox.Show("Araç şuan da kiralanmış!");
                return;
            }
        }
    }
}
