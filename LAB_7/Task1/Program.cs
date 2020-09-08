using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            var numbers = new List<int>();
            for (i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }
            var q1 = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("1) All even Numbers:");
            foreach (int a in q1)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            q1 = numbers.Where(n => n % 2 == 1);
            Console.WriteLine("2) All odd Numbers:");
            foreach (int a in q1)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            q1 = numbers.Select(n => n);
            Console.WriteLine("3) All Numbers:");
            foreach (int a in q1)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            q1 = numbers.Select(n => n);
            Console.WriteLine("4) Maximum and Minimum No:");
            var max = numbers.Max();
            var min = numbers.Min();
            Console.WriteLine("max:- " + max + "  Min:- " + min);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5) Average of all number:");
            var avg = numbers.Average();
            Console.WriteLine("Average:- " + avg);
            Console.WriteLine();
        }
    }
}
