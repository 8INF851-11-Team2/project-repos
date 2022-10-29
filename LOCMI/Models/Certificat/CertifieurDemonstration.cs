using System;
using LOCMI.Controllers;
namespace LOCMI.Models.Certificat
{
    public class CertifieurDemonstration
    {
        private List<Certificate> _certificates;
        private PromptController _promptController;

        public CertifieurDemonstration()
        {
            _certificates = new List<Certificate>(); 
        }

        public void setCertificates(List<Certificate> certificates)
        {
            _certificates = certificates;
        }

        public List<Certificate> getCertificates()
        {
            return _certificates;
        }

        public void apply()
        {
            /* TODO */
        }
    }
}

