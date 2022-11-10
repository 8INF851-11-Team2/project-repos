namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;

public class TestCase7 : TestCase
{
    public TestCase7()
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