using System;
using System.Text;
using lab5.or;
using Exception = lab5.ex2.Exercise2;

namespace lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Bai 1 */
            // Bread bread = new Bread();
            // Grocery grocery = new Grocery();
            // while (true)
            // {
            //     Console.WriteLine("vui long nhap lua chon cua ban: ");
            //     Console.WriteLine("----------------------------------");
            //     Console.WriteLine("1: Hang Tap Hoa");
            //     Console.WriteLine("2: Banh Mi");
            //     Console.WriteLine("3: Thoat");
            //     Console.WriteLine("----------------------------------");
            //     int choice = Int32.Parse(Console.ReadLine());
            //     switch (choice)
            //     {
            //         case 1:
            //             grocery.orderGrocery();
            //             break;
            //         case 2:
            //             bread.orderBread();
            //             break;
            //     }
            //     //Console.ReadLine();
            //     if (choice == 3)
            //     {
            //         Console.WriteLine("tam biet!!!");
            //         break;
            //     }
            // }
            /* bai 2 */
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("vui lòng nhập tên");
            var name = Console.ReadLine();
            Console.WriteLine("vui lòng nhập salary");
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine("vui lòng nhập bonus");
            var bonus = double.Parse(Console.ReadLine());
            var seniorLecture = new Exception.SeniorLecture
            {
                Name = name,
                Salary = salary,
                Bonus = bonus
            };

            try
            {
                CheckAmount(seniorLecture);
            }
            catch (Exception.AmountException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public static void CheckAmount(Exception.SeniorLecture seniorLecture)
        {
            if (seniorLecture.Salary < 60000)
            {
                throw new Exception.AmountException(
                    $"mức lương của giảng viên {seniorLecture.Name} tối thiểu phải từ 60000");
            }
            else if (seniorLecture.Bonus > 10000)
            {
                throw new Exception.AmountException(
                    $"mức thưởng của giảng viên {seniorLecture.Name} tối đa không quá 10000");
            }
            else
            {
                Console.WriteLine("Okie");
            }
        }
    }
}

