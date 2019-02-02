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
        public void dodaj(int komada)
        {
            if (popunjenost+komada > kapacitet)
            {
                System.ArgumentException popunjenSpremnik = new System.ArgumentException("Spremnik je popunjen");
                throw popunjenSpremnik;
            }
            else
            {
                if (komada < 1 || komada > 3)
                {
                    System.ArgumentException kriviBrojKomada = new System.ArgumentException("Dodali ste previše ili premalo komada");
                    throw kriviBrojKomada;
                }
                else
                {
                    popunjenost += komada;
                }
            }
        }
        public void isprazni(int komada)
        {
        if (popunjenost-komada < 0)
        {
            System.ArgumentException prazanSpremnik = new System.ArgumentException("Spremnik je prazan");
                    throw prazanSpremnik;
            }
            else
            {
                if (komada < 1 || komada > 3)
                {
                    System.ArgumentException kriviBrojPraznjenjaKomada = new System.ArgumentException("Prazni se previše ili premalo komada");
                    throw kriviBrojPraznjenjaKomada;
                }
                else
                {
                    popunjenost -= komada;
                }
            }
        }
        
        public override string ToString()
        {
            return "Spremnik Naziv: " + naziv + " Kapacitet: " + kapacitet.ToString() + " Popunjenost: " + popunjenost.ToString();
        }
    }
}
