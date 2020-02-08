using System;
using System.Collections.Generic;
using Bankowosc.Model;

namespace Bankowosc
{
    public class KoszykPlatnosci
    {
        public List<Produkt> Koszyk = new List<Produkt>();

        public double Sumakoszyka()
        {
            double suma = 0;
            foreach (Produkt produkt in Koszyk)
            {
                suma += produkt.Cena;
            }

            return suma;
        }

        public string ZwrocListe()
        {
            string temp = "";
            int i = 0;

            Console.WriteLine("\n###############KOSZYK###############");

            foreach (Produkt produkt in Koszyk)
            {
                temp += "|"+i+"|Nazwa:" + produkt.Nazwa + "\n|||Opis:" + produkt.Opis + "\n|||Cena:" + produkt.Cena+"\n-------\n";
                i++;
            }

            temp += "\t\t\t\t\tSuma koszyka:"+Sumakoszyka() + "zł\n";
            temp += "###############KOSZYK###############";
            return temp;
        }

    }
}