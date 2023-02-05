namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Animal");
            Animal reptile = new Reptile("Reptile");
            Animal lizard = new Lizard("Lizard");
            Animal snake = new Snake("Snake");
            Animal mammal = new Mammal("Mammal");
            Animal bear = new Bear("Bear");
            Animal gorilla = new Gorilla("Gorilla");

            Console.WriteLine(animal.Name);
            Console.WriteLine(reptile.Name);
            Console.WriteLine(lizard.Name);
            Console.WriteLine(snake.Name);
            Console.WriteLine(mammal.Name);
            Console.WriteLine(bear.Name);
            Console.WriteLine(gorilla.Name);
        }
    }
}