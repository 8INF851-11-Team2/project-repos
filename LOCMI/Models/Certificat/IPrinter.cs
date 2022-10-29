using System;
using LOCMI.Models.Certificat;
namespace LOCMI.Models.Menu
{
    public interface IPrinter
    {
        public void print(List<Certificate> certificates, string path);
        public void print(Certificate certificate, string path);
    }
}

