namespace LOCMI.Certificate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Test;

public interface IPrinter
{
    public void Print(List<Certificate> l, string path)
    {
        foreach(Certificate cert in l)
        {
            Print(cert, path);
        }
    }

    public void Print(Certificate certificate, string path) // Print Arbitraire pour l'instant
    { 
        Console.WriteLine("Certificate : " + certificate.Name + ", result : " + certificate.IsSucces);
    }
}
