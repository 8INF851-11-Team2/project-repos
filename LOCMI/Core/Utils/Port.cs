namespace LOCMI.Core.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Port
{
    public int NumPin { get; }
    public string Data { get; }
    public string Ground { get; }
    public int Power { get; }

    public Port(int numPin, string data, string ground, int power)
    {
        NumPin = numPin;
        Data = data;
        Ground = ground;
        Power = power;
    }
}
