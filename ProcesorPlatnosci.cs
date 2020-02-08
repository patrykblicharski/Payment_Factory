using System;
using Bankowosc.Enum;
using Bankowosc.Interface;
using Bankowosc.Model;

namespace Bankowosc
{
    public class ProcesorPlatnosci
    {
        
       

        public void ProcesujPlatnoscProdukt(eNazwyBankow enuBanku, Produkt produkt)
        {

            
               using( BramkaPlatnosciFabryka fabryka = new BramkaPlatnosciFabryka())
               {
                IBramkaBanku bramka = fabryka.UtworzBramkeBanku(enuBanku);
                bramka.DokonajPlatnosci(produkt);
               }
                

        }
    }
}