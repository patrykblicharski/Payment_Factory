namespace Bankowosc.Model
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public double Cena { get; set; }
        
        public Produkt(string nazwa, string opis, double cena)
        {
            Nazwa = nazwa;
            Opis = opis;
            Cena = cena;
        }
    }

}