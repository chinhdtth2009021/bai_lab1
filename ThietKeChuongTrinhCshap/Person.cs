namespace ThietKeChuongTrinhCshap
{
    public abstract class Person
    {
       

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void ShowName();
        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}