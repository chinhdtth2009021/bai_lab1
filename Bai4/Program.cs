using System;

namespace Bai4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Vui long nhap so nguyen: ");
            var n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + n * i);
            }
        }
    }
}