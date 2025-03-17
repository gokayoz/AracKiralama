using AracSimulasyonu.UI.Enums;
using AracSimulasyonu.UI.Interfaces;

namespace AracSimulasyonu.UI.Core
{
    public class Araba : IArac
    {
        public Araba(string model, AracTipi tip, decimal gunlukUcret)
        {
            GunlukUcret = gunlukUcret;
            Model = model;
            Tip = tip;
        }
        public string Model { get; }

        public AracTipi Tip { get; }

        public decimal GunlukUcret { get; }

        public bool MusaitMi { get; set; } = true;

        public string AracBilgisiGoster()
        {
            return $"{Model} - {Tip} - {GunlukUcret} - Listelendi.";
        }
    }
}
