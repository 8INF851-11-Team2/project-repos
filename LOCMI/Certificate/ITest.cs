namespace LOCMI.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestResult;
using LOCMI.Core;

public interface ITest
{ 
    public void Run(ITestResult tr, Microcontroller mc);
}
