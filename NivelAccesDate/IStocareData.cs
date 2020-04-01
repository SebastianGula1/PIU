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
        Pharmacy[] GetM(out int nrMed);
    }
}
