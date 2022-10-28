namespace LOCMI.Core.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dimension
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }
    public double Weight { get; }

    public Dimension(double length, double width, double height, double weight)
    {
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
    }
}
