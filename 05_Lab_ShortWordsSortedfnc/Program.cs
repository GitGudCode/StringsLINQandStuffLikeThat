using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lab_ShortWordsSortedfnc
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'\\/!?".ToCharArray();
            var words = Console.ReadLine().ToLower().Split(separators);

            var result = words.Where(w => w != "")
        }
    }
}
