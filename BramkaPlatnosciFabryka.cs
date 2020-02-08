using System;
using Bankowosc.BramkiBank;
using Bankowosc.Enum;
using Bankowosc.Interface;

namespace Bankowosc
{
    public class BramkaPlatnosciFabryka:IDisposable
    {
        public void Dispose()
        {
           Console.WriteLine("--->Czyszczenie instancji bramki...");
        }

        public virtual IBramkaBanku UtworzBramkeBanku(eNazwyBankow wyborBankow)
        {
            IBramkaBanku bramka = null;
            switch (wyborBankow)
            {
                case eNazwyBankow.mBank:
                    bramka = new mBank();
                    break;
                case eNazwyBankow.ING:
                    bramka = new ING();
                    break;
                case eNazwyBankow.PKO:
                    bramka = new PKO();
                    break;
                case eNazwyBankow.Santander:
                    bramka = new Santander();
                    break;
                default:
                    break;
            }

            return bramka;
        }


    }
}