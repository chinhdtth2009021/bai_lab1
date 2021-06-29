using System;

namespace ThietKeChuongTrinhCshap
{
    public class Student: Person
    {
        public override void ShowName()
        {
            Console.WriteLine($"toi la {FirstName}  {LastName}, toi la sinh vien: ");
        }
        public  Student(string firstName, string lastName):base(firstName,lastName)
        {
        }
    }
}