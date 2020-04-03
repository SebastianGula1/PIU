using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarie;
using NivelAccesDate;


namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuare = true;
            int nr;
            IStocareData admin = StocareFactory.GetAdministratorStocare();
            Pharmacy[] vect;
            vect = admin.GetM(out nr);
            
            

            while (continuare)
            {
                Console.Clear();
                Console.WriteLine("                          PHARMALIFE-APLICATIE MOBILA\n              ");
                Console.WriteLine("A.Adaugare medicament de la tastatura in baza de date.");
                Console.WriteLine("I.Info Medicamente(Afisare)");
                Console.WriteLine("V.Verificare valabilitate medicamente.");
                Console.WriteLine("L.Verificati locatiile unde se gasesc medicamentele.");
                Console.WriteLine("C.Comparare pret ");
                Console.WriteLine("T.Tipul medicamentului.");
                Console.WriteLine("E.Exit.");
                Console.WriteLine("Alegeti o optiune: ");

                string opt = Console.ReadLine();



                switch (opt.ToUpper())
                {
                    case "A":
                        {
                            Console.WriteLine("Introduceti un medicament de la tastatura.\n");
                            Pharmacy med = citireTastatura();
                            vect[nr] = med;
                            nr++;
                            admin.AddM(med);

                            Console.ReadKey();
                            break;
                        }
                    case "I":
                        {
                            for (int i = 0; i < nr; i++)
                            {
                                Console.WriteLine(vect[i].Info());
                            }
                            Console.WriteLine("Nu s-a adaugat niciun alt medicament.\n");
                            Console.ReadKey();
                            break;
                        }
                    case "V":
                        {
                            for (int i = 0; i < nr; i++)
                            {
                                Console.WriteLine(vect[i].Valabil());
                            }

                            Console.ReadKey();
                            break;
                        }
                    case "L":
                        {
                            for (int i = 0; i < nr; i++)
                            {
                                Console.WriteLine(vect[i].map());
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "C":
                        {  
                            if (vect[0].compararePret(vect[1]) == Pharmacy.higher)
                                Console.WriteLine("Pretul este mai avantajos in farmacia {0}", vect[1].locatie);
                            else if (vect[0].compararePret(vect[1]) == Pharmacy.less)
                                Console.WriteLine("Prestul este mai avantajos in farmacia {0}", vect[0].locatie);
                            else
                                Console.WriteLine("Pretul este egal in ambele farmacii.");
                            Console.ReadKey();
                            break;
                        }
                    case "T":
                        {
                            for(int i=0;i<nr;i++)
                            {
                                Console.WriteLine(vect[i].TipMedicament());
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "E":
                        {
                            continuare = false;

                            break;

                        }
                }
            }

        }

        public static Pharmacy citireTastatura()
        {
            Console.WriteLine("Introduceti numele medicamentului pe care doriti sa-l inserati in baza de date:");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti pretul:");
            int pret = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti locatia unde se poate gasi:");
            string locatie = Console.ReadLine();


            Pharmacy m = new Pharmacy(nume, pret, locatie);
            Console.WriteLine("Introduceti daca medicamentul este valabil. [1-valabil] [2-nevalabil] [3-necunoscut]");
            m.vala = (valability)Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti tipul medicamentului :");
            Console.WriteLine("1.Analgezic");
            Console.WriteLine("2.Pilula");
            Console.WriteLine("3.Sirop");
            Console.WriteLine("4.Unguesnt");
            Console.WriteLine("5.Injectie");
            Console.WriteLine("6.Nu se stie tipul");
            m.tipp = (tip)Int32.Parse(Console.ReadLine());


            return m;
        }

    }
}

