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
            this.bramka = fabryka.UtworzBramkeBanku(enuBanku);
            this.bramka.DokonajPlatnosci(produkt);
            
        }
    }
}