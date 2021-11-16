using CafeDemoLib.Data;

namespace CafeDemoLib.Sınıflar
{
    public class Urunler
    {
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public string Kategori { get; set; }
        public byte[] Resim { get; set; }
        public bool Durum { get; set; }
    }
}
