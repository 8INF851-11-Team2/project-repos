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

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Ports != null)
        {
            IEnumerable<PowerPort> powerPorts = microcontroller.Ports.OfType<PowerPort>();

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return s_testedVoltage.Where(v => powerPorts.All(p => p.Voltage != v))
                                  .Select(static v => $"The microcontroller does not support an electrical voltage of {v}V")
                                  .ToList();
        }

        return new[] { "The microcontroller has no ports" };
    }
}