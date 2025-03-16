using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.UI.Models
{
    public class Araba : IArac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }
        public string Renk { get; set; }
        public int GunlukUcret { get; set; }
        public bool Musaitlik { get; set; }
        public AracTipi AracTipi { get; set; }

        public void AracBilgilerGoster()
        {
            MessageBox.Show($"Model: {Model}\n" +
                $"Marka: {Marka}\n" +
                $"Renk: {Renk}\n" +
                $"Günlük Ücret: {GunlukUcret}\n" +
                $"Müsaitlik Durumu: {(Musaitlik ? "Müsait" : "Kiralanmış")}");
        }
    }
}
