using System;
using System.Collections.Generic;
using Bankowosc.Db;
using Bankowosc.Model;
using Bankowosc.Enum;
namespace Bankowosc
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Produkt produkt = new Produkt("Klawiatura", "Trwała, wygodna, produkcji Amerykańskiej", 179);
            

            //ProcesorPlatnosci procesorPlatnosci = new ProcesorPlatnosci();
            //procesorPlatnosci.ProcesujPlatnoscProdukt(eNazwyBankow.mBank, produkt);

            //------------------------------------------------------------------

            List<Konto> listaKont = ListaKont.PobierzKonta();

            KoszykPlatnosci koszykPlatnosci = new KoszykPlatnosci();
            koszykPlatnosci.Koszyk.Add(new Produkt("Myszka","Jezdzi po stole",129));
            koszykPlatnosci.Koszyk.Add(new Produkt("Sluchawki","Lezy na uszach",49));
            koszykPlatnosci.Koszyk.Add(new Produkt("Kabel USB","Wisi z gniazda",55));


           
            // Console.WriteLine(koszykPlatnosci.Sumakoszyka());
            Console.WriteLine(koszykPlatnosci.ZwrocListe());

            Console.ReadLine();

            ProcesorPlatnosci procesorPlatnosci = new ProcesorPlatnosci();
            procesorPlatnosci.ProcesujKoszykPlatnosci(listaKont[0],koszykPlatnosci.Koszyk);
            
            Console.ReadLine();
        }
    }
}
