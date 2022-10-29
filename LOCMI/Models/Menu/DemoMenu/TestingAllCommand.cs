using System;
using LOCMI.Models.Certificat;
namespace LOCMI.Models.Menu
{
    public class TestingAllCommand : ICommand
    {
        private CertifieurDemonstration _certifieur;
        private List<Certificate> _certificats;

        public TestingAllCommand(List<Certificate> certificates, CertifieurDemonstration certifieur)
        {
            _certificats = certificates;
            _certifieur = certifieur;
        }

        public void Execute()
        {
            _certifieur.setCertificates(_certificats);
            _certifieur.apply();
        }

        public bool IsExecutable()
        {
            throw new NotImplementedException();
        }
    }
}

