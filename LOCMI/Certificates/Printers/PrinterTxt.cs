namespace LOCMI.Certificates.Printers;

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

        string tests = certificate.Test switch
        {
            TestSuite testSuite => string.Join(string.Empty, testSuite.Tests.OfType<TestCase>().Select(static c => c.Name + "\n")),
            TestCase testCase => testCase.Name + "\n",
            _ => string.Empty,
        };

        await file.WriteLineAsync("Certificate : " + certificate.Name + '\n' + "Date : " + DateTime.Now + '\n' + "Is success : " + certificate.IsSuccess + '\n'
                                + "Tests : " + tests + "Description microcontroller : " + certificate.Microcontroller.Name + '\n');
    }
}