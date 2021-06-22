using System;
using System.Collections.Generic;

namespace Lab7
{
    public class EmployeeManager
    {
        private Dictionary<string, Employees> _employees = new Dictionary<string, Employees>();

        public void Save()
        {
            Console.WriteLine("vui long nhap id : ");
            var id = Console.ReadLine();
            Console.WriteLine("vui long nhap ten: ");
            var name = Console.ReadLine();
            Console.WriteLine("vui long nhap tuoi: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("vui long nhap muc luong: ");
            var salary = double.Parse(Console.ReadLine());
            _employees.Add(id, new Employees()
            {
                Name = name,
                Age = age,
                Salary = salary
            });
        }

        public void FintAll()
        {
            foreach (var list in _employees)
            {
                Console.WriteLine($"{list.Key}, {list.Value}");
            }
        }


        public void Update()
        {
            Console.WriteLine("vui long nhap id : ");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                Console.WriteLine("vui long nhap ten :");
                var name = Console.ReadLine();
                _employees[id].Name = name;
                Console.WriteLine("vui long nhap tuoi :");
                var age = int.Parse(Console.ReadLine());
                _employees[id].Age = age;
                Console.WriteLine("vui long nhap muc luong :");
                var salary = double.Parse(Console.ReadLine());
                _employees[id].Salary = salary;
                Console.WriteLine("sua thanh cong.");
            }
            else
            {
                Console.WriteLine("nhan vien khong ton tai: ");
            }
        }

        public void Delete()
        {
            Console.WriteLine("vui long nhap id : ");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                Console.WriteLine("xoa thanh cong: ");
                _employees.Remove(id);
            }
            else
            {
                Console.WriteLine("nhan vien khong ton tai: ");
            }
        }
    }
}