using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var RoomSmall = int.Parse(Console.ReadLine());
            var Kitchen = int.Parse(Console.ReadLine());
            var squareArea = Double.Parse(Console.ReadLine());
            
            var bathroom = RoomSmall / 2;
            var  SecondRoom = (RoomSmall * 0.1) + RoomSmall;
            var thirdRoom = (SecondRoom * 0.1) + SecondRoom;

            var Coridor = (RoomSmall + Kitchen + bathroom + SecondRoom + thirdRoom)*0.05;
            var Output = (RoomSmall + Kitchen + bathroom + SecondRoom + thirdRoom) + Coridor;
            var total = (Coridor * Output);
            Console.WriteLine("{0:F2}",total);
        }
    }
}
