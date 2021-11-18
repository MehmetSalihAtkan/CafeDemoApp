using CafeDemoLib.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDemoLib.Models
{
    public class AyarlarContext
    {
        public static List<UrunAyar> Urunler { get; set; } = new List<UrunAyar>();
        public static List<Kategori> Kategoriler { get; set; } = new List<Kategori>();
        public static List<SiparisDetay> Siparisler { get; set; } = new List<SiparisDetay>();
        public static List<RestoranIletisim> Sirket { get; set; } = new List<RestoranIletisim>();
        public static List<KatDuzen> Katlar { get; set; } = new List<KatDuzen>();

    }
}
