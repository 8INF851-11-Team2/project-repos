namespace LOCMI.Certificate.TestCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestResult;
using LOCMI.Core;

public class TestCaseA : TestCase
{
    public TestCaseA(string name) : base(name) { }

    public override void Run(ITestResult tr, Microcontroller mc)
    {
        if (mc.Name != null && mc.Name.Equals("MicrocontrollerA"))
        {
            tr.IncrementRunCounter();
        }
        else
        {
            tr.AddFailure(this, "Names are not similar : '" + mc.Name + "' and 'MicrocontrollerA'");
        }
    }
}
