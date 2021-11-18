using CafeDemoLib.Data;
using System;

namespace CafeDemoLib.Sınıflar
{
    public class Urun
    {
        public Urun()
        {
            UrunId= Guid.NewGuid().ToString();
        }
        public string  UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public string Kategori { get; set; }
        public byte[] Resim { get; set; }
        public bool Durum { get; set; }
    }
}
