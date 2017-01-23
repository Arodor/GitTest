using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiousToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of farenheits to be converted: ");
            var farenheit = double.Parse(Console.ReadLine());
            var formula = farenheit * 1.8 + 32;
            Console.Write("Celsius = ");
            Console.WriteLine(formula);

        }
    }
}
