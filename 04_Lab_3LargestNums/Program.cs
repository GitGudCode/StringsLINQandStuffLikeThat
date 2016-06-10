using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Lab_3LargestNums
{
    class Program
    {
        static void Main(string[] args)
        {
            // """Functional""""   """""""programming""""""
            /*
            Console.WriteLine(String.Join(" ",
            Console.ReadLine().Split(' ').Select(int.Parse).ToArray().OrderByDescending(x => x).Take(3)));
            */
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse);

            var result = numbers.OrderByDescending(x => x).Take(3);
            Console.WriteLine(String.Join(" ", result));

        }
    }
}
