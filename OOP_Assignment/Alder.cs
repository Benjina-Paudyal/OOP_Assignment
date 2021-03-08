using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    struct Alder
    {

        public int? Værdi { get; set; }

        public Alder(DateTime årgang)
        {
            Værdi = null;
            Værdi = Beregn(årgang);
        }
        public int? Beregn ( DateTime årgang)
        {
            return DateTime.Now.Year - årgang.Year;
        }

       



    }
}
