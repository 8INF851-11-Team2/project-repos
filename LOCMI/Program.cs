using LOCMI.Controllers;
using LOCMI.Microcontrollers;
using LOCMI.Views;

var builder = new MicrocontrollerABuilder();
builder.GetResult();

var initialController = new InitialController(new View());
initialController.Run();