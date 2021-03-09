using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment
{
     class Bil: Motorkørtøj
    {
        private string Mærke { get; set; }
        public int? Alder { get; set; } 

        public override DateTime SynDato { get; set; }
        public Bil(string mærke, DateTime årgang, string nrPlate): base (nrPlate)
        {
            
            Mærke = mærke;
            Alder alder = new Alder(årgang);
            Alder = alder.Værdi;
            SynDato = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        public string GetMærke()
        {
            return Mærke;
        }
    }
}
