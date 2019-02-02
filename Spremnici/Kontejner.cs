namespace Spremnici
{
    public class Kontejner : Spremnik
    {
        public new void dodaj(int komada)
        {
            if (popunjenost + komada > kapacitet)
            {
                System.ArgumentException popunjenSpremnik = new System.ArgumentException("Kontejner je pun");
                throw popunjenSpremnik;
            }
            else
            {
                {
                    if (komada < 5 || komada > 10)
                    {
                        System.ArgumentException kriviBrojKomada = new System.ArgumentException("Previše ili premalo komada");
                        throw kriviBrojKomada;
                    }
                    else
                    {
                        popunjenost += komada;
                    }
                }
            }
        }
        
        public new void isprazni(int komada)
        {
            if (popunjenost-komada < 0)
            {
                System.ArgumentException prazanSpremnik = new System.ArgumentException("Kontejner je prazan");
                throw prazanSpremnik;
            }
            else
            {
                if (komada < 5 || komada > 10)
                {
                    System.ArgumentException kriviBrojPraznjenjaKomada = new System.ArgumentException("Previše ili premalo komada");
                    throw kriviBrojPraznjenjaKomada;
                }
                else
                {
                    popunjenost -= komada;
                }
            }
    }
}