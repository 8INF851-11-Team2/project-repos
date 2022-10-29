using System;
using LOCMI.Models.Certificat;
namespace LOCMI.Models.Menu
{
    public class TestingIndividualCommand : ICommand
    {
        private Certificate _certificate;

        public TestingIndividualCommand(Certificate certificates, Certifieur certifieur)
        {
            _certificate = certificates;
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

