namespace lab5.ex2
{
    public class HighSchoolTeacher : Exercise2, IEmployeeAction
    {
        public string HighSchoolTeacherCode { get; set; }
        public double CalculateSalary()
        {
            return BaseSalary * Skilllevel + SeniorLecture + Bonus;
        }
    }
}