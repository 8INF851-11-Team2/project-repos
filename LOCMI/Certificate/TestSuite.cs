namespace LOCMI.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestResult;
using LOCMI.Core;

public class TestSuite : ITest
{
    public List<ITest> Tests { get; }

    public TestSuite()
    {
        Tests = new List<ITest>();
    }

    public void AddTest(ITest test)
    {
        Tests.Add(test);
    }

    public void Run(ITestResult tr, Microcontroller mc)
    {
        foreach (ITest test in Tests)
        {
            test.Run(tr, mc);
        }
    }
}
