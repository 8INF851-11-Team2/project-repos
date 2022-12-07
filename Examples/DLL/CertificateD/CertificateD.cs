namespace CertificateD;

using JetBrains.Annotations;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers.Utils;

[UsedImplicitly]
public class CertificateD : Certificate
{
    /// <inheritdoc />
    public CertificateD()
        : base("CertificateD")
    {
        var suite = new TestSuite();
        suite.Add(new ElectronicVersatilityTest());
        suite.Add(new HasHardDiskTest());

        suite.Add(new GPIOTest
        {
            MaxOtherPort = 5,
            MinOtherPort = 5,
            MaxPowerPort = 2,
            MinPowerPort = 2,
            MaxDataPort = 8,
            MinDataPort = 8,
            MaxGround = 1,
            MinGround = 1,
        });

        suite.Add(new ConnectorSpecificationTest("HDMI", "USB-C", "RJ45"));
        suite.Add(new GeneralInformationTest(new Identification("LOCMI", "MC-00743-T")));
        suite.Add(new IsMaintainableTest());
        suite.Add(new OperatingSystemTest(new OS("Raspberry")));

        suite.Add(new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(10.5, 5.5, 0.75, 20),
            MinDimension = new Dimension(10.5, 5.5, 0.75, 20),
        });

        suite.Add(new ProgrammingLanguageTest(new Language("java", "17"), new Language("python", "13")));

        Test = suite;
    }
}