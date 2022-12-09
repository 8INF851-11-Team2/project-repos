namespace LOCMI_Tests;

using LOCMI.Certificates;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;
using LOCMI.Models.Menu;

[TestClass]
public class CertificatePrinterTests
{
    public void PrintCertificate(Certificate certificate)
    {
        

        CertificateDemonstrationDTO dto = new CertificateDemonstrationDTO();
        List<Certificate> certificates = new List<Certificate>();
        certificates.Add(certificate);
        dto.Certificates = certificates;
        PrintCommand p = new PrintCommand(dto);
        p.Execute();
    }

    [TestMethod]
    public void CertificateCreationAndPathTest()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        var certificateB = new CertificateB(microcontrollerB);
        certificateB.Certify();

        PrintCertificate(certificateB);

        DateTime date = DateTime.Now;
        string file = "./" + date.Year + "/" + date.Month + "/" + date.Day + "/" + certificateB.Name + "_" + microcontrollerB.Name + "_" + "CERTIFICATE_" + date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second + ".txt";
        Assert.IsTrue(File.Exists(file));
        if (Directory.Exists(date.Year.ToString()))
        {
            Directory.Delete(date.Year.ToString(), true);
        }
    }

    [TestMethod]
    public void CertificateNonCreationWhenNotCertifiedTest()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        var certificateB = new CertificateB(microcontrollerA);
        certificateB.Certify();

        printCertificate(certificateB);

        DateTime date = DateTime.Now;
        string file = "./" + date.Year + "/" + date.Month + "/" + date.Day + "/" + certificateB.Name + "_" + microcontrollerA.Name + "_" + "CERTIFICATE_" + date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second + ".txt";
        Assert.IsFalse(File.Exists(file));
    }

    [TestMethod]
    public void ContentCertificationFileTest()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        var certificateB = new CertificateB(microcontrollerB);
        certificateB.Certify();

        printCertificate(certificateB);

        DateTime date = DateTime.Now;
        string file = "./" + date.Year + "/" + date.Month + "/" + date.Day + "/" + certificateB.Name + "_" + microcontrollerB.Name + "_" + "CERTIFICATE_" + date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second + ".txt";
        if(File.Exists(file))
        {
            string text = File.ReadAllText(file);

            Assert.IsTrue(text.Equals("Certificate : CertificateB\n" +
                "Date : " + date + "\n" +
                "Is success : True\n" +
                "Tests : [Languages, Operating system test, Has hard disk, Validation of general information, Maintenance testing]\n" +
                "Microcontroller: [\n" +
                "    Name: MicrocontrollerB\n" +
                "    Connectors: [" + microcontrollerB.Connectors + "]\n" +
                "    Dimension: [\n" +
                "        Height: " + microcontrollerB.Dimension.Value.Height + "\n" +
                "        Length: " + microcontrollerB.Dimension.Value.Length + "\n" +
                "        Width: " + microcontrollerB.Dimension.Value.Width + "\n" +
                "        Weight: " + microcontrollerB.Dimension.Value.Weight + "\n" +
                "    ]\n" +
                "    Has integrated hard disk: True" +
                "    Identification:[\n" +
                "        Brand: " + microcontrollerB.Identification.Value.Brand + "\n" +
                "        Model: " + microcontrollerB.Identification.Value.Model + "\n" +
                "    ]\n" +
                "    Is maintainable: " + microcontrollerB.IsMaintainable + "\n" +
                "    Languages: [C++ (version: 17)]\n" +
                "    OS: \n" +
                "    Ports: [\n" +
                "        1: data\n" +
                "        2: data\n" +
                "        3: data\n" +
                "        4: data\n" +
                "        5: data\n" +
                "        6: data\n" +
                "        7: data\n" +
                "        8: data\n" +
                "        9: power (3,3V)\n" +
                "        10: power (5V)\n" +
                "        11: data\n" +
                "        12: data\n" +
                "        13: other\n" +
                "        14: other\n" +
                "        15: other\n" +
                "        16: other\n" +
                "        17: other\n" +
                "        18: other\n" +
                "        19: ground\n" +
                "        20: ground\n" +
                "]"));
        }
    }
}