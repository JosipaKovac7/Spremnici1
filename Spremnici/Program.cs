using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spremnici
{
    class Program
    {
        static void Main(string[] args)
            {
                Spremnik spremnik1 = new Spremnik();
                Kontejner kontejner1 = new Kontejner();

                spremnik1.postaviNaziv("Spremnik br. 1");
                spremnik1.postaviKapacitet(5);

            
                while (true)
                {
                    spremnik1.dodaj(1);
                    Console.WriteLine("Punim " + spremnik1.naziv + " za 1. Trenutna popunjenost: " + spremnik1.vratiPopunjenost());
                }
        }
    }
}
