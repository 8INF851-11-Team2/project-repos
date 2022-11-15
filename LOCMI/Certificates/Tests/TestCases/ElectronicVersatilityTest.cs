namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;
using LOCMI.Core.Utils.PortTypes;

/// <summary>
///     Test if the microcontroller supports different voltages.
/// </summary>
/// <remarks>Test 1</remarks>
public sealed class ElectronicVersatilityTest : TestCase
{
    private readonly IEnumerable<double> _testedVoltage;

    public ElectronicVersatilityTest(IEnumerable<double> testedVoltage)
        : base("Electronic versatility")
    {
        _testedVoltage = testedVoltage;
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Ports != null)
        {
            IEnumerable<PowerPort> powerPorts = microcontroller.Ports.OfType<PowerPort>();

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return _testedVoltage.Where(v => powerPorts.All(p => p.Voltage != v))
                                 .Select(static v => $"The microcontroller does not support an electrical voltage of {v}V")
                                 .ToList();
        }

        return new[] { "The microcontroller has no ports" };
    }
}