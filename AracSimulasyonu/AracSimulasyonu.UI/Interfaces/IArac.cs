using AracSimulasyonu.UI.Enums;

namespace AracSimulasyonu.UI.Interfaces
{
    public interface IArac
    {
        string Model { get; }
        AracTipi Tip { get; }
        decimal GunlukUcret { get; }
        bool MusaitMi { get; set; }
        string AracBilgisiGoster();
    }
}
