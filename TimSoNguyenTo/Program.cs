using System;

namespace TimSONguyenTo
{
    internal class Program
    {
        delegate void MyDelegate(int soBatDau, int soKeetThuc);

        public static void TimSoNguyenTo(int soBatDau, int soKetThuc)
        {
            Console.WriteLine($"delegate da goi dem ham: {soBatDau} {soKetThuc}");
        }
        public static void Main(string[] args)
        {
            MyDelegate myDelegate = TimSoNguyenTo;
            myDelegate(01, 20);
        }
    }
}