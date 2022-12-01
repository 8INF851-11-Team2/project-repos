namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

/// <summary>
///     Test if the microcontroller has an OS and if the OS is correct
/// </summary>
/// <remarks>Test 6</remarks>
public sealed class OperatingSystemTest : TestCase
{
    public OperatingSystemTest(OS mandatoryOS)
        : base("Operating system test")
    {
        MandatoryOS = mandatoryOS;
    }

    public OS MandatoryOS { get; }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.OS == null)
        {
            yield return string.IsNullOrEmpty(MandatoryOS.Name)
                             ? "The microcontroller hasn't OS but it must have one"
                             : $"The microcontroller hasn't OS but it must have the {MandatoryOS.Name} OS";
        }
        else
        {
            if (!string.IsNullOrEmpty(MandatoryOS.Name) && string.IsNullOrEmpty(microcontroller.Name))
            {
                yield return $"The microcontroller has an unknown OS but it must have the {MandatoryOS.Name} OS";
            }
        }
    }
}