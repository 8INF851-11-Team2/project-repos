using System;
using LOCMI.Models.Certificat;
using LOCMI.Noyau;
namespace LOCMI.Models.Menu
{
    public interface ILoader
    {
        public Test loadTest(string path);
        public MicroController loadController(string path);
    }
}

