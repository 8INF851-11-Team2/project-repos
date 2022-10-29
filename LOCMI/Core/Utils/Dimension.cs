namespace LOCMI.Core.Utils;

public class Dimension
{
    public Dimension(double length, double width, double height, double weight)
    {
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
    }

    public double Height { get; }

    public double Length { get; }

    public double Weight { get; }

    public double Width { get; }
}