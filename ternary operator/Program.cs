using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int c = (a<b) ? a : b;
            Console.WriteLine(c);
        }
    }
}
