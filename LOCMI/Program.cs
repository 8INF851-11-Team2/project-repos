using LOCMI.Controllers;
using LOCMI.Microcontrollers;

var builder = new MicrocontrollerABuilder();
builder.GetResult();

var initialController = new InitialController();
initialController.Run();