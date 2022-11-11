namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;
using LOCMI.Core.Utils;

public class TestCase4 : TestCase
{
    public TestCase4()
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
                yield return $"The microcontroller hasn't connectors but it must have these connectors: {mandatoryConnectors}";
            }
        }
        else
        {
            IEnumerable<Connector> missingConnector = MandatoryConnectors.Where(connector => !microcontroller.Connectors.Contains(connector));

            foreach (Connector connector in missingConnector)
            {
                yield return $"The microcontroller must have the {connector.Name} connector";
            }
        }
    }
}