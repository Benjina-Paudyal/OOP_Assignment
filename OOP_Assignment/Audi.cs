using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    sealed class Audi : Bil
    {
        public string Model { get; set; }
        
        public Audi (string nrPlate,string mærke, DateTime årgang, string model): base (mærke,årgang,nrPlate)
        {
            Model = model;
        }

        public void GetInfo()
        {
            Console.WriteLine("Number plate: "+base.NrPlate);
            Console.WriteLine("Brand: "+base.GetMærke());
            Console.WriteLine("Age: "+base.Alder);
            Console.WriteLine("Model number: "+ Model);

        }

        public string GetInfo(string extraInfo)
        {
            return "Extra information: " + extraInfo;
        }
        



    }
}