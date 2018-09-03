using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] CreateTwoArray(int n, int m)
            {
                int[,] array = new int[n, m];
                Random ran = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = ran.Next(10);
                    }
                }
                return array;
            }

            void ShowTwoArray(int[,] twoArr)
            {
                int row = twoArr.GetUpperBound(0) + 1;
                int col = twoArr.Length / row;

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(twoArr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            int[] CreateArray(int n)
            {
                int[] array = new int[n];
                Random ran = new Random();
                for (int i = 0; i < n; i++)
                {
                    array[i] = ran.Next(10);
                }
                return array;
            }

            void ShowArray(int[] arrr)
            {
                for (int i = 0; i < arrr.Length; i++)
                {
                    Console.Write(arrr[i] + " ");
                }
            }

            //#region 1.1
            //var twoArray = CreateTwoArray(5, 5);
            //Console.WriteLine("Enter first number: ");
            //int first = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int second = int.Parse(Console.ReadLine());
            //ShowTwoArray(twoArray);
            //int count = 0;
            //int rows = twoArray.GetUpperBound(0) + 1;
            //int columns = twoArray.Length / rows;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (twoArray[i, j] < first && twoArray[i, j] > second)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);
            //#endregion

            //#region 1.2
            //var arra = CreateArray(5);
            //Console.WriteLine("Enter first number: ");
            //int firstr = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int secondr = int.Parse(Console.ReadLine());
            //ShowArray(arra);
            //int countr = 0;

            //for (int i = 0; i < arra.Length; i++)
            //{
            //    if (arra[i] < firstr && arra[i] > secondr)
            //    {
            //        countr++;
            //    }
            //}
            //Console.WriteLine(countr);
            //#endregion

            //#region 2.1
            //var arr = CreateArray(15);
            //ShowArray(arr);
            //int min = arr[0];
            //int number = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] <= min)
            //    {
            //        min = arr[i];
            //        number = i;
            //    }
            //}
            //number++;
            //Console.WriteLine();
            //Console.WriteLine("Number is: " + number);
            //#endregion

            //#region 2.2
            //var arr = CreateTwoArray(5, 5);
            //ShowTwoArray(arr);
            //int min = arr[0, 0];
            //int numbercol = 0;
            //int numberrow = 0;
            //int rows = arr.GetUpperBound(0) + 1;
            //int columns = arr.Length / rows;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (arr[i, j] <= min)
            //        {
            //            min = arr[i, j];
            //            numbercol = i;
            //            numberrow = j;
            //        }
            //    }
            //}
            //numbercol++;
            //numberrow++;
            //Console.WriteLine();
            //Console.WriteLine("Row number is: " + numbercol);
            //Console.WriteLine("Column number is:" + numberrow);
            //#endregion

            //#region 3
            //var arr = CreateTwoArray(5, 5);
            //ShowTwoArray(arr);
            //int sum=0;
            //int max = arr[0, 0];
            //int rows = arr.GetUpperBound(0) + 1;
            //int columns = arr.Length / rows;
            //for( int i=0; i<rows; i++)
            //{
            //    for(int j=0; j<columns; j++)
            //    {
            //        if (arr[i, j] >= max)
            //        {
            //            max = arr[i, j];
            //        }
            //    }
            //}
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (arr[i, j] == max)
            //        {
            //            sum += max;
            //        }
            //    }
            //}
            //Console.WriteLine("Sum is: "+sum);
            //Console.WriteLine("Enter n: ");
            //int mn = int.Parse(Console.ReadLine());
            //Console.WriteLine("Result is: "+Math.Pow(sum, mn));
            //#endregion


            //#region 4
            //Console.WriteLine("Input n < 3: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine(new string('_', 50));
            //Random rand = new Random();
            //int[][] ar = new int[a][];
            //List<int> result = new List<int>();
            //int sum = 0;
            //for( int i=0; i<a; i++)
            //{
            //    ar[i] = new int[rand.Next(3, a)];
            //}
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    int[] innerArray = ar[i];
            //    for (int j = 0; j < innerArray.Length; j++)
            //    {
            //        innerArray[j] = rand.Next(15);
            //        Console.Write(innerArray[j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(new string('_', 50));
            //Console.WriteLine("Enter first number: ");
            //int fir = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int sec = int.Parse(Console.ReadLine());
            //Console.WriteLine(new string('_', 50));
            //for (int i=0; i<ar.Length; i++)
            //{
            //    for (int j=fir; j<=sec; j++)
            //    {
            //        sum += ar[i][j];
            //        Console.WriteLine(sum);
            //        result.Add(sum);
            //    }
            //}
            //foreach (var v in result)
            //{
            //    Console.Write(v+" ");
            //}
            //#endregion
            Console.ReadLine();
        }
    }

}