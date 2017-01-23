using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeggieMarket
{
    class Program
    {
        static void Main(string[] args)
        {
                 var PriceKGVeggie = double.Parse(Console.ReadLine());

                  var PriceKGFruit = double.Parse(Console.ReadLine());

                   var TotalVeggieKilo = double.Parse(Console.ReadLine());

                    var TotalFruitKilo = double.Parse(Console.ReadLine());
                     var euro = 1.94;

            var outputVeg = PriceKGVeggie * TotalVeggieKilo / euro;
            var outputFruit = PriceKGFruit * TotalFruitKilo / euro;
            Console.WriteLine(outputVeg + outputFruit);
         
        }
    }
}
