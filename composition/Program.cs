

using composition;

internal class Program
{
    private static void Main(string[] args)
    {


        Engine engine = new Engine();
        engine.setPower(240);


        Cars cars = new Cars(Name.BMW, 2020, 7000_00, engine);
        Console.WriteLine("Name: " + cars.getName());
        Console.WriteLine("Model: " + cars.getModel());
        Console.WriteLine("price: " + cars.getPrice());
        Console.WriteLine("power of engine: " + cars.getEngine().getPower());

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        engine.setPower(280);
        engine.setName("Germany");
        cars.setEngine(engine);
        cars.setName(Name.MS);

        Console.WriteLine("Name: " + cars.getName());
        Console.WriteLine("Model: " + cars.getModel());
        Console.WriteLine("price: " + cars.getPrice());
        Console.WriteLine("power of engine: " + cars.getEngine().getPower());
        Console.WriteLine("name of engine is: "+engine.getName());
        Console.WriteLine("name of engine is: " + cars.getEngine().getName());






        Console.ReadKey();
    }
}