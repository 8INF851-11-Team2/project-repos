namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;

/// <summary>
///     Check if the microcontroller has a hard disk
/// </summary>
/// <remarks>Test 7</remarks>
public sealed class HasHardDiskTest : TestCase
{
    public HasHardDiskTest()
        : base("Has hard disk")
    {
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        return microcontroller.Disk != null
                   ? Array.Empty<string>()
                   : new[] { "The microcontroller hasn't hard disk" };
    }
}