using System;

namespace Lap4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student()
            {
                Name = "Duong Thi chinh",
                Phone = "0987987789",
                Email = "chinh@gmail.com",
                Address = "Thai Nguyen",
                Program = "ADSE"
            };
            Console.WriteLine(student.ToString());

            var staff = new Staff
            {
                Name = "Duong Thi Thom",
                Phone = "0987654321",
                Email = "hom@gmail.com ",
                Address = "Thai Nguyen",
                Title = "nhan vien thu ngan",
                Salary = 800,
                Department = "ke toan",
                DateHired = 4
            };
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"thuong cua {staff.Name} là : {staff.CalculBonus()}");
           // Console.WriteLine($"tuan nghi cua {staff.Name} là : {staff.CalculateVacation()}");


            var faculty = new Faculty()
            {
                Name = "Duong Thi Thuong",
                Phone = "0987654321",
                Email = "Thuong@gmail.com",
                Address = "Thai Nguyen",
                OfficeHour = "7h - 16h30",
                Salary = 700,
                DateHired = 5,
                Rank = 1,
                Department = "to tu nhien"
            };
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"thuong cua {faculty.Name} là : {faculty.CalculBonus()}");
           // Console.WriteLine($"tuan nghi cua {faculty.Name} là : {faculty.CalculateVacation()}");
        }
    }
}