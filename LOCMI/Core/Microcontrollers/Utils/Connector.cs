namespace LOCMI.Core.Microcontrollers.Utils;

public struct Connector
{
    public Connector(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}