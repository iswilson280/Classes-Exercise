namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Dodge";
            myCar.Model = "Charger";
            myCar.Year = 2022;

            Console.WriteLine($"{myCar.Make}" );
            Console.WriteLine($"{myCar.Model}");
            Console.WriteLine($"{myCar.Year}");


        }

    }
}
