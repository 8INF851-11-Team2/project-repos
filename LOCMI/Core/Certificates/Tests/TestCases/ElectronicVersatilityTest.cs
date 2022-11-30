namespace LOCMI.Core.Certificates.Tests.TestCases;

using System.Text.Json.Serialization;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

/// <summary>
///     Test if the microcontroller supports different voltages.
/// </summary>
/// <remarks>Test 1</remarks>
public sealed class ElectronicVersatilityTest : TestCase
{
    [JsonConstructor]
    public ElectronicVersatilityTest()
        : base("Electronic versatility")
    {
    }

    public ElectronicVersatilityTest(params double[] voltages)
        : this()
    {
        TestedVoltage = voltages.ToList();
    }

    public List<double> TestedVoltage { get; set; } = new ();

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Ports == null)
        {
            return new[] { "The microcontroller has no ports" };
        }

        IEnumerable<PowerPort> powerPorts = microcontroller.Ports.Where(static c => c is PowerPort).Cast<PowerPort>();

        // ReSharper disable once CompareOfFloatsByEqualityOperator
        return TestedVoltage.Where(v => powerPorts.All(p => p.Voltage != v))
                            .Select(static v => $"The microcontroller does not support an electrical voltage of {v}V")
                            .ToList();
    }
}