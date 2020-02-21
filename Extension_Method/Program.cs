using System;
using System.Collections.Generic;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число");
            var inpute = Console.ReadLine();
            if (int.TryParse(inpute, out int result))
            {
                result.IsEven();
                //var isEven = IsEven(result);
                if (result.IsEven())
                {
                    Console.WriteLine($"Число {inpute} - четное");
                }
                else
                {
                    Console.WriteLine($"Число {inpute} - не четное");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели чипуху");
            }
            Console.ReadLine();

            var roads = new List<Road>();
            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(200, 10000);
                roads.Add(road);
                Console.WriteLine(road);
            }
            
        }

        
    }
}
