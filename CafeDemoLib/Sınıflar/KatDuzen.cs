using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDemoLib.Sınıflar
{
    public class KatDuzen
    {
        public KatDuzen()
        {
            KatId= Guid.NewGuid().ToString();
        }
        public bool Durum { get; set; }
        public int MasaSayisi { get; set; }
        public string KatId { get; set; }
        public string Adi { get; set; }
        public int KatNo { get; set; }
    }
}
