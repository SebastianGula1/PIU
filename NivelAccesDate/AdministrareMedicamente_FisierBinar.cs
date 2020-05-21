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
        public List<Pharmacy> GetMedicamente()
        {
            List<Pharmacy> medicamente = new List<Pharmacy>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Pharmacy s = new Pharmacy(line);
                        medicamente.Add(s);
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
        

        public void AddM(Pharmacy s)
        {
            throw new Exception("Optiunea nu este implementata");
        }
        public Pharmacy GetStudent(string nume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Pharmacy p = new Pharmacy(line);
                        if (p.Nume.Equals(nume))
                            return p;
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
            return null;
        }
        public List<Pharmacy> GetStudenti()
        {
            List<Pharmacy> medicamente = new List<Pharmacy>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Pharmacy s = new Pharmacy(line);
                        medicamente.Add(s);
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
        public bool UpdateMedicament(Pharmacy studentActualizat)
        {
            List<Pharmacy> studenti = GetStudenti();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Pharmacy stud in studenti)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (stud.IdMedicament != studentActualizat.IdMedicament)
                        {
                            swFisierText.WriteLine(stud.ConversieLaSir_Fisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(studentActualizat.ConversieLaSir_Fisier());
                        }
                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;
        }
        public Pharmacy GetMedicament(string nume)
        {
            throw new Exception("Optiunea GetMedicament nu este implementata");
        }

        public Pharmacy[] GetM(out int nrStudenti)
        {
            throw new Exception("Optiunea nu este implementata");
        }
    }
}
