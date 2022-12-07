namespace LOCMI.Controllers;

using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Loaders;
using LOCMI.Core.Microcontrollers;
using LOCMI.Models.Menu;
using LOCMI.Models.Menu.ExpMenu;
using LOCMI.Views;

public sealed class ExperimentalController : MenuController<IExpMenuCommand>
{
    public ExperimentalController(IView view)
        : base(view, false)
    {
    }

    protected override Menu<IExpMenuCommand> SetMenu()
    {
        var certificateExperimentalDTO = new CertificateExperimentalDTO();

        var loadJsonMicrocontroller = new LoadMicrocontrollerCommand(View, certificateExperimentalDTO, new JsonLoader<Microcontroller>());
        var loadDllAdapter = new LoadMicrocontrollerAdapterCommand(View, certificateExperimentalDTO, new ExternalClassLoader<IMicrocontrollerAdapter>());

        return new Menu<IExpMenuCommand>("Experimental Menu")
        {
            { "Import from JSON", loadJsonMicrocontroller },
            { "Import from Code", loadDllAdapter },
        };
    }
}