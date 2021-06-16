using System;

namespace lab5.ex2
{
    public class UniversityTeacher : Exercise2, IEmployeeAction
    {
        public  string UniversityTeacherCode { get; set; }
        public int EnglishSkilllevel { get; set; } // 1 level tang them 10% luong

        public double CalculateSalary()
        {
            if (SeniorLecture < 60000)
            {
                throw new AmountException($"Senior lecture can not get less than 60,000 salary", FullName);
            }

            if (Bonus > 10000)
            {
                throw new AmountException($"Bonus is more than 10,000", FullName);
            }
            return BaseSalary * Skilllevel + ((BaseSalary /10) * EnglishSkilllevel) + SeniorLecture + Bonus; 
        }
    }
}