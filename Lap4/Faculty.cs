using System;

namespace Lap4
{
    public class Faculty : Employee
    {
        public string OfficeHour { get; set; }
        public int Rank { get; set; }

        public override string ToString()
        {
            return
                $"Name: {Name}, Phone: {Phone}, Address: {Address}, Email: {Email}, Department: {Department}, Salary: {Salary}, Date Hired: {DateHired}, OfficeHour: {OfficeHour}, Rank: {Rank}";
        }

        public override double CalculBonus()
        {
            double result;
            result = Salary * 0.05 + 1000;
            return result;
        }

        public override void CalculateVacation()
        {
            Console.WriteLine("Vui long nhap so nam lam viec: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 3 && Rank == 1)
            {
                Console.WriteLine("Duoc nghi phep 6 tuan.");
            }
            else if (year > 3)
            {
                Console.WriteLine("Duoc nghi phep 5 tuan.");
            }
            else
            {
                Console.WriteLine("Duoc nghi phep 4 tuan.");
            }
        }
    }
}