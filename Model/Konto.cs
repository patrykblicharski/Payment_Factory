using System;
using Bankowosc.Enum;

namespace Bankowosc.Model
{
    public class Konto
    {
        public Klient Klient { get; }
        public eNazwyBankow NazwaBanku { get; }
        public int Numerkonta { get; }
        public double Stankonta { get; set; }



        public Konto(Klient klient, eNazwyBankow nazwaBanku)
        {
            this.Klient = klient;
            this.NazwaBanku = nazwaBanku;
            this.Numerkonta = 0; //Generator
            this.Stankonta = 0;
        }


        public Konto(Klient klient, int numerkonta, int stankonta, eNazwyBankow nazwaBanku)
        {
            this.Klient = klient;
            if (numerkonta % 2 == 0)
                this.Numerkonta = numerkonta;
            else
                throw new Exception();


            this.Stankonta = stankonta;
            this.NazwaBanku = nazwaBanku;
        }
    }
}