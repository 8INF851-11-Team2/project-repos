using System;
using LOCMI.Models.Certificat;
namespace LOCMI.Models.Menu
{
    public interface ILoader
    {
        public Test loadTest(string path);
        public MicroController loadController(string path);
    }
}

