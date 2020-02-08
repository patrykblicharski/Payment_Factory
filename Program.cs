using System;
using Bankowosc.Model;
using Bankowosc.Enum;
namespace Bankowosc
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt = new Produkt();
            produkt.Nazwa = "Klawiatura";
            produkt.Cena = 179;
            produkt.Opis = "Trwała, wygodna, produkcji Amerykańskiej";


            ProcesorPlatnosci procesorPlatnosci = new ProcesorPlatnosci();
            procesorPlatnosci.ProcesujPlatnoscProdukt(eNazwyBankow.mBank, produkt);

            //------------------------------------------------------------------
           
            
            Console.WriteLine("Hello World!");
            
        }
    }
}
