using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    class AudiModel
    {
        public double MotorStørrelse { get; set; }
        public DateTime Årgang { get; set; }
        public string Model { get; set; }

        // property to use without Enum
        public string Farve { get; set; }

        // property to use with Enum
        public Farver FarveEnum{ get; set; }
    }
}
