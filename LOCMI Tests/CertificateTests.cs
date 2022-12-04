namespace LOCMI_Tests;

using LOCMI.Certificates;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;

[TestClass]
public class CertificateTests
{
    [TestMethod]
    public void CertificateAWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        var certificateA = new CertificateA(microcontrollerA);
        certificateA.Certify();
        Assert.IsFalse(certificateA.IsSuccess);
    }

    [TestMethod]
    public void CertificateAWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        var certificateA = new CertificateA(microcontrollerB);
        certificateA.Certify();
        Assert.IsFalse(certificateA.IsSuccess);
    }

    [TestMethod]
    public void CertificateAWithMicrocontrollerC()
    {
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