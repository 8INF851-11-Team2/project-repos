namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;

/// <summary>
///     Check if the microcontroller has an integrated hard disk
/// </summary>
/// <remarks>Test 7</remarks>
public sealed class HasIntegratedHardDiskTest : TestCase
{
    public HasIntegratedHardDiskTest()
        : base("Has hard disk")
    {
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        return microcontroller.HasIntegratedHardDisk
                   ? Array.Empty<string>()
                   : new[] { "The microcontroller hasn't integrated hard disk" };
    }
}