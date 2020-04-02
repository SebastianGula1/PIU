using Librarie;
using System;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{

    public class AdministrareMedicamente_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareMedicamente_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddM(Pharmacy s)
        {
            throw new Exception("Optiunea nu este implementata");
        }

        public Pharmacy[] GetM(out int nrStudenti)
        {
            throw new Exception("Optiunea nu este implementata");
        }
    }
}
