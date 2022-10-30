namespace LOCMI.Core.Utils;

public struct Identification
{
    public Identification(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public string Brand { get; }

    public string Model { get; }
}