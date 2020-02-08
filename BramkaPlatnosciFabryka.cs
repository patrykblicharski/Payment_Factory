using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Bankowosc.BramkiBank;
using Bankowosc.Enum;
using Bankowosc.Interface;
using Microsoft.Win32.SafeHandles;

namespace Bankowosc
{
    public class BramkaPlatnosciFabryka
    {
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