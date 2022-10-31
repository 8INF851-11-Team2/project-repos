using LOCMI.Core.Test;
using LOCMI.Noyau;
using LOCMI.Controllers;

Console.WriteLine("Hello, World!");

var builder = new MicrocontrollerABuilder();
builder.GetResult();

InitialController initialController = new InitialController();
initialController.run();
