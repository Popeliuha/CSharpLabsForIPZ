using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Task2
{
    public class Train : Vehicle, IExpress
    {
        public int CountOfCarriage { get; set; }
        private Person conductor;
        public Train(string Name, double Speed, Person conductor, int CountOfCarriage):base (Name, Speed)
        {
            this.conductor = conductor;
            this.CountOfCarriage = CountOfCarriage;
        }
        public void IsExpress()
        {
            Console.WriteLine("Train became express.");
        }

    }
}
