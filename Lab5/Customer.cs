using System;

namespace lab5
{
    public class Customer
    {
        public string Name { get; set; }

        public void getName()
        {
            Console.WriteLine("vui long nhap ten:");
            Name = Console.ReadLine();
        }
    }
}