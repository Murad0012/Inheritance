namespace Inheritance
{
    public class Student : Person
    {
        public Student(string name, string surname, int age) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void learn()
        {
            Console.WriteLine("Learning...");
        }
    }
}
