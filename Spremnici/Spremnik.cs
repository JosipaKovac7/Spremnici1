using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spremnici
{
    class Spremnik
    {
        public string naziv;
        protected decimal kapacitet;
        protected decimal popunjenost;

        public Spremnik()
        {
            kapacitet = 3;
            popunjenost = 0;
        }

        public void postaviKapacitet(decimal _kapacitet)
        {
            kapacitet = _kapacitet;
        }

        public decimal vratiPopunjenost()
        {
            return popunjenost;
        }

        public void postaviNaziv(string _naziv)
        {
            naziv = _naziv;
        }

        public string vratiNaziv()
        {
            return naziv;
        }
        
    }
}
