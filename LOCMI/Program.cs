using LOCMI.Controllers;
using LOCMI.Microcontrollers;
using LOCMI.Views;

IView view = new ConsoleView();

var builder = new MicrocontrollerABuilder();
builder.GetResult();

var initialController = new InitialController(view);
initialController.Run();