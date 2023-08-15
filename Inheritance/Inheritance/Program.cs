namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Murad", "Memmedzade", 17);
            var teacher1 = new Teacher("Tural", "Memmedov", 30);
            student1.learn();
            teacher1.explain();
        }
    }
}