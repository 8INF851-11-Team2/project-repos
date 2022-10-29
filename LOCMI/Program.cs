using LOCMI.Core.Test;
using LOCMI.Noyau;
using LOCMI.Controllers;

Console.WriteLine("Hello, World!");

AdapterABuilder builder = new AdapterABuilder();
MicroController mc = builder.GetResult();

InitialController initialController = new InitialController();
initialController.run();
