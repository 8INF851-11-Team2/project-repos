namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Microcontrollers;

public interface ILoader
{
    public Microcontroller LoadController(string path);

    public ITest LoadTest(string path);
}