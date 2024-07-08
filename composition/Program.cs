

using composition;

internal class Program
{
    private static void Main(string[] args)
    {


        Engine engine = new Engine();
        engine.Power = 240;


        Cars cars = new Cars(Name.BMW, 2020, 7000_00, engine);

        Console.WriteLine(cars);


        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        engine.Power = 280;
        engine.Name = "Germany";

        cars.Name = Name.MS;
        cars.Engine = engine;
        cars.Price = 1000_000;

        Console.WriteLine("Name: " + cars.Name);
        Console.WriteLine("Model: " + cars.Model);
        Console.WriteLine("price: " + cars.Price);
        Console.WriteLine("power of engine: " + cars.Engine.Power);
        Console.WriteLine("name of engine is: "+engine.Name);
        Console.WriteLine("name of engine is: " + cars.Engine.Name);






        Console.ReadKey();
    }
}