using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lab_FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var w = Console.ReadLine();
            var counter = 0;
            var startPos = 0;

            while (true)
            {
                var position = text.IndexOf(w, startPos, StringComparison.CurrentCultureIgnoreCase);
                if (position == -1)
                {
                    break;
                }
                startPos = position + 1;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
