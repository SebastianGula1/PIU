using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
      public class Pharmacy
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';

        //constante
        public const int higher = 1;
        public const int equal = 0;
        public const int less = 1;

        public string nume { get; set; }
        public int pret { get; set; }
        public int valabilitate { get; set; }
        public string locatie { get; set; }

        //constructor fara parametrii
        public Pharmacy()
        {
            nume = string.Empty;
            locatie = string.Empty;
            pret = 0;
            valabilitate = 0;

        }

        //constructor cu parametrii
        public Pharmacy(string denumire, int cost, int valabil, string loc)
        {
            nume = denumire;
            pret = cost;
            valabilitate = valabil;
            locatie = loc;

        }

        public Pharmacy(string nume1)
        {
            string[] buff = nume1.Split(',');
            nume = buff[0];
            pret = Int32.Parse(buff[1]);
            valabilitate = Int32.Parse(buff[2]);
            locatie = buff[3];
        }
        public string Info()
        {
            return string.Format("Medicamentul este {0} si are pretul de {1} lei", nume, pret);

        }

        public string Valabil()
        {
            if (valabilitate == 1)
                return string.Format("Medicamentul {0} este valabil.", nume);
            else
                return string.Format("Medicamentul {0} nu este valabil", nume);

        }
        public string map()
        {
            return string.Format("Medicamentul {0} se gaseste la farmacia {1}. ", nume, locatie);
        }

        public int compararePret(Pharmacy _p)
        {
            return this.pret.CompareTo(_p.pret);
        }
        public string ConversieLaSir_Fisier()
        {
            string s = string.Empty;
            if (nume != null)
            {
                s = string.Join(SEPARATOR_AFISARE, pret);
            }
            string s1 = string.Format("{1}{0}{2}{0}{3}{0}{4}", SEPARATOR_PRINCIPAL_FISIER, (nume ?? " NECUNOSCUT "), pret, valabilitate, (locatie ?? " NECUNOSCUT "), s);

            return s1;
        }
    }

}
