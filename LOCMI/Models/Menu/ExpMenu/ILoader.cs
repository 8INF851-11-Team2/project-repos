namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Core;
using LOCMI.Certificates.Tests;

public interface ILoader
{
    public Microcontroller LoadController(string path);

    public ITest LoadTest(string path);
}