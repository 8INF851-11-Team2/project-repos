
using System;
using LOCMI.Models.Certificat;
using LOCMI.Controllers;
namespace LOCMI.Models.Menu
{
    public class PrintCommand : ICommand
    {
        private CertifieurDemonstration _cerifieurDemonstration;
        private CertifieurExperimental _certifieurExperimental;
        private ScannerController _scannerController;
        private IPrinter _printer;

        public PrintCommand(CertifieurDemonstration certifieurDemonstration)
        {
            _cerifieurDemonstration = certifieurDemonstration;
        }
     
        public void Execute()
        {
            string path = _scannerController.run();
            List<Certificate> c = _cerifieurDemonstration.getCertificates();
            _printer.print(c, path);
        }

        public bool IsExecutable()
        {
            throw new NotImplementedException();
        }
    }
}

