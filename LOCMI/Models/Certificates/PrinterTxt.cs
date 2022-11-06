namespace LOCMI.Models.Certificates;

public class PrinterTxt : IPrinter
{
    public void Print(List<Certificate> certificates, string path)
    {
        foreach(var certificate in certificates)
        {
            Print(certificate, path);
        }
    }

    public async void Print(Certificate certificate, string path)
    {
        string[] lines =
        {
            certificate.GetName(), certificate.IsSuccess().ToString()
        };

        await File.WriteAllLinesAsync(path, lines);
    }
}