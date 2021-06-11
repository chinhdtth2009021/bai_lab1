using System;

namespace lab5.or
{
    public class Bread
    {
        public void orderBread()
        {
            Customer customer = new Customer();
            customer.getName();
            Console.WriteLine($"{customer.Name}");
            Console.WriteLine("ban da chon banh mi: ");
        }
    }
}