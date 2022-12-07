namespace LOCMI.Certificates;

using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

public sealed class CertificateC : Certificate
{
    /// <inheritdoc />
    public CertificateC(Microcontroller microcontroller)
        : base("CertificateC", microcontroller)
    {
        var suite = new TestSuite();

        suite.Add(new ElectronicVersatilityTest());

        suite.Add(new GPIOTest
        {
            MaxDataPort = 7,
            MinDataPort = 6,
            MaxGround = 2,
            MinGround = 2,
            MaxOtherPort = 2,
            MinOtherPort = 2,
            MaxPowerPort = 2,
            MinPowerPort = 1,
        });

        suite.Add(new ProgrammingLanguageTest(new Language("C++", string.Empty)));
        suite.Add(new HasHardDiskTest());
        suite.Add(new IsMaintainableTest());

        Test = suite;
    }
}