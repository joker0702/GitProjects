using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double ergebnis = Math.Pow(10.0, 29.0) % 1147;
            
            Console.WriteLine("Ergebnis: " + ergebnis);
            Console.ReadLine();
        }
    }
}
