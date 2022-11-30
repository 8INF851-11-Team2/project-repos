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
        var suite = new TestSuite();

        suite.Add(new ProgrammingLanguageTest { new ("C++", "17") });
        suite.Add(new OperatingSystemTest(new OS()));
        suite.Add(new HasHardDiskTest());
        suite.Add(new GeneralInformationTest(new Identification("Raspberry PI", "RP2000")));
        suite.Add(new IsMaintainableTest());

        Test = suite;
    }
}