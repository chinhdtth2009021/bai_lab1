using System;

namespace lab5.ex2
{
    public abstract class Exercise2
    {
        public string IdentityNumer { get; set; }
        public string FullName { get; set; }
        public double BaseSalary { get; set; }// luong co ban
        public int Skilllevel { get; set; } // dung tinh thong tin luong
        public double SeniorLecture { get; set; } //cong them vao luong
        public double Bonus { get; set; }// cong them vao luong

       // public abstract double CalculateSalary(); // base senior lecture and  bonus

        // public class AmountException : Exception
        // {
        //     public AmountException()
        //     { }
        //     public AmountException(string message):base(message)
        //     { }
        // }
        //
        // public class SeniorLecture
        // {
        //     public double Salary { get; set; }
        //     public double Bonus { get; set; }
        //     public string Name { get; set; }
        // }

        //public abstract double CalculateSalary();
    }
}