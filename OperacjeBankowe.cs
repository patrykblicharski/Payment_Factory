using System;
using Bankowosc.Model;
using Bankowosc.Tools;

namespace Bankowosc.BramkiBank
{
    public class OperacjeBankowe: IDisposable
    {
        public void Dispose()
        {
            CColor.ResetCColor(); CColor.SetCcolor(ConsoleColor.DarkBlue, ConsoleColor.White);

            Console.WriteLine("--->Uwolniono Instancje bramki {0}", GetType());

            CColor.ResetCColor();
        }
        protected bool SprawdzSrodki(double kwota, Konto konto)
        {
            if (konto.Stankonta >= kwota)
                return true;
            return false;
        }

        protected bool Wyplata(double kwota, Konto konto)
        {
            if (SprawdzSrodki(kwota, konto) == false)
                return false;
            konto.Stankonta -= kwota;
            return true;
        }
    }
}