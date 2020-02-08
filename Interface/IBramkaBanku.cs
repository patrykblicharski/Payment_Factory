using Bankowosc.Model;

namespace Bankowosc.Interface
{
    public interface IBramkaBanku
    {
        void DokonajPlatnosci(Produkt produkt, Konto konto);
        
        //list of products (koszyk)
    }
}