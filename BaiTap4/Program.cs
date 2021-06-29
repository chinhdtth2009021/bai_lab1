using System;

namespace BaiTap4
{
    internal class Program
    {
        delegate void MyDelegate(int soBatdau, int soKetThuc);

        static void TimSoNGueyTo(int soBatDau, int soKetThuc)
        {
            for (int i = soBatDau; i < soKetThuc; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }

                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }

                if (isPrime)
                {
                    Console.WriteLine($"{i}  la so nguyen to");
                }
            }
        }

        public static void Main(string[] args)
        {
            MyDelegate myDelegate = TimSoNGueyTo;
            myDelegate(1, 10);
        }
    }
}