namespace LOCMI.Core.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class Identification
{
    public Identification(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public string Brand { get; }

    public string Model { get; set; }
}
