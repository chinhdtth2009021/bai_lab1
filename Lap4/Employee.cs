using System;

namespace Lap4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; } //phongf ban
        public double Salary { get; set; } // tien luong
        public String DateHired { get; set; }

        public override string ToString()
        {
            return
                $"Name: {Name}, Phone: {Phone}, Address: {Address},Email: {Email}, Department: {Department}, Salaary: {Salary}, Date Haired: {DateHired}";
        }

        public abstract double CalculBonus();
        public abstract void CalculateVacation();
    }
}