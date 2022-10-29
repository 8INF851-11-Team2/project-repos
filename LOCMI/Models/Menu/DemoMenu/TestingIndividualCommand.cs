using System;
using LOCMI.Models.Certificat;
namespace LOCMI.Models.Menu
{
    public class TestingIndividualCommand : ICommand
    {
        private Certificate _certificate;
        private CertifieurDemonstration _certifieurDemonstration;

        public TestingIndividualCommand(Certificate certificates, CertifieurDemonstration certifieur)
        {
            _certificate = certificates;
            _certifieurDemonstration = certifieur;
        }

        public void Execute()
        {
            List<Certificate> certificates = new List<Certificate>{ _certificate};
            _certifieurDemonstration.setCertificates(certificates);
            _certifieurDemonstration.apply();
        }

        public bool IsExecutable()
        {
            throw new NotImplementedException();
        }
    }
}

