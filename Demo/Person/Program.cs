namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
    }
}