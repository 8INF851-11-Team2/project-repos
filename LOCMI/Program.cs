using LOCMI.Core.Test;
using LOCMI.Noyau;

Console.WriteLine("Hello, World!");

AdapterABuilder builder = new AdapterABuilder();
MicroController mc = builder.GetResult();
