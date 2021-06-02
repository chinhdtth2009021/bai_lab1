using System;
using System.Text;

namespace bai2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vui lòng nhập số nguyên: ");
            Console.WriteLine("Nhập A: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập B: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập C: ");
            var c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine("a là số lớn nhất.");
            }
            if (b>a && b>c)
            {
                Console.WriteLine("b là số lớn nhất.");
            }

            if (c > a && c > b)
            {
                Console.WriteLine("c là số lớn nhất.");
            }
        }
    }
}