namespace LOCMI.Certificates;

using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

public sealed class CertificateA : Certificate
{
    /// <inheritdoc />
    public CertificateA(Microcontroller microcontroller)
        : base("CertificateA", microcontroller)
    {
        var suite = new TestSuite();

        suite.Add(new ElectronicVersatilityTest(3.3));

        suite.Add(new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(5, 2.10, 0.9, 100),
            MinDimension = new Dimension(4.5, 2.05, 0.5, 90),
        });

        suite.Add(new GPIOTest
        {
            MaxDataPort = 7,
            MinDataPort = 7,
            MaxGround = 3,
            MinGround = 2,
            MaxOtherPort = 8,
            MinOtherPort = 6,
            MaxPowerPort = 1,
            MinPowerPort = 1,
        });

        suite.Add(new ConnectorSpecificationTest("HDMI", "USB", "Wifi"));

        Test = suite;
    }
}