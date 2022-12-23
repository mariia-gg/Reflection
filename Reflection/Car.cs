namespace Reflection;

internal class Car
{
    public string Model { get; set; }

    public string Brand { get; set; }

    public int HorsePowers { get; set; }

    public Car()
    {
        Model = "Ferrari";
        Brand = "458 California";
        HorsePowers = 760;
    }
}