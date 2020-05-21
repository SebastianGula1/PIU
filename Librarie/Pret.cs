using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
  public static  class PRET
    {
        public const int PRET_MINIM = 1;
        public const int PRET_MAXIM = 9999;
        public const bool PRET_VALID = true;


        public static bool ValideazaPret(int pret)
        {
            if (pret >= PRET_MINIM && pret <= PRET_MAXIM)
                return PRET_VALID;
            return !PRET_VALID;
        }

        public static int[] ExtragerePretDinSir(string sirPret)
        {
            string[] vectorPretDupaSplit = sirPret.Split(' ');
            int[] note = new int[vectorPretDupaSplit.Length];

            int nrNote = 0;
            foreach (var nota in vectorPretDupaSplit)
            {
                bool rezultatConversie = Int32.TryParse(nota, out note[nrNote]);
                if (rezultatConversie == PRET_VALID && ValideazaPret(note[nrNote]) == PRET_VALID)
                {
                    nrNote++;
                }
            }

            Array.Resize(ref note, nrNote);
            return note;
        }

    }
}
