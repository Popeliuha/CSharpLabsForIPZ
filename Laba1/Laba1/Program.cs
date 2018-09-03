using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Enter volume: ");
            double v = double.Parse(Console.ReadLine());
            double result = Math.Pow(v, 1.0 / 3.0);
            Console.WriteLine("Result is " + result);
            #endregion

            #region 2
            Console.WriteLine("Enter number with 2 digits.");
            string res = Console.ReadLine();
            string a = "";
            string b = "";
            for (int i = 0; i <= res.Length; i++)
            {
                a = res[0].ToString();
                b = res[1].ToString();
            }
            Console.WriteLine("a, b: " + a + ", " + b);
            if ((int.Parse(a) + int.Parse(b)) % 2 == 0)
            {
                Console.WriteLine("Suma parna");
            }
            else
            {
                Console.WriteLine("Suma neparna.");
            }
            #endregion

            #region 3
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());
            if ((y > -100) && (y < 0) && (Math.Abs(x) > y) && (Math.Abs(x) < -y))
            {
                Console.WriteLine("Point is inside the triangle.");
            }
            else if ((y < -100) || (y > 0) || (Math.Abs(x) < y) || (Math.Abs(x) > -y))
            {
                Console.WriteLine("Point is outside the triangle.");
            }
            else
            {
                Console.WriteLine("Point is on the triangle.");
            }
            #endregion

            #region 4
            Console.WriteLine("Enter count of month");
            int count = int.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int currentYear = now.Year;
            int currentMonth = now.Month;
            int newMonth = currentMonth - count;
            if (newMonth < 1)
            {
                for (int i = newMonth; i < 0; i += 12)
                {
                    currentYear--;
                    newMonth += 12;
                }
            }
            if (newMonth == 0)
            {
                currentYear--;
                newMonth = 12;
            }
            Console.WriteLine($"{count} month ago was {newMonth} month of {currentYear}.");
            #endregion

            #region 5
            double SquareOfSum(int K, int L)
            {
                return Math.Pow(K + L, 2);
            }
            Console.WriteLine("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is " + SquareOfSum(first, second));
            #endregion

            #region 6
            Console.WriteLine("Enter first number: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine(5 + (B / Math.Pow(B, 2) + 1) + (A - B) * 1 / (A + B));
            #endregion
            Console.Read();
        }
    }
}
