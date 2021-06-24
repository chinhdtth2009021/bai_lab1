using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* bai 1 */
            //     var temperatures = new List<int>();
            //     temperatures.Add(28);
            //     temperatures.Add(18);
            //     temperatures.Add(23);
            //     temperatures.Add(20);
            //     temperatures.Add(30);
            //     temperatures.Add(27);
            //     temperatures.Add(26);
            //     temperatures.Add(15);
            //     var count = 0;
            //     foreach (var temperature in temperatures)
            //     {
            //         if (temperature >= 25)
            //         {
            //             count++;
            //         }
            //     }
            //     Console.WriteLine("vui long nhap min cho GreaterCount");
            //     var min = int.Parse(Console.ReadLine());
            //     var result = GreaterCount(temperatures, min);
            //     Console.WriteLine($"so lan nhiet do vuot qua 25 do la: {count}");
            //     Console.WriteLine($"so lan min vuot qua {min} do la {result}");
            // }
            //
            // public static int GreaterCount(List<int> list, double min)
            // {
            //     var count = 0;
            //     foreach (var temperature in list)
            //     {
            //         if (temperature >= min)
            //         {
            //             count++;
            //         }
            //     }
            //
            //     return count;
            //
            //

            /* bai 2 */
            var random = new Random();
            var temperature = new double[300];
            for (var i = 0; i < 300; i++)
            {
                temperature[i] = random.Next(0, 1000);
            }

            while (true)
            {
                Console.Write("vui long nhap so min: ");
                var min = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    $"GreaterCount tra ve : {GreaterCount(temperature, min)} lan temperature lon hown so min da nhap: {min}\n\n");
            }
        }

        public static int GreaterCount(double[] enumerable, double min)
        {
            var count = 0;
            foreach (var item in enumerable)
            {
                if (double.Parse(item.ToString()) >= min)
                {
                    count++;
                }
            }

            return count;
        }
    }
}