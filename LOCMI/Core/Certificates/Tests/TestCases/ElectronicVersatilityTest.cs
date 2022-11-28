namespace LOCMI.Core.Certificates.Tests.TestCases;

using System.Collections;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

/// <summary>
///     Test if the microcontroller supports different voltages.
/// </summary>
/// <remarks>Test 1</remarks>
public sealed class ElectronicVersatilityTest : TestCase, IEnumerable<double>
{
    private readonly List<double> _testedVoltage = new ();

    public ElectronicVersatilityTest()
        : base("Electronic versatility")
    {
    }

    public void Add(double voltage)
    {
        _testedVoltage.Add(voltage);
    }

    /// <inheritdoc />
    public IEnumerator<double> GetEnumerator()
    {
        return _testedVoltage.GetEnumerator();
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Ports == null)
        {
            return new[] { "The microcontroller has no ports" };
        }

        IEnumerable<PowerPort> powerPorts = microcontroller.Ports.Where(static c => c is PowerPort).Cast<PowerPort>();

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        return _testedVoltage.Where(v => powerPorts.All(p => p.Voltage != v))
                             .Select(static v => $"The microcontroller does not support an electrical voltage of {v}V")
                             .ToList();
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}