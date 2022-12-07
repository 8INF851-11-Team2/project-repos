namespace LOCMI.Models.Menu.ExpMenu;

using System.Drawing;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Loaders;
using LOCMI.Core.Microcontrollers;
using LOCMI.Views;

public class LoadMicrocontrollerAdapterCommand : IExpMenuCommand
{
    private readonly CertificateExperimentalDTO _dto;

    private readonly ILoader<IMicrocontrollerAdapter> _loader;

    private readonly IView _view;

    public LoadMicrocontrollerAdapterCommand(IView view, CertificateExperimentalDTO dto, ILoader<IMicrocontrollerAdapter> loader)
    {
        _view = view;
        _dto = dto;
        _loader = loader;
    }

    /// <inheritdoc />
    public void Execute()
    {
        _view.Display("Enter path for the microcontroller adapter");
        string? path = _view.GetUserEntry();

        if (string.IsNullOrEmpty(path))
        {
            _view.Display("The path can't be null or empty", Color.Red);
            return;
        }

        IMicrocontrollerAdapter? microcontrollerAdapter;

        try
        {
            microcontrollerAdapter = _loader.Load(path);
        }
        catch (LoadException ex)
        {
            _view.Display(ex.Message, Color.Red);

            if (ex.InnerException != null)
            {
                _view.Display(ex.InnerException.Message, Color.Red);
            }

            return;
        }

        if (microcontrollerAdapter != null)
        {
            _dto.SetMicrocontroller(microcontrollerAdapter.GetResult());

            var command = new LoadCertificateCommand(_view, _dto, LoaderUtils.GetSameLoader<Certificate, IMicrocontrollerAdapter>(_loader));
            command.Execute();
        }
        else
        {
            _view.Display("The microcontroller adapter has not been loaded", Color.Red);
        }
    }

    /// <inheritdoc />
    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}