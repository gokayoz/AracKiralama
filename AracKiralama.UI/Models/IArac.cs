using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.UI.Models
{
    public interface IArac
    {
        string Marka { get; set; }
        string Model { get; set; }
        int ModelYili { get; set; }
        string Renk { get; set; }
        int GunlukUcret { get; set; }
        bool Musaitlik { get; set; }
        AracTipi AracTipi { get; set; }
        void AracBilgilerGoster();
    }
}
