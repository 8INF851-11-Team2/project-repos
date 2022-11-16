namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

/// <summary>
///     Test if the microcontroller has the asked connectors
/// </summary>
/// <remarks>Test 4</remarks>
public sealed class ConnectorSpecificationTest : TestCase
{
    public ConnectorSpecificationTest()
        : base("Connector Specification Validation")
    {
    }

    public IEnumerable<Connector> MandatoryConnectors { get; init; } = new List<Connector>();

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Connectors == null)
        {
            if (MandatoryConnectors.Any())
            {
                string mandatoryConnectors = string.Join(" / ", MandatoryConnectors.Select(static c => c.Name));
                yield return $"The microcontroller hasn't connector but it must have these connectors: {mandatoryConnectors}";
            }
        }
        else
        {
            IEnumerable<Connector> missingConnectors = MandatoryConnectors.Where(connector => !microcontroller.Connectors.Contains(connector));

            foreach (Connector connector in missingConnectors)
            {
                yield return $"The microcontroller must have the {connector.Name} connector";
            }
        }
    }
}