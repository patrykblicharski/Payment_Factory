using System;
using Bankowosc.Interface;
using Bankowosc.Model;

namespace Bankowosc.BramkiBank
{
    public class mBank : IBramkaBanku
    {
        public void DokonajPlatnosci(Produkt produkt)
        {
            Console.WriteLine("->Instancja bramki {0}",GetType());
        }
    }
}