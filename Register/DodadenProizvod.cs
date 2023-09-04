using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    class DodadenProizvod
    {
        public string Artikl { get; set; }

        public decimal Cena { get; set; }

        public decimal Kolicina { get; set; }

        public DodadenProizvod()
        {
        }

        public DodadenProizvod(string artikl, decimal cena, decimal kolicina)
        {
            Artikl = artikl;
            Cena = cena;
            Kolicina = kolicina;
        }

        public override string ToString()
        {
            return $"{Artikl} {Cena}ден.Количина:{Kolicina}";
        }

        //public string Printer ()
        //{
        //    return $"{Artikl}.....{Cena}денари\n";
        //    return $"Количина:{Kolicina}";
        //}
    }



}
