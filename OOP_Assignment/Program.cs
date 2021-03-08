using System;

namespace OOP_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Bil bil = new Bil("Nissan", new DateTime(2019, 9, 12));
            Console.WriteLine ("Bil's brand:"+ bil.GetMærke() + "\n" + "Bil's alder :"+bil.Alder);

            Bil bilOriginal = bil;
            bil.Alder = 55;
            bil.Alder = 100;
            Console.WriteLine(bil.Alder);
            Console.WriteLine(bilOriginal.Alder);

            Console.WriteLine("Bil's brand:" + bil.GetMærke() + "\n" + "Bil's alder :" + bil.Alder);

        }
    }
}
