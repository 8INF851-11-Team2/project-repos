namespace LOCMI.Core.Utils;

public class Port
{
    public Port(int numPin, string data, string ground, int power)
    {
        NumPin = numPin;
        Data = data;
        Ground = ground;
        Power = power;
    }

    public string Data { get; }

    public string Ground { get; }

    public int NumPin { get; }

    public int Power { get; }
}