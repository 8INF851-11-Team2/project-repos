namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

/// <summary>
///     Test if the microcontroller is the right model and made by the right brand
/// </summary>
/// <remarks>Test 8</remarks>
public sealed class GeneralInformationTest : TestCase
{
    public GeneralInformationTest(Identification identification)
        : base("Validation of general information")
    {
        Identification = identification;
    }

    public Identification Identification { get; }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Identification == null)
        {
            yield return $"The microcontroller hasn't brand and model. It must be a {Identification.Model} made by {Identification.Brand}";
        }
        else
        {
            Identification identification = microcontroller.Identification.Value;

            if (identification.Brand != Identification.Brand)
            {
                yield return $"The microcontroller must be made by {Identification.Brand}";
            }

            if (identification.Model != Identification.Model)
            {
                yield return $"The microcontroller must be a {Identification.Model}";
            }
        }
    }
}