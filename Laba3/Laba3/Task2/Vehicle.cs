using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Task2
{
    public abstract class Vehicle : IRide, IStop
    {
        public string Name { get; set; }
        public double Speed { get; set; }

        public Vehicle(string Name, double Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }
        public void Ride()
        {
            Console.WriteLine("Vehicle rides.");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle stops.");
        }
        public abstract string Show();
    }
}
