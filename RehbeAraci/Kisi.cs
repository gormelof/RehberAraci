using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehbeAraci
{
    // Rehberde ki Kişi modelimiz.
    class Kisi
    {
        private string ad;
        private string ikinciAd;
        private string soyad;
        private string cepNo;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string IkıncıAd
        {
            get { return ikinciAd; }
            set { ikinciAd = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string CepNo
        {
            get { return cepNo; }
            set { cepNo = value; }
        }

        public Kisi(string ad, string ikinciAd, string soyad, string cepNo)
        {
            this.ad = ad;
            this.ikinciAd = ikinciAd;
            this.soyad = soyad;
            this.cepNo = cepNo;
        }
    }
}
