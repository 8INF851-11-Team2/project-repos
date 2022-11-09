namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;
using LOCMI.Core.Utils.PortTypes;

public sealed class TestCase1 : TestCase
{
    private static readonly double[] s_testedVoltage = { 3.3, 5 };

    public TestCase1()
        : base("Electronic versatility")
    {
    }

    public override void Run(ITestResult testResult, Microcontroller mc)
    {
        if (mc.Ports != null)
        {
            IEnumerable<PowerPort> powerPorts = mc.Ports.OfType<PowerPort>();

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            IEnumerable<string> failureCauses = s_testedVoltage.Where(v => powerPorts.All(p => p.Voltage != v))
                                                               .Select(static v => $"The microcontroller does not support an electrical voltage of {v}V")
                                                               .ToList();

            if (failureCauses.Any())
            {
                testResult.AddFailure(this, failureCauses);
            }
            else
            {
                testResult.IncrementRunCounter();
            }
        }
        else
        {
            testResult.AddFailure(this, new[] { "The microcontroller has no ports" });
        }
    }
}