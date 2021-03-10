using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Assignment
{
    class Program
    {
        public static List<AudiModel> Audis { get; set; }

        

        static void Main(string[] args)
        {
            try

            {
                Audis = new List<AudiModel>();


                Audis.Add(new AudiModel() { MotorStørrelse = 3.2, Årgang = new DateTime(2018, 1, 9), Model = "A1", Farve = "Sort" });
                Audis.Add(new AudiModel() { MotorStørrelse = 3.4, Årgang = new DateTime(2019, 1, 10), Model = "A2", Farve = "Sort" });
                Audis.Add(new AudiModel() { MotorStørrelse = 3.6, Årgang = new DateTime(2020, 1, 11), Model = "A3", Farve = "Blå" });
                Audis.Add(new AudiModel() { MotorStørrelse = 3.8, Årgang = new DateTime(2021, 1, 12), Model = "A4", Farve = "Rød" });


                // using  class Enum for the colors of the Audis

                Audis.Add(new AudiModel() { MotorStørrelse = 3.2, Årgang = new DateTime(2018, 1, 9), Model = "A1", FarveEnum = Farver.Sort });
                Audis.Add(new AudiModel() { MotorStørrelse = 3.4, Årgang = new DateTime(2019, 1, 10), Model = "A2", FarveEnum = Farver.Sort });
                Audis.Add(new AudiModel() { MotorStørrelse = 3.6, Årgang = new DateTime(2020, 1, 11), Model = "A3", FarveEnum = Farver.Blå });
                Audis.Add(new AudiModel() { MotorStørrelse = 3.8, Årgang = new DateTime(2021, 1, 12), Model = "A4", FarveEnum = Farver.Rød});

            }

            catch ( Exception exc)

            {
                Console.WriteLine(exc.Message);
            }

            List<AudiModel> sortAudis = new List<AudiModel>();
            
            try
            {
                sortAudis = Audis.Where(b => b.Farve == "Sort").ToList();
            }

            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            finally
            {
                if (sortAudis.Count ==0)

                throw new Exception("The list is empty");
            }

            
            foreach (var bil in sortAudis)
            {
                Console.WriteLine("  Årgang: "+ bil.Årgang+ "  MotorStørrelse: " + bil.MotorStørrelse+ "  Model: "+ bil.Model+"  Farve: "+bil.Farve);
            }

            Console.ReadKey(); 

        }
    }
}
