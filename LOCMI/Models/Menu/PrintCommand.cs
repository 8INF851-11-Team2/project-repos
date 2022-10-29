
using System;
using LOCMI.Models.Certificat;
namespace LOCMI.Models.Menu
{
    public class PrintCommand : ICommand
    {
        private CertifieurDemonstration _cerifieurDemonstration;
        private CertifieurExperimental _certifieurExperimental;
     
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

