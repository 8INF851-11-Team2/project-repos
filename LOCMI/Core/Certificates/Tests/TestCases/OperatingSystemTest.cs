namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

/// <summary>
///     Test if the microcontroller has an OS and if the OS is correct
/// </summary>
/// <remarks>Test 6</remarks>
public class OperatingSystemTest : TestCase
{
    private readonly OS _mandatoryOS;

    public OperatingSystemTest(OS mandatoryOS)
        : base("Operating system test")
    {
        _mandatoryOS = mandatoryOS;
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.OS == null)
        {
            yield return string.IsNullOrEmpty(_mandatoryOS.Name)
                             ? "The microcontroller hasn't OS but it must have one"
                             : $"The microcontroller hasn't OS but it must have the {_mandatoryOS.Name} OS";
        }
        else
        {
            if (!string.IsNullOrEmpty(_mandatoryOS.Name) && string.IsNullOrEmpty(microcontroller.Name))
            {
                yield return $"The microcontroller has an unknown OS but it must have the {_mandatoryOS.Name} OS";
            }
        }
    }
}