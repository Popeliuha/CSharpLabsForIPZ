using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Task2
{
    public class Avto : Vehicle
    {
        public int VheelsCount { get; set; }

        public Avto(string Name, double Speed, int VheelsCount) : base(Name, Speed)
        {
            this.VheelsCount = VheelsCount;
        }

        public void Beep()
        {
            Console.WriteLine("Car beeps.");
        }
    }
}
