namespace Inheritance
{
    public class Teacher : Person
    {
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void explain()
        {
            Console.WriteLine("Explaining...");
        }
    }
}
