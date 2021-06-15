using System;

namespace Lap4
{
    public class Staff : Employee
    {
        public string Title { get; set; }

        public override double CalculBonus()
        {
            double result;
            result = Salary * 0.06;
            return result;
        }

        public override void CalculateVacation()
        {
            Console.WriteLine("Vui long nhap vao nam lam viec: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 5)
            {
                Console.WriteLine("Duoc nghi phep 4 tuan.");
            }
            else
            {
                Console.WriteLine("Duoc nghi phep 3 tuan.");
            }
        }
    }
}