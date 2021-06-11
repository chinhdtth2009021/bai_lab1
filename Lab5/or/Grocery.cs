using System;

namespace lab5.or
{
    public class Grocery
    {
        public void orderGrocery()
        {
            Customer customer = new Customer();
            customer.getName();
            Console.WriteLine($"{customer.Name}");
            Console.WriteLine("ban da chon tap hoa:  ");
        }
    }
}