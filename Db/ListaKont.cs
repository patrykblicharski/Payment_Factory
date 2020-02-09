using System.Collections.Generic;
using Bankowosc.Enum;
using Bankowosc.Model;

namespace Bankowosc.Db
{
    public static class ListaKont
    {
        

        public static List<Konto> PobierzKonta()
        {
         List<Konto> ListaKont = new List<Konto>();

            ListaKont.Add(new Konto(new Klient("Patryk", "Blicharski", "blacha14@gmail.com"),2227772,500, eNazwyBankow.mBank ));
            ListaKont.Add(new Konto(new Klient("Benek", "Pierdoła", "głupi@chuj.com"), 333452,20, eNazwyBankow.Santander ));


        return ListaKont;
    }
    }
}