namespace Bankowosc.Model
{
    public class Klient
    {
        public string imie { get; }
        public string Nazwisko { get; }

        public string Email { get; }
        public Klient(string imie, string nazwisko, string email)
        {
            this.imie = imie;
            this.Nazwisko = nazwisko;
            Email = email;
        }
    }
}