using System;
using System.Runtime.InteropServices;
using Bankowosc.Interface;
using Bankowosc.Model;
using Microsoft.Win32.SafeHandles;

namespace Bankowosc.BramkiBank
{
    public class mBank : IBramkaBanku
    {

        public void DokonajPlatnosci(Produkt produkt)
        {

            Console.WriteLine("--->Instancja bramki {0}", GetType());
            Console.WriteLine("->>Dokonywanie płatnosci za towar:");
            Console.WriteLine(">Nazwa:{0} || Opis:{1} || Cena:{2}", produkt.Nazwa,produkt.Opis,produkt.Cena);
            Console.WriteLine("->>Dokonano płatnosci");
           
        }
        
    }


}
