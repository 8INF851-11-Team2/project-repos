namespace LOCMI.Core.Microcontrollers.Utils;

public struct OS
{
    public OS(string name)
    {
        Name = name;
    }

    public string? Name { get; set; }
}