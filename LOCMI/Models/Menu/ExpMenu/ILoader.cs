namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Core;
using LOCMI.Models.Certificates;

public interface ILoader
{
    public Microcontroller LoadController(string path);

    public ITest LoadTest(string path);
}