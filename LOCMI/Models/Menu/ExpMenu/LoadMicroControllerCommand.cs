﻿namespace LOCMI.Models.Menu.ExpMenu;

using System.Drawing;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Loaders;
using LOCMI.Core.Microcontrollers;
using LOCMI.Views;

public sealed class LoadMicrocontrollerCommand : IExpMenuCommand
{
    private readonly CertificateExperimentalDTO _dto;

    private readonly ILoader<Microcontroller> _loader;

    private readonly IView _view;

    public LoadMicrocontrollerCommand(IView view, CertificateExperimentalDTO dto, ILoader<Microcontroller> loader)
    {
        _view = view;
        _dto = dto;
        _loader = loader;
    }

    public void Execute()
    {
        _view.Display("Enter Path for Microcontroller");
        string? path = _view.GetUserEntry();

        //REMOVE NEXT
        path = "JSON/MC/Test.Json";

        Microcontroller? microcontroller;

        try
        {
            microcontroller = _loader.Load(path);
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

        if (microcontroller != null)
        {
            _dto.SetMicrocontroller(microcontroller);
            ILoader<ITest> loader = LoaderUtils.GetSameLoader<ITest, Microcontroller>(_loader);

            var command = new LoadTestCommand(_view, _dto, loader);
            command.Execute();
        }
        else
        {
            _view.Display("The microcontroller has not been loaded", Color.Red);
        }
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}