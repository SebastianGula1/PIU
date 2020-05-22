using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
   
{
    [Flags]
    public enum CodEroare
    {
       CORECT = 0,
       NUME_INCORECT = 1,
       PRET_INCORET = 2,
       TIP_INCORECT = 3,
       LOCATIE_INCORECT = 4,
       VALABILITATE = 5,

    }


}
