namespace Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Activator.CreateInstance(typeof(Program).Assembly.GetName().Name!, "Reflection.Car")?
            .Unwrap()
            .GetType()
            .GetProperties()
            .ToList()
            .ForEach(property =>
                Console.WriteLine("public static {0} = {1}", property.Name, property.GetValue(new Car(), null)));

        Console.WriteLine("----------------------------------------------");

        Activator.CreateInstance(typeof(Program).Assembly.GetName().Name!, "Reflection.Bike")?
            .Unwrap()
            .GetType()
            .GetProperties()
            .ToList()
            .ForEach(property =>
                Console.WriteLine("public static {0} = {1}", property.Name, property.GetValue(new Bike(), null)));
    }
}