namespace LOCMI_Tests;

using LOCMI.Certificates;
using LOCMI.Core.Microcontrollers;

[TestClass]
public class CertificateTests
{
    [TestMethod]
    public void CertificateAWithMicrocontrollerA()
    {
        /*var microcontrollerA = new Microcontroller();

        microcontrollerA.Connectors = new List<Connector>
        {
            new ("HDMI"),
            new ("USB"),
            new ("Wifi"),
        };

        microcontrollerA.Dimension = new Dimension(4.52, 2.09, 0.8, 100);
        microcontrollerA.Disk = new Disk("SD Card");
        microcontrollerA.Identification = new Identification("Raspberry PI", "RP4000");

        microcontrollerA.Languages = new List<Language>
        {
            new ("python", "3.11.0"),
        };

        microcontrollerA.Name = "MicrocontrollerA";

        microcontrollerA.Ports = new Ports
        {
            { 1, new PowerPort(3.3) },
            { 2, new DataPort() },
            { 3, new DataPort() },
            { 4, new DataPort() },
            { 5, new DataPort() },
            { 6, new DataPort() },
            { 7, new OtherPort() },
            { 8, new GroundPort() },
            { 9, new GroundPort() },
            { 10, new OtherPort() },
            { 11, new OtherPort() },
            { 12, new DataPort() },
            { 13, new DataPort() },
            { 14, new OtherPort() },
            { 15, new OtherPort() },
            { 16, new OtherPort() },
        };*/

        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        var certificateA = new CertificateA(microcontrollerA);
        certificateA.Certify();
        Assert.IsFalse(certificateA.IsSuccess);
    }

    [TestMethod]
    public void CertificateAWithMicrocontrollerB()
    {
        /*var microcontrollerB = new Microcontroller
        {
            Connectors = new List<Connector>
            {
                new ("HDMI"),
                new ("USB"),
                new ("Wifi"),
                new ("Bluetooth"),
            },
            Dimension = new Dimension(182, 6, 2.9, 0.77),
            Disk = new Disk(),
            Identification = new Identification("Raspberry PI", "RP2000"),
            Languages = new List<Language>
            {
                new ("C++", "17"),
            },
            OS = new OS(),
            Name = "MicrocontrollerB",
            IsMaintainable = true,
            Ports = new Ports
            {
                { 1, new DataPort() },
                { 2, new DataPort() },
                { 3, new DataPort() },
                { 4, new DataPort() },
                { 5, new DataPort() },
                { 6, new DataPort() },
                { 7, new DataPort() },
                { 8, new DataPort() },
                { 9, new PowerPort(3.3) },
                { 10, new PowerPort(5) },
                { 11, new DataPort() },
                { 12, new DataPort() },
                { 13, new OtherPort() },
                { 14, new OtherPort() },
                { 15, new OtherPort() },
                { 16, new OtherPort() },
                { 17, new OtherPort() },
                { 18, new OtherPort() },
                { 19, new GroundPort() },
                { 20, new GroundPort() },
            },
        };*/

        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        var certificateA = new CertificateA(microcontrollerB);
        certificateA.Certify();
        Assert.IsFalse(certificateA.IsSuccess);
    }

    [TestMethod]
    public void CertificateAWithMicrocontrollerC()
    {
        /*
        var microcontrollerC = new Microcontroller
        {
            Connectors = new[] { new Connector("MicroUSB") },
            Dimension = new Dimension(1.72, 3.8, 0.68, 82),
            IsMaintainable = true,
            Name = "MicrocontrollerC",
            Disk = new Disk(),
            Identification = new Identification("Arduino", "AR1240"),
            Languages = new List<Language>
            {
                new ("C++", string.Empty),
            },
            Ports = new Ports
            {
                { 1, new PowerPort(3.3) },
                { 2, new GroundPort() },
                { 3, new DataPort() },
                { 4, new DataPort() },
                { 5, new DataPort() },
                { 6, new DataPort() },
                { 7, new OtherPort() },
                { 8, new GroundPort() },
                { 9, new DataPort() },
                { 10, new DataPort() },
                { 11, new DataPort() },
                { 12, new OtherPort() },
            },
        };
        */

        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        var certificateA = new CertificateA(microcontrollerC);
        certificateA.Certify();
        Assert.IsFalse(certificateA.IsSuccess);
    }

    [TestMethod]
    public void CertificateBWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        var certificateB = new CertificateB(microcontrollerA);
        certificateB.Certify();
        Assert.IsFalse(certificateB.IsSuccess);
    }

    [TestMethod]
    public void CertificateBWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        var certificateB = new CertificateB(microcontrollerB);
        certificateB.Certify();
        Assert.IsTrue(certificateB.IsSuccess);
    }

    [TestMethod]
    public void CertificateBWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        var certificateB = new CertificateB(microcontrollerC);
        certificateB.Certify();
        Assert.IsFalse(certificateB.IsSuccess);
    }

    [TestMethod]
    public void CertificateCWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        var certificateC = new CertificateC(microcontrollerA);
        certificateC.Certify();
        Assert.IsFalse(certificateC.IsSuccess);
    }

    [TestMethod]
    public void CertificateCWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        var certificateC = new CertificateC(microcontrollerB);
        certificateC.Certify();
        Assert.IsFalse(certificateC.IsSuccess);
    }

    [TestMethod]
    public void CertificateCWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        var certificateC = new CertificateC(microcontrollerC);
        certificateC.Certify();
        Assert.IsFalse(certificateC.IsSuccess);
    }
}