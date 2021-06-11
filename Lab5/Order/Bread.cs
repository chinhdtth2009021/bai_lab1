using System;
using Lab5.controller;
using Lab5.entity;

namespace Lab5.Order
{
    public class Bread
    {
        public void OrderBread()
        {
            Customer ctm1 = new Customer();
            CustomerController customer2 = new CustomerController();
            customer2.getName();
            Console.WriteLine($"Ten: {ctm1.Name}");
            Console.WriteLine("ban da dat hang banh mi: ");
        }
    }
}