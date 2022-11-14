namespace LOCMI.Certificates.Printers;

using System.Collections.Generic;
using LOCMI.Certificates.Tests;

public sealed class PrinterTxt : IPrinter
{
    /// <inheritdoc />
    public async Task Print(Certificate certificate, string path)
    {
        await using StreamWriter file = new (path, true);
        string tests = "";
        List<TestFailure> tf = certificate.TestResult.TestFailures;
        //foreach (ITest test in certificate.Test.Tests)
        //{
            //if(test is in tf.)
        //}
        await file.WriteLineAsync("Certificate : " + certificate.Name + '\n' 
            + "Date : " + DateTime.Now  + '\n'
            + "Is sucess : " + certificate.IsSuccess + '\n'
            + "Description microcontroller : " + certificate.Microcontroller.Name + '\n');
    }
}