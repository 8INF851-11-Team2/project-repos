namespace LOCMI.Models.Certificates.TestCase;

using LOCMI.Core;

public class TestCaseB : TestCase
{
    public TestCaseB(string name) : base(name) { }

    public override void Run(ITestResult tr, Microcontroller mc)
    {
        if (mc.Name != null && mc.Name.Equals("MicrocontrollerB"))
        {
            tr.IncrementRunCounter();
        }
        else
        {
            tr.AddFailure(this, "Names are not similar : '" + mc.Name + "' and 'MicrocontrollerB'");
        }
    }
}
