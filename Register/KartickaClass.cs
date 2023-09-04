using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    class KartickaClass
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string brKarticka { get; set; }
        public string EXPdate { get; set; }
        public int sostojba { get; set; }

         public KartickaClass()
        {
        }
        public KartickaClass(string ime, string prezime, string brKarticka, string eXPdate, int sostojba)
        {
            Ime = ime;
            Prezime = prezime;
            this.brKarticka = brKarticka;
            EXPdate = eXPdate;
            this.sostojba = sostojba;
        }

       
    }
}
