using Bankowosc.Model;

namespace Bankowosc.BramkiBank
{
    public class OperacjeBankowe
    {

        protected bool SprawdzSrodki(double kwota, Konto konto)
        {
            if (konto.Stankonta >= kwota)
                return true;
            return false;
        }

        protected bool Wyplata(double kwota, Konto konto)
        {
            if (SprawdzSrodki(kwota, konto) == false)
                return false;
            konto.Stankonta -= kwota;
            return true;
        }
    }
}