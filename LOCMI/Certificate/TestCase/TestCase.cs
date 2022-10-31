using LOCMI.Test;

namespace LOCMI.Certificate.TestCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestResult;
using LOCMI.Core;

public abstract class TestCase : ITest
{
    public string Name { get; set; }

    public TestCase(string name)
    {
        Name = name;
    }

    public abstract void Run(ITestResult tr, Microcontroller mc);
}
