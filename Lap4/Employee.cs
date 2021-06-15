using System;

namespace Lap4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; } //phongf ban
        public double Salary { get; set; } // tien luong
        public int DateHired { get; set; }
        public abstract double CalculBonus();
        public abstract void CalculateVacation();
    }
}