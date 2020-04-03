using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
    public class Pharmacy
    {
        private const string SEPARATOR_AFISARE = ",";
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        //constante
        public const int higher = 1;
        public const int equal = 0;
        public const int less = -1;

        //enumerare
        public valability vala { get; set; }
        public tip tipp { get; set; }
        public string nume { get; set; }
        public int pret { get; set; }
        public string locatie { get; set; }

        //constructor fara parametrii
        public Pharmacy()
        {
            nume = string.Empty;
            locatie = string.Empty;
            pret = 0;
            vala = valability.unknowm;
            tipp = tip.necunoscnut;

        }

        //constructor cu parametrii
        public Pharmacy(string denumire, int cost, string loc)
        {
            nume = denumire;
            pret = cost;
            locatie = loc;
            vala = valability.unknowm;
            tipp = tip.necunoscnut;

        }

        public Pharmacy(string nume1)
        {
            string[] buff = nume1.Split(',');
            nume = buff[0];
            pret = Int32.Parse(buff[1]);
            locatie = buff[2];
            vala = valability.unknowm;
            tipp = tip.necunoscnut;
        }
        public string Info()
        {
            return string.Format("Medicamentul este {0} si are pretul de {1} lei", nume, pret);

        }

        public string Valabil()
        {
            if (vala == valability.valabil)
                return string.Format("Medicamentul {0} este valabil.", nume);
            else if (vala == valability.nevalabil)
                return string.Format("Medicamentul {0} nu este valabil", nume);
            else
                return string.Format("EROARE! Nu se cunoaste valabilitatea.");
        }
        public string TipMedicament()
        {
            if (tipp == tip.analgezic)
                return string.Format("Medicamentul {0} este de tip {1}", nume, tipp);
            if (tipp == tip.injectie)
                return string.Format("Medicamentul {0} este de tip {1}", nume, tipp);
            if (tipp == tip.pilula)
                return string.Format("Medicamentul {0} este de tip {1}", nume, tipp);
            if (tipp == tip.sirop)
                return string.Format("Medicamentul {0} este de tip {1}", nume, tipp);
            if (tipp == tip.unguent)
                return string.Format("Medicamentul {0} este de tip {1}", nume, tipp);
            else
                return string.Format("EROARE! Tipul Medicamentului este necunoscut.");
        }
        public string map()
        {
            return string.Format("Medicamentul {0} se gaseste la farmacia {1}. ", nume, locatie);
        }

        public int CompararePret(Pharmacy _p)
        {
            if (pret == _p.pret)
                return 0;
            if (pret > _p.pret)
                return 1;
            if (pret < _p.pret)
                return -1;
            return -2;
        }
        public string ConversieLaSir_Fisier()
        {
            string s = string.Empty;
            if (nume != null)
            {
                s = string.Join(SEPARATOR_AFISARE, pret);
            }
            string s1 = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", SEPARATOR_PRINCIPAL_FISIER, (nume ?? " NECUNOSCUT "), pret,(locatie ?? " NECUNOSCUT "),vala,tipp);

            return s1;
        }
    }

}