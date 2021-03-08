using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
    class Bil
    {
     
        private string Mærke { get; set; }
        public int? Alder { get; set; } // to allocate null values in value type included '?' before int

        public Bil(string mærke, DateTime årgang)
        {

            Mærke = mærke;

            Alder alder = new Alder(årgang);
            Alder = alder.Værdi;
        }

        public string GetMærke()
        {
            return Mærke;
        }
    }
}
