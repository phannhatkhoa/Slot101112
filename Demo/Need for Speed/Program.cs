namespace Need_for_Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar(250, 70);
            sportCar.Drive(100);
            Console.WriteLine("Sport Car remaining fuel: " + sportCar.Fuel);

            RaceMotorcycle rcmotor = new RaceMotorcycle(120, 100);
            rcmotor.Drive(50);
            Console.WriteLine("Race Motorcycle remaining fuel: " +rcmotor.Fuel);
        }
    }
}