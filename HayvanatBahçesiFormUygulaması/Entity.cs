using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesiFormUygulaması
{
    public class Hayvan
    {
        public Guid ID { get; set; }
        public string Hayvan_Ad { get; set; }
        public string Turu { get; set; }
        public string Kafesi { get; set; }
        public string Yemi { get; set; }
    }
    public class Calisan
    {
        public Guid ID { get; set; }
        public string Calisan_İsim { get; set; }
        public string Calisan_Soyisim { get; set; }
        public string Calisan_Telefon { get; set; }
        public string Pozisyon { get; set; }
        public Hayvan Hayvan { get; set; }

    }
    public class ziyaretciler
    {
        public Guid ID { get; set; }
        public Guid HayvanID { get; set; }
        public string Ziyaretci_İsim { get; set; }
        public string Ziyaretci_Soyisim { get; set; }
        public string Ziyaretci_Yasi { get; set; }
        public string Ziyaretci_Telefon { get; set; }

    }
    public class biletler
    {
        public Guid ID { get; set; }
        public Hayvan Hayvan { get; set; }
        public ziyaretciler ziyaretciler { get; set; }
        public string Bilet_Numarası { get; set; }
        public string Bilet_Fiyatı { get; set; }

    }
}
