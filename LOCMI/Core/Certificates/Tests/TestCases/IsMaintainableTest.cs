namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;

/// <summary>
///     Check is the microcontroller is maintainable.
/// </summary>
/// <remarks>Test 9</remarks>
public class IsMaintainableTest : TestCase
{
    public IsMaintainableTest()
        : base("Maintenance testing")
    {
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (!microcontroller.IsMaintainable)
        {
            yield return "The microcontroller isn't maintainable";
        }
    }
}