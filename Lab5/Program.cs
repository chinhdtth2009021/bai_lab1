using System;
using lab5.or;

namespace lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bread bread = new Bread();
            Grocery grocery = new Grocery();
            Console.WriteLine("vui long nhap lua chon cua ban: ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1: Hang Tap Hoa");
            Console.WriteLine("2: Banh Mi");
            Console.WriteLine("3: Thoat");
            Console.WriteLine("----------------------------------");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    grocery.orderGrocery();
                    break;
                case 2:
                    bread.orderBread();
                    break;
                case  3:
                    break;
            }
            Console.WriteLine("tam biet!!!");
        }
    }
}