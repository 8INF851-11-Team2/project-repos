using LOCMI.Controllers;
using LOCMI.Microcontrollers;

Console.WriteLine("Hello, World!");

var builder = new MicrocontrollerABuilder();
builder.GetResult();

var initialController = new InitialController();
initialController.Run();