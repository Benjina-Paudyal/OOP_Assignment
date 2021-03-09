using System;

namespace OOP_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi("4C30", "Audi", new DateTime(2018, 3, 5), "Q7");
            audi.GetInfo();

            Console.WriteLine("Inspection Date: "+ audi.SynDato);
            Console.WriteLine(audi.GetInfo ("The car is now inspected and everything is fine."));


            //Bil bil = new Bil("Nissan", new DateTime(2019, 9, 12),"5BD3");
            //Console.WriteLine ("Bil's brand:"+ bil.GetMærke() + "\n" + "Bil's alder :"+bil.Alder);

            Console.ReadKey();

        }
    }
}
