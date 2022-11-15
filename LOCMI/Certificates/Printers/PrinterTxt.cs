namespace LOCMI.Certificates.Printers;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LOCMI.Certificates.Tests;

public sealed class PrinterTxt : IPrinter
{
    /// <inheritdoc />
    public async Task Print(Certificate certificate, string path)
    {
        if (!certificate.IsSuccess)
        {
            return;
        }

        await using StreamWriter file = new (path, true);
        string tests = "";
        foreach(TestCase test in ((TestSuite) certificate.Test).Tests)
        {
            tests += test.Name + "\n";
        }

        await file.WriteLineAsync("Certificate : " + certificate.Name + '\n' 
            + "Date : " + DateTime.Now  + '\n'
            + "Is sucess : " + certificate.IsSuccess + '\n'
            + "Tests : " + tests
            + "Description microcontroller : " + certificate.Microcontroller.Name + '\n');
    }
}