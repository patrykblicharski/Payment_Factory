using Bankowosc.Enum;
using Bankowosc.Model;

namespace Bankowosc.Interface
{
    public interface IKonto
    {
        Klient Klient { get; }
        eNazwyBankow NazwaBanku { get; }
        int NumerKonta { get; }
        double StanKonta { get; set; }
        
    }
}