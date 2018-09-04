using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Program : IEnumerable, IEnumerator
    {
        public object Current => throw new NotImplementedException();

        static void Main(string[] args)
        {
            Software a = new Commertial("Tery", "Ivan", new DateTime(2016, 12, 02), 3);
            Software b = new HalfFree("Rap", "Anton", new DateTime(2014, 01, 01), 1);
            Software c = new HalfFree("Gapo", "Stepan", new DateTime(2016, 01, 01), 1);
            Software d = new Freeware("Labo", "Ren");
            List<Software> softwares = new List<Software>();
            softwares.Add(a);
            softwares.Add(b);
            softwares.Add(c);
            softwares.Add(d);
            foreach (var v in softwares)
            {
                if (v.DateOfInstalation == new  DateTime())
                {
                    Console.WriteLine($"Name is {v.Name}, developer is { v.Developer}.");
                }
                else
                {
                    Console.WriteLine($"Name is {v.Name}, developer is { v.Developer}, date of instalation is {v.DateOfInstalation.Date}.");
                }
            }
            Console.WriteLine("Input year when you want to use: ");
            bool flag = true;
            while (flag)
            {

                var y = int.Parse(Console.ReadLine());
                foreach (var v in softwares)
                {
                    if (v.TimeToUse+ v.DateOfInstalation.Year<=y)
                    {
                        Console.WriteLine($"Name is {v.Name}, date of instalation is {v.DateOfInstalation}.");
                    }
                }
                Console.WriteLine("Type n to exit");
                var answer = Console.ReadLine();
                if (answer == "n")
                {
                    flag = false;
                }
                Console.WriteLine("Input year when you want to use: ");
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
