using Laba3.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person janna = new Person("Janna", 40);
            Vehicle train = new Train("Podillya", 25000, janna, 8);
            train.Ride();
            train.Stop();
            Vehicle car = new Avto("Mersedes", 60, 4);
        }
    }
}
