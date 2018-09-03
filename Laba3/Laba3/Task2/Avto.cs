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

        public override string Show()
        {
            return $"Train is called {Name} and has speed {Speed}. It has {VheelsCount} vheels.";
        }

        ~Avto()
        {
            Console.WriteLine("Destructor");
        }

        public void Beep()
        {
            Console.WriteLine("Car beeps.");
        }
    }
}
