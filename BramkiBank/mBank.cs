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
            Console.WriteLine("->>Dokonywanie płatnosci za towar:");
            Console.WriteLine("Nazwa:{0}\nOpis:{1}\nCena:{2}");
            

        }
        ~mBank()
        {
            Console.WriteLine("->Instancja dokonała żywota");
        }
    }
}