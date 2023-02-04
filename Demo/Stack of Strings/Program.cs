namespace Stack_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackofStrings myStack = new StackofStrings();
            myStack.Push("Hello");
            myStack.Push("World");
            List<String> myList = new List<String>();
            myList.Add("My Name");
            myList.Add("Is");
            myList.Add("Nhat Khoa");
            myList.Add("Nice to meet you!");
            myList.Add("Do you know me?");
            myStack.AddRange(myList);
            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}