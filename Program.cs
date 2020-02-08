using System;
using Bankowosc.Model;
using Bankowosc.Enum;
namespace Bankowosc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProcesorPlatnosci procesorPlatnosci = new ProcesorPlatnosci();
            Produkt produkt = new Produkt();
            produkt.Nazwa = "Klawiatura";
            produkt.Cena = 179;
            produkt.Opis = "Trwała, wygodna, produkcji Amerykańskiej";

            procesorPlatnosci.ProcesujPlatnoscProdukt(eNazwyBankow.mBank,produkt);
            
            //------------------------------------------------------------------
            procesorPlatnosci = null;

            Console.WriteLine("Hello World!");
            
        }
    }
}
