using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDemoLib.Sınıflar
{
    public class RestoranIletisim
    {
        public RestoranIletisim()
        {
            SirketId= Guid.NewGuid().ToString();
        }
        public string SirketAdi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string SirketId { get; set; }
        public  List<KatDuzen> Katlar { get; set; } = new List<KatDuzen>();
    }
}
