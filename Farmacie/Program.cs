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

            Pharmacy med1 = new Pharmacy("Parasinus", 12, 1, "Catena");
            Pharmacy med2 = new Pharmacy("Decasept", 10, 1, "HelpNet");
            Pharmacy med3 = new Pharmacy("Nurofen,15,1,SensiBlue");
            Pharmacy med4 = new Pharmacy();
            Pharmacy med5 = new Pharmacy("Decasept", 9, 1, "Catena");
            Pharmacy med6 = new Pharmacy("Tusocalm", 15, 0, "UrbanGinaPharm");

            string s1, s2, s3, s4, s5, s6;



            while (continuare)
            {
                Console.Clear();
                Console.WriteLine("                          PHARMALIFE-APLICATIE MOBILA\n              ");
                Console.WriteLine("A.Adaugare medicament in baza de date.");
                Console.WriteLine("I.Info Medicamente(Afisare)");
                Console.WriteLine("V.Verificare valabilitate medicamente.");
                Console.WriteLine("L.Verificati locatiile unde se gasesc medicamentele.");
                Console.WriteLine("C.Comparare pret ");
                Console.WriteLine("X.Citire din fisier.");
                Console.WriteLine("E.Exit.");
                Console.WriteLine("Alegeti o optiune: ");

                string opt = Console.ReadLine();



                switch (opt.ToUpper())
                {
                    case "A":
                        {
                            med4 = citireTastatura();
                            Console.ReadKey();
                            break;
                        }
                    case "I":
                        {
                            s1 = med1.Info();
                            Console.WriteLine(s1);
                            s2 = med2.Info();
                            Console.WriteLine(s2);
                            s3 = med3.Info();
                            Console.WriteLine(s3);
                            s4 = med4.Info();
                            Console.WriteLine(s4);
                            s5 = med5.Info();
                            Console.WriteLine(s5);
                            s6 = med6.Info();
                            Console.WriteLine(s6);

                            Console.WriteLine("Nu s-a adaugat niciun alt medicament.\n");
                            Console.ReadKey();
                            break;
                        }
                    case "V":
                        {
                            s1 = med1.Valabil();
                            Console.WriteLine(s1);
                            s2 = med2.Valabil();
                            Console.WriteLine(s2);
                            s3 = med3.Valabil();
                            Console.WriteLine(s3);
                            s4 = med4.Valabil();
                            Console.WriteLine(s4);
                            s5 = med5.Valabil();
                            Console.WriteLine(s5);
                            s6 = med6.Valabil();
                            Console.WriteLine(s6);
                            Console.ReadKey();
                            break;
                        }
                    case "L":
                        {
                            s1 = med1.map();
                            Console.WriteLine(s1);
                            s2 = med2.map();
                            Console.WriteLine(s2);
                            s3 = med3.map();
                            Console.WriteLine(s3);
                            s4 = med4.map();
                            Console.WriteLine(s4);
                            s5 = med5.map();
                            Console.WriteLine(s5);
                            s6 = med6.map();
                            Console.WriteLine(s6);

                            Console.ReadKey();
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine("Intrucat medicamentul Decasept se gaseste in doua farmacii, se va compara pretul spre a se vedea care locatie este mai rentabila.");

                            if (med2.compararePret(med5) == Pharmacy.higher)
                                Console.WriteLine(" Pretul este mai avantajos in farmacia {0} ", med5.locatie);
                            else if (med2.compararePret(med5) == Pharmacy.less)
                                Console.WriteLine("Pretul este mai avantajos in farmacia {0}", med2.locatie);
                            else
                                Console.WriteLine("Pretul este egal.");


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

            Console.WriteLine("Introduceti daca este valabil momentan[1-valabil 0-nevalabil]:");
            int valabilitate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti locatia unde se poate gasi:");
            string locatie = Console.ReadLine();


            Console.WriteLine("Va rugam sa verificicati din nou informatiile despre medicamente.");

            Pharmacy m = new Pharmacy(nume, pret, valabilitate, locatie);

            return m;
        }


    }
}
