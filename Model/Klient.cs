using Bankowosc.Interface;

namespace Bankowosc.Model
{
    public class Klient: IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }

        public Klient(string imie, string nazwisko, string email)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            Email = email;
        }
    }
}