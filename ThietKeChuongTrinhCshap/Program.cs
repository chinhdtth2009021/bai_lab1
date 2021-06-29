namespace ThietKeChuongTrinhCshap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var teacher = new Teacher("Dao", "Hung");
            teacher.ShowName();
            var student = new Student("Duong", "Chinh");
            student.ShowName();
        }
    }
}