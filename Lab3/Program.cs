using System;
using Lab3.entity;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* BAI 1 */
            // Atom atom = new Atom();
            // while (true)
            // {
            //     atom.Accept();
            //     Console.WriteLine("chon 1 de tiep tuc, 2 de ket thuc: ");
            //     int choice = Int32.Parse(Console.ReadLine());
            //     if (choice != 1)
            //     {
            //         break;
            //     }
            // }
            // atom.Distplay();
            //

            /* BAi 2 */
            NhanVien nhanVien = new NhanVien();
            Console.WriteLine("Please enter employee information: ");
            Console.WriteLine("First Name: ");
            nhanVien.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            nhanVien.LastName = Console.ReadLine();
            Console.WriteLine("Address: ");
            nhanVien.Address = Console.ReadLine();
            Console.WriteLine("Sin: ");
            nhanVien.Sin = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Salary: ");
            nhanVien.Salary = Convert.ToDouble(Console.ReadLine());
            nhanVien.ToString();
            
            
            var a = double.Parse(Console.ReadLine());
            nhanVien.TienLuong(0.1);
        }
    }
}