using System;

namespace ThietKeChuongTrinhCshap
{
    public class Teacher: Person
    {
        public override void ShowName()
        {
            Console.WriteLine($"toi la {FirstName}  {LastName}, toi la giao vien: ");
        }

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}