using System;
using Bankowosc.Enum;
using Bankowosc.Interface;
using Bankowosc.Model;

namespace Bankowosc
{
    public class ProcesorPlatnosci
    {
        private IBramkaBanku bramka;

        public void ProcesujPlatnoscProdukt(eNazwyBankow enuBanku, Produkt produkt)
        {

            BramkaPlatnosciFabryka fabryka = new BramkaPlatnosciFabryka();
                bramka = fabryka.UtworzBramkeBanku(enuBanku);
                bramka.DokonajPlatnosci(produkt);


        }
    }
}