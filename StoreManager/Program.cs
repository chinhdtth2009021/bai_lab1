using System;
using System.Collections.Generic;
using System.Text;

namespace StoreManager
{
    internal class Program
    {
        private static List<Product> _products = new List<Product>();

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ProductMenu();
        }

        public static void ProductMenu()
        {
            while (true)
            {
                Console.WriteLine("--------Menu---------------");
                Console.WriteLine("1: Add new products");
                Console.WriteLine("2: Show product list");
                Console.WriteLine("3: Delete product");
                Console.WriteLine("4: Exit");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Please enter options (1 > 4)");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Save();
                        break;
                    case 2:
                        ShowList();
                        break;
                    case 3: 
                        Delete();
                        break;
                }

                if (choice == 4)
                {
                  break;  
                }
            }
        }

        public static void Save()
        {
            var product = new Product();
            Console.WriteLine("Please enter product id: ");
            product.Id = Console.ReadLine();
            Console.WriteLine("Please enter product name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please enter product price: ");
            product.Price = Console.ReadLine();
            _products.Add(product);
        }

        public static void ShowList()
        {
            Console.WriteLine("Id\t\tName\t\t\tPrice");
            foreach (var products in _products)
            {
              
                Console.WriteLine(products.ToString());
            }
        }

        public static void Delete()
        {
            Console.WriteLine("Please enter the product id to delete:");
            var id = Console.ReadLine();
            for (int i = 0; i < _products.Count; i++)
            {
                var information = _products[i];
                if (information.Id.Equals(id))
                {
                    Console.WriteLine($"Found products with id : {id}");
                    Console.WriteLine("Are you sure you want to delete the product?(c/k)");
                    var luachon = Console.ReadLine();
                    if (luachon.ToLower().Equals("c"))
                    {
                        _products.RemoveAt(i);
                        Console.WriteLine("Success delete");
                        
                    }
                    else
                    {
                        Console.WriteLine("No products found!");
                    }
                    break;
                }
            }
        }
    }
}