namespace LOCMI.Certificates;

using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

public sealed class CertificateB : Certificate
{
    /// <inheritdoc />
    public CertificateB(Microcontroller microcontroller)
        : base("CertificateB", microcontroller)
    {
        Test = new TestSuite
        {
            new ProgrammingLanguageTest { MandatoryLanguages = new Language[] { new ("C++", "17") } },
            new OperatingSystemTest(new OS()),
            new HasHardDiskTest(),
            new GeneralInformationTest(new Identification("Raspberry PI", "RP2000")),
            new IsMaintainableTest(),
        };
    }
}