using Librarie;
using System;
using System.IO;

namespace NivelAccesDate
{

    public class AdministrareMedicamente_FisierText : IStocareData
    {
        private const int PAS_ALOCARE = 10;
        string NumeFisier { get; set; }
        public AdministrareMedicamente_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            
        }
        public void AddM(Pharmacy s)
        {
            try
            {
                
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(s.ConversieLaSir_Fisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public Pharmacy[] GetM(out int nr)
        {
            Pharmacy[] medicamente = new Pharmacy[PAS_ALOCARE];

            try
            {
                
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    nr = 0;

                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        medicamente[nr++] = new Pharmacy(line);
                        if (nr == PAS_ALOCARE)
                        {
                            Array.Resize(ref medicamente, nr + PAS_ALOCARE);
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return medicamente;
        }
    }
}