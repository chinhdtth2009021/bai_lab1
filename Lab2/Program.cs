using System;
using System.Text;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("vui long nhap ma sin: ");
            int n = Int32.Parse(Console.ReadLine());
            int sun = 0;
            if (n.ToString().Length!=9)
            {
                Console.WriteLine("chuong trinh chi nhan 9 so: ");
            }
            else
            {
                while (n != 0)
                {
                    sun = sun + n % 10;
                    n = n / 10;
                }

                int total = sun % 10;
                if (total == 0)
                {
                    Console.WriteLine(" This is a valid SIN."); 
                }
                else
                {
                    Console.WriteLine("This is not a valid SIN.");
                }

                Console.WriteLine("Have a Nice Day!");
            }
        }
    }
}