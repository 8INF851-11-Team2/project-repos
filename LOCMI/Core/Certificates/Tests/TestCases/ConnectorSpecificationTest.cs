namespace LOCMI.Core.Certificates.Tests.TestCases;

using System.Collections;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

/// <summary>
///     Test if the microcontroller has the asked connectors
/// </summary>
/// <remarks>Test 4</remarks>
public sealed class ConnectorSpecificationTest : TestCase, IEnumerable<Connector>
{
    private readonly List<Connector> _mandatoryConnectors = new ();

    public ConnectorSpecificationTest()
        : base("Connector Specification Validation")
    {
    }

    public void Add(string connector)
    {
        _mandatoryConnectors.Add(new Connector(connector));
    }

    /// <inheritdoc />
    public IEnumerator<Connector> GetEnumerator()
    {
        return _mandatoryConnectors.GetEnumerator();
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Connectors == null)
        {
            if (_mandatoryConnectors.Any())
            {
                string mandatoryConnectors = string.Join(" / ", _mandatoryConnectors.Select(static c => c.Name));
                yield return $"The microcontroller hasn't connector but it must have these connectors: {mandatoryConnectors}";
            }
        }
        else
        {
            IEnumerable<Connector> missingConnectors = _mandatoryConnectors.Where(connector => !microcontroller.Connectors.Contains(connector));

            foreach (Connector connector in missingConnectors)
            {
                yield return $"The microcontroller must have the {connector.Name} connector";
            }
        }
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}