using System;
using Bankowosc.BramkiBank;
using Bankowosc.Enum;
using Bankowosc.Interface;
using Bankowosc.Tools;

namespace Bankowosc
{
    public class BramkaPlatnosciFabryka:IDisposable
    {
        public void Dispose()
        {
                                                                                            CColor.ResetCColor(); CColor.SetCcolor(ConsoleColor.DarkBlue, ConsoleColor.White);

            Console.WriteLine("--->Uwolniono Instancje bramki {0}", GetType());

                                                                                               CColor.ResetCColor();
        }

        public BramkaPlatnosciFabryka()
        {
                                                                                                CColor.ResetCColor(); CColor.SetCcolor(ConsoleColor.DarkBlue, ConsoleColor.White);

            Console.WriteLine("--->Uwolniono Instancje bramki {0}", GetType());

                                                                                                 CColor.ResetCColor();
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