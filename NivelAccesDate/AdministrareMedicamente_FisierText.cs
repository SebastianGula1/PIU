using Librarie;
using System;
using System.IO;
using System.Collections.Generic;


namespace NivelAccesDate
{

    public class AdministrareMedicamente_FisierText : IStocareData
    {
        private const int PAS_ALOCARE = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareMedicamente_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            
        }
        public void AddM(Pharmacy s)
        {
            s.IdMedicament = GetId();

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
                
                using (StreamReader sr = new StreamReader("Medicamente.txt"))
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
         
        public List<Pharmacy> GetMedicamente()
        {
            List<Pharmacy> medicamente = new List<Pharmacy>();

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

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
        public Pharmacy GetMedicament(string nume)
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
                            return  p;
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
      
        private int GetId()
        {
            int IdStudent = 1 ;
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
                        IdStudent = s.IdMedicament + INCREMENT;
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
            return IdStudent;
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
    }

}