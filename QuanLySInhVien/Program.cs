using System;
using System.Text;
using QuanLySInhVien.view;

namespace QuanLySInhVien
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVienView svView = new SinhVienView();
            svView.ShowMenu();
        }
    }
}