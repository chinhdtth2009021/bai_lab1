using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.entity
{
    public class NhanVien
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }

        // public NhanVien(string firstName, string lastName, string address, long sin, double salary)
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        //     Address = address;
        //     Sin = sin;
        //     Salary = salary;
        // }

        public override string ToString()
        {
            return $"Full Name: {FirstName}  {LastName}, Address: {Address}, Sin: {Sin}, Salary: {Salary}";
        }

        public double TienLuong(double percentage)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tien Luong: {this.Salary * percentage / 100}");
            return Salary * percentage;
        }
    }
}