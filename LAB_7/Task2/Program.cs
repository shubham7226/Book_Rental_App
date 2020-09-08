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
            string[] names = { "jay", "ken", "op", "tommy", "janny", "ali", "mavi", "otinos", "bad", "kim" };

            var aa = names.Where(name => name[0] == 'k');
            Console.WriteLine("a. string name with first letter k");
            foreach (string a in aa)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var b = names.Where(name => name.Length < 4);
            Console.WriteLine("b. string length is less than 4:");
            foreach (string a in b)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var c = names.Where(name => name.Length == 3);
            Console.WriteLine("c. string length is equal to 3:");
            foreach (string a in c)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var d = names.OrderBy(name => name).ToList();
            Console.WriteLine("d. Ascending Order:");
            foreach (string a in d)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
