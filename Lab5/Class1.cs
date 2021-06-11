using System;
using Lab5.Order;

namespace Lab5
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1: Hang Tap hoa. ");
            Console.WriteLine("2: banh mi. ");
            Console.WriteLine("3: Thoat. ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("vui long nhap lua chon.");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                Groceries groceries = new Groceries();
                groceries.OrderGroceries();
            }
            else if (choice == "2")
            {
                Bread bread = new Bread();
                bread.OrderBread();
            }else if (choice == "3")
            {
                Console.WriteLine("bye bye"); 
            }

            Console.ReadLine();
        }
    }
}