using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lab_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var words = Console.ReadLine().Split(' ');

            foreach (var word in words)
            {
                var stars = new string('*', word.Length);
                text = text.Replace(word, stars);
            }
            Console.WriteLine(text);
        }
    }
}
