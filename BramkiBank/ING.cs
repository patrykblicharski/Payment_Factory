using System;
using Bankowosc.Interface;
using Bankowosc.Model;

namespace Bankowosc.BramkiBank
{
    public class ING : OperacjeBankowe, IBramkaBanku
    {
        public void DokonajPlatnosci(Produkt produkt, Konto konto)
        {

            Console.WriteLine("--->Instancja bramki {0}", GetType());
            Console.WriteLine("---->Sprawdzanie srodkow na koncie");
            if (Wyplata(produkt.Cena, konto))
                Console.WriteLine("---->Pobrano platnosc");
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!ODRZUT!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!BRAK SRODKOW!!!!!!!!!!!!!!");
            }
        }
    }
}