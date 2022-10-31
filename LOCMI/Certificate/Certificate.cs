namespace LOCMI.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestResult;
using LOCMI.Core;

public class Certificate
{
    public Microcontroller Microcontroller { get; set; }
    public string Name { get; set; }
    public bool IsSucces { get; set; } = false;
    public DateOnly Date { get; set; }
    public ITestResult TestResult { get; set; }
    public ITest Test { get; set; } //TestSuite

    public Certificate(ITest test, Microcontroller mc, string name) //name oublié par ATI ?
    {
        Name = name;
        Microcontroller = mc;
        Test = test;
        TestResult = new TestResultImpl();
    }

    public void Certifier() //FR non En
    {
        Test.Run(TestResult, Microcontroller);
        if (TestResult.IsSucceful())
        {
            IsSucces = true;
        }
    }
}
