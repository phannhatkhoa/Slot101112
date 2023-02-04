namespace Random_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomList myList = new RandomList();
            myList.Add("Greenwich Da Nang");
            myList.Add("Khoa");
            myList.Add("Goodbye");
            myList.Add("Welcome to my presentation");
            myList.Add("658 Ngo Quyen");
            Console.WriteLine($"Remove the element: {myList.RemoveRandomElement()}");
            myList.ForEach(myList => Console.WriteLine(myList));
        }
    }
}