namespace LOCMI.Core.Certificates.Printers;

public interface IPrinter
{
    public async Task Print(IEnumerable<Certificate> certificates, string path)
    {
        string pathDir = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
        Directory.CreateDirectory(pathDir);

        foreach (Certificate cert in certificates)
        {
            await Print(cert, pathDir + "/" + cert.Name + "_" + cert.Microcontroller.Name + "_" + path);
        }
    }

    public Task Print(Certificate certificate, string path);
}