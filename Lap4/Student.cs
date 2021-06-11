namespace Lap4
{
    public class Student : Person
    {
        public int Program { set; get; }
        /*1. Business
         2. Computer
         3. Science*/

        public override string ToString()
        {
            return $" Name: {Name}, Phone: {Phone}, Address: {Address}, Email: {Email}, Program: {Program}";
        }
    }
}