using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarie;

namespace NivelAccesDate
{
    public interface IStocareData
    {
        void AddM(Pharmacy x);
        List<Pharmacy> GetMedicamente();
        Pharmacy GetMedicament(string nume);
       Pharmacy[] GetM(out int nrMed);
       bool UpdateMedicament(Pharmacy x);

    }
}
