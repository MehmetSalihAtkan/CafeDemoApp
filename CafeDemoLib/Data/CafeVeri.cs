using CafeDemoLib.Models;
using CafeDemoLib.Sınıflar;
using System.Collections.Generic;

namespace CafeDemoLib.Data
{
    public class CafeVeri
    {
        public int MasaAdet { get; set; }
        public List<Urun> Urunler { get; set; } = new List<Urun>();
    }
}
