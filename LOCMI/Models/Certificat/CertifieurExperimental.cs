using System;
using LOCMI.Controllers;
namespace LOCMI.Models.Certificat
{
    public class CertifieurExperimental
    {
        private MicroController _microController;
        private Test _test;
        private Certificate _certificate;

        public CertifieurExperimental(PromptController promptContoller)
        {
        }

        public void setMicroController(MicroController microController)
        {
            _microController = microController;
        }
        public void setTest(Test test)
        {
            _test = test;
        }

        public void apply()
        {

        }
    }
}

