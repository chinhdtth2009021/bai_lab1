using System;
using Lab5.controller;
using Lab5.entity;

namespace Lab5.Order
{
    public class Groceries
    {
        public void OrderGroceries()
        {
            Customer ctm2 = new Customer();
            CustomerController customer1 = new CustomerController();
            customer1.getName();
            Console.WriteLine($"Ten: {ctm2.Name}");
            Console.WriteLine("ban da dat hang tap hoa: ");
        }
    }
}