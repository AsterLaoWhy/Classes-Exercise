namespace Classes
{

    public class Program
    {
        static void Main(string[] args)
        {
            
            var newCar = new Car();
            newCar.make="VW";
            Console.WriteLine($"{newCar.make}");
            newCar.model="Golf";
            Console.WriteLine($"{newCar.model}");
            newCar.year=2016;
            Console.WriteLine($"{newCar.year}");
            Console.ReadLine();
        }
    }
}
