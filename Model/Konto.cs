using System;
using Bankowosc.Enum;
using Bankowosc.Interface;

namespace Bankowosc.Model
{
    public class Konto:IKonto
    {
        public Klient Klient { get; }
        public eNazwyBankow NazwaBanku { get; }
        public int NumerKonta { get; }
        public double StanKonta { get; set; }
        public double Stankonta { get; set; }



        public Konto(Klient klient, eNazwyBankow nazwaBanku)
        {
            this.Klient = klient;
            this.NazwaBanku = nazwaBanku;
            this.NumerKonta = 0; //Generator
            this.Stankonta = 0;
        }


        public Konto(Klient klient, int numerkonta, int stankonta, eNazwyBankow nazwaBanku)
        {
            this.Klient = klient;
            if (numerkonta % 2 == 0)
                this.NumerKonta = numerkonta;
            else
                throw new Exception();


            this.Stankonta = stankonta;
            this.NazwaBanku = nazwaBanku;
        }
    }
}