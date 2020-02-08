using System;
using System.Collections.Generic;
using Bankowosc.Enum;
using Bankowosc.Interface;
using Bankowosc.Model;

namespace Bankowosc
{
    public class ProcesorPlatnosci
    {


        public void ProcesujPlatnoscProdukt(Konto konto, Produkt produkt)
        {

            
               using( BramkaPlatnosciFabryka fabryka = new BramkaPlatnosciFabryka())
               {
                IBramkaBanku bramka = fabryka.UtworzBramkeBanku(konto.NazwaBanku);
                bramka.DokonajPlatnosci(produkt,konto);
               }
                

        }

        public void ProcesujKoszykPlatnosci(Konto konto, List<Produkt> koszyk)
        {
            using (BramkaPlatnosciFabryka fabryka = new BramkaPlatnosciFabryka())
            {
                
                IBramkaBanku bramka = fabryka.UtworzBramkeBanku(konto.NazwaBanku);
                foreach (Produkt produkt in koszyk)
                {
                    bramka.DokonajPlatnosci(produkt, konto);
                }
            }
        }
    }
}