using System;

namespace Bai3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int s1;
           Console.WriteLine("vui long nhap tu 1 > 7");
           do
           {
               s1 = Int32.Parse(Console.ReadLine());
               if (s1 == 1)
               {
                   Console.WriteLine("Monday");
               }
               else if (s1 == 2)

               {
                   Console.WriteLine("Tuesday");
               }
               else if (s1 == 3)
               {
                   Console.WriteLine("Wednesday");
               }
               else if (s1 == 4)
               {
                   Console.WriteLine("Thursday");
               }
               else if (s1 == 5)
               {
                   Console.WriteLine("Friday");
               }
               else if (s1 == 6)
               {
                   Console.WriteLine("Saturday");
               }
               else if (s1 == 7)
               {
                   Console.WriteLine("Sunday");
               }
           } while (s1 <= 7);
           Console.ReadLine();
        }
    }
}