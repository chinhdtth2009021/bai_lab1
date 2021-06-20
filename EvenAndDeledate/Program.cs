using System;
using EvenAndDeledate.AirConditionerSimulation;

namespace EvenAndDeledate
{
    internal class Program
    {
        /* bai Tinh tong ba So */
        // public delegate int ChinhDelegate(int a, int b, int c);
        //
        // public static int TongBaSo(int a, int b, int c)
        // {
        //     return a + b + c;
        // }
/* bai 1 */
        // public delegate void Increment(ref int x);
        //
        // public static void Add1(ref int x)
        // {
        //     x += 2;
        // }
        // public static void Add2(ref int y)
        // {
        //     y += 3;
        // }
        public static void Main(string[] args)
        {
            /* bai mo phong thiet bi may dieu hoa */
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            Heater heater1 = new Heater(100);
            thermostat.OnTemperatureChange += heater1.OnTemperatureChanged;
            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;
            string temperature;
            Console.WriteLine("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
            /* bai tin tong ba so */
            // ChinhDelegate chinhDelegate = new ChinhDelegate(TongBaSo);
            // var result = chinhDelegate(1, 2, 3);
            // Console.WriteLine(result);
            /* bai 1 */
            // Increment increment = new Increment(Add1);
            // increment += Add2;
            // increment += Add1;
            // int x = 5;
            // increment(ref x);
            // Console.WriteLine(x);
        }
    }
}