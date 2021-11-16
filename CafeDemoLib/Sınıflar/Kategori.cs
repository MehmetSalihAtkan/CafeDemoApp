using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDemoLib.Sınıflar
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string Adi { get; set; }
        public byte[] Resim { get; set; }
        public bool Durum { get; set; }

        public override string ToString() => $"{Adi}";
        
    }
}
