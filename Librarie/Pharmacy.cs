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
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        //constante
        public const int higher = 1;
        public const int equal = 0;
        public const int less = -1;

        //enumerare
        public int IdMedicament { get; set; }
        public string Nume { get; set; }
        public int Pret { get; set; }
        public tip Tip { get; set; }
        public string Valabilitate { get; set; }


        public List<string> Locatie { get; set; }

        //constructor fara parametrii
        public Pharmacy()
        {
            Nume = string.Empty;
            Pret = 0;
            Valabilitate = string.Empty;
            Tip = tip.Necunoscut;

        }

        //constructor cu parametrii
        public Pharmacy(string denumire, int cost)
        {
            Nume = denumire;
            Pret = cost;
            Valabilitate = string.Empty;
            Tip = tip.Necunoscut;

        }
        public Pharmacy(string denumire, int cost, string Typee, string valability)
        {
            Nume = denumire;
            Pret = cost;
            Tip = (tip)Enum.Parse(typeof(tip), Typee);
            Valabilitate = valability;

        }

        public Pharmacy(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            IdMedicament = Convert.ToInt32(dateFisier[(int)CampuriMedicamente.Id]);
            Nume = dateFisier[(int)CampuriMedicamente.Nume];
            Pret = Convert.ToInt32(dateFisier[(int)CampuriMedicamente.Pret]);
            Tip = (tip)Enum.Parse(typeof(tip), dateFisier[(int)CampuriMedicamente.Tip]);
            Locatie = new List<string>();
            Locatie.AddRange(dateFisier[(int)CampuriMedicamente.Locatie].Split(SEPARATOR_SECUNDAR_FISIER));
            Valabilitate = dateFisier[(int)CampuriMedicamente.Valabilitate];

        }

        
        public string MedicamenteAsString
        {
            get
            {
                string sDiscipline = string.Empty;

                foreach (string disciplina in Locatie)
                {
                    if (sDiscipline != string.Empty)
                    {
                        sDiscipline += SEPARATOR_SECUNDAR_FISIER;
                    }
                    sDiscipline += disciplina;
                }

                return sDiscipline;
            }
        }

         public int GetPret()
        {
            return Pret;
        }
        public string Info()
        {
            return string.Format("Medicamentul este {0} si are pretul de {1} lei", Nume, Pret);

        }
        public string ConversieLaSir()
        {
            string sLocatie = "Nu exista (Nu ati apelat metoda setNote)";
            if (Locatie != null)
            {
                sLocatie = string.Join(" ", Locatie);
            }
            string s = string.Format("Medicamentul cu Id: #{0} si numele: \"{1}\", cu pretul de {2} lei, de tipul: {3}  este {4} la farmacia {5} ", IdMedicament, (Nume ?? " NECUNOSCUT "), Pret, Tip,Valabilitate, Locatie);
            return s;
        }


        public string ConversieLaSir_Fisier()
        {
            string sLocatie = string.Empty;
            if (Nume != null)
            {
                sLocatie = string.Join(SEPARATOR_AFISARE, Locatie);
            }
            string s1 = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", SEPARATOR_PRINCIPAL_FISIER,IdMedicament, (Nume ?? " NECUNOSCUT "), Pret,Tip,Valabilitate,sLocatie);

            return s1;
        }
    }

}