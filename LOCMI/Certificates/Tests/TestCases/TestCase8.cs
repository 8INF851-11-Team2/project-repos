namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;
using LOCMI.Core.Utils;

public class TestCase8 : TestCase
{
    private readonly Identification _identification;

    public TestCase8(Identification identification)
        : base("Validation of general information")
    {
        _identification = identification;
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Identification == null)
        {
            yield return $"The microcontroller hasn't brand and model. It must be a {_identification.Model} made by {_identification.Brand}";
        }
        else
        {
            Identification identification = microcontroller.Identification.Value;

            if (identification.Brand == _identification.Brand)
            {
                yield return $"The microcontroller must be made by {_identification.Brand}";
            }

            if (identification.Model == _identification.Model)
            {
                yield return $"The microcontroller must be a {_identification.Model}";
            }
        }
    }
}