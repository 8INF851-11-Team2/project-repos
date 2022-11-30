namespace LOCMI.Core.Microcontrollers.Utils;

public struct Dimension
{
    public Dimension(double length, double width, double height, double weight)
    {
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
    }

    public double Height { get; set; }

    public double Length { get; set; }

    public double Weight { get; set; }

    public double Width { get; set; }
}