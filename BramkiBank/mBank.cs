using System;
using System.Runtime.InteropServices;
using Bankowosc.Interface;
using Bankowosc.Model;
using Bankowosc;
using Bankowosc.Tools;
using Microsoft.Win32.SafeHandles;

namespace Bankowosc.BramkiBank
{
    public class mBank : OperacjeBankowe, IBramkaBanku
    {
      

        public void DokonajPlatnosci(Produkt produkt, Konto konto)
        {
                                                                             CColor.ResetCColor();  CColor.SetCcolor(ConsoleColor.DarkRed,ConsoleColor.White); 
            Console.WriteLine("--->Instancja bramki {0}", GetType());
                                                                             CColor.ResetCColor(); CColor.SetCcolor(ConsoleColor.DarkYellow, ConsoleColor.Black);
            Console.WriteLine("---->Sprawdzanie srodkow na koncie");
            if (Wyplata(produkt.Cena, konto))
            {
                                                                                CColor.ResetCColor(); CColor.SetCcolor(ConsoleColor.DarkGreen, ConsoleColor.White);  
                Console.WriteLine("---->Pobrano platnosc: ->{0}", produkt.Cena);
            }
            else
            {
                                                                                CColor.ResetCColor(); CColor.SetCcolor(ConsoleColor.DarkRed, ConsoleColor.White);
                Console.WriteLine("!!!!!!!!!!!!!!!!!ODRZUT!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!BRAK SRODKOW!!!!!!!!!!!!!!");
                                                                                CColor.ResetCColor();
            }
            
            //Console.WriteLine("--->Dokonywanie płatnosci za towar:");
            //Console.WriteLine("\n||Nazwa:{0} \n||Opis:{1} \n||Cena:{2}\n", produkt.Nazwa,produkt.Opis,produkt.Cena);

           
        }





    }


}
