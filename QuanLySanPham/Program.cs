using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySanPham
{
    internal class Program
    {
        private static List<ThongTinSanPham> _thongTinSanPhams = new List<ThongTinSanPham>();

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
        }

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("-----------Menu--------------------");
                Console.WriteLine("1: Tao san pham moi: ");
                Console.WriteLine("2: Hien thi danh sach san pham: ");
                Console.WriteLine("3: xoa sana pham");
                Console.WriteLine("4: thoat:");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("vui long nhap lua chon 1 > 4");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TaoMoiSanPham();
                        break;
                    case 2:
                        HienThiDanhSachSanPham();
                        break;
                    case 3:
                        XoaSanPham();
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
        }

        public static void TaoMoiSanPham()
        {
            var thongTinSanPham = new ThongTinSanPham();
            Console.WriteLine("vui long nhap Id");
            thongTinSanPham.Id = Console.ReadLine();
            Console.WriteLine("vui long nhap Name san pham");
            thongTinSanPham.Name = Console.ReadLine();
            Console.WriteLine("vui long nhap price");
            thongTinSanPham.Price = double.Parse(Console.ReadLine());
            _thongTinSanPhams.Add(thongTinSanPham);
        }

        public static void HienThiDanhSachSanPham()
        {
            foreach (var sanPham in _thongTinSanPhams)
            {
                Console.WriteLine(sanPham.ToString());
                
            }
        }

        public static void XoaSanPham()
        {
            Console.WriteLine("vui long nhap Id san Pham can xoa: ");
            var id = Console.ReadLine();
            for (int i = 0; i < _thongTinSanPhams.Count; i++)
            {
                var thongTin = _thongTinSanPhams[i];
                if (thongTin.Id.Equals(id))
                {
                    Console.WriteLine($"Tim thay san pham co id {id} co ten la:");
                    Console.WriteLine("ban co chac muon xoa (c/k)");
                    var luachon = Console.ReadLine();
                    if (luachon.ToLower().Equals("c"))
                    {
                        _thongTinSanPhams.RemoveAt(i);
                        Console.WriteLine("xoa thanh cong");
                    }
                    else
                    {
                        Console.WriteLine("khong tim thay san pham:");
                    }

                    break;
                }
            }
        }
    }
}