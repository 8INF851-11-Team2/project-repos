namespace LOCMI.Core.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Language
{
    public string Name { get; }
    public string Version { get; }

    public Language(string name, string version)
    {
        Name = name;
        Version = version;
    }
}
