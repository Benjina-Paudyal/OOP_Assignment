using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
      abstract class Motorkørtøj
    {
        public string NrPlate { get; set; }
        public abstract DateTime SynDato { get; set; }

        public Motorkørtøj(string nrPlate)
        {
            NrPlate = nrPlate;   
        }
        
    }
}
