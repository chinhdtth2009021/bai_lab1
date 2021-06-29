using System;
using System.Collections.Generic;
using System.Text;

namespace QUAnLyDanhba
{
    internal class Program
    {
        private static Dictionary<string, DanhBa> _dictionary = new Dictionary<string, DanhBa>();

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
        }

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("-------------Menu--------------");
                Console.WriteLine("1: Them Moi Vao Danh Ba:");
                Console.WriteLine("2: Tim so dien thoai theo ten: ");
                Console.WriteLine("3: Hien Thi Danh Sach trong danh ba: ");
                Console.WriteLine("4: Thoat.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("vui long nhap lua chon cua ban 1 > 4");
                int choice = int.Parse(Console.ReadLine());
                switch (@choice)
                {
                    case 1:
                        ThemMoiLienHe();
                        break;
                    case 2:
                        TimLienHe();
                        break;
                    case 3: HienThiLienHe();
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
        }

        public static void ThemMoiLienHe()
        {
            DanhBa danhBa = new DanhBa();
            Console.WriteLine("vui long nhap Name:");
            danhBa.Name = Console.ReadLine();
            Console.WriteLine("vui long nhap so dien thoai:");
            danhBa.Number = int.Parse(Console.ReadLine());
            _dictionary.Add(danhBa.Name, danhBa);
        }

        public static void TimLienHe()
        {
            Console.WriteLine($"vui long nhap ten cn tim: ");
            var name = Console.ReadLine();
            if (_dictionary.ContainsKey(name))
            {
                var danhba = _dictionary[name];
                Console.WriteLine($"da tim thay lien he, so la{danhba.Number} ");
            }
        }

        public static void HienThiLienHe()
        {
            Console.WriteLine("Name          || Number           ");
            foreach (KeyValuePair<string, DanhBa> item in _dictionary)
            {
                Console.WriteLine($"{item.Key}       {item.Value.Number}");  
            }
        }
    }
}