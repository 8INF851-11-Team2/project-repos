using System;
using LOCMI.Controllers;
using LOCMI.Models.Certificat;
namespace LOCMI.Models.Menu
{
    public class LoadTestCommand : ICommand
    {
        private ILoader _loader;
        private ScannerController _scannerController;
        private Test _test;
        private CertifieurExperimental _certifieur;

        /* CertifieurExp ScannerController ?? */
        public void LCC(CertifieurExperimental certifieur, ScannerController scannerController)
        {

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsExecutable()
        {
            throw new NotImplementedException();
        }
    }
}

