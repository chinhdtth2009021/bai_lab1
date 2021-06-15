using System;
using System.Text;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sin = "193456787";
            if (sin.Length != 9)
            {
                Console.WriteLine("sin phai la chuoi gom 9 so: ");
               return; 
            }
            char[] splitedSin = sin.ToCharArray();
            int[] sinlnNumber = new int[9];
            for (int i = 0; i < splitedSin.Length; i++)
            {
                sinlnNumber[i] = int.Parse(splitedSin[i].ToString());
            }
            var tongSoHangChan = 0;
            var tongSoHangLe = 0;
            for (int i = 0; i < sinlnNumber.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    tongSoHangLe += sinlnNumber[i];
                }
                else
                {
                    var temp = (sinlnNumber[i] * 2).ToString().ToCharArray();
                    for (int j = 0; j < temp.Length; j++)
                    {
                        tongSoHangChan += Convert.ToInt32(temp[j].ToString());
                    }
                }
            }
            var sun = tongSoHangChan + tongSoHangLe;
            if ((sun + sinlnNumber[sinlnNumber.Length - 1]) %10 == 0)
            {
                Console.WriteLine("this i valid sin");
            }
            else
            {
                Console.WriteLine("loi");
            }
        }
    }
}