namespace LOCMI.Core.Certificates.Tests;

using System.Text.Json.Serialization;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;

[JsonDerivedType(typeof(TestSuite), "testSuite")]
[JsonDerivedType(typeof(ConnectorSpecificationTest), "connectorSpecificationTest")]
[JsonDerivedType(typeof(ElectronicVersatilityTest), "electronicVersatilityTest")]
[JsonDerivedType(typeof(FirmwareTest), "firmwareTest")]
[JsonDerivedType(typeof(GeneralInformationTest), "generalInformationTest")]
[JsonDerivedType(typeof(GPIOTest), "gpioTest")]
[JsonDerivedType(typeof(HasHardDiskTest), "hasHardDiskTest")]
[JsonDerivedType(typeof(IsMaintainableTest), "isMaintainableTest")]
[JsonDerivedType(typeof(OperatingSystemTest), "operatingSystemTest")]
[JsonDerivedType(typeof(PhysicalSpecificationTest), "physicalSpecificationTest")]
[JsonDerivedType(typeof(ProgrammingLanguageTest), "programmingLanguageTest")]
[JsonPolymorphic(UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor)]
public interface ITest
{
    public void Run(ITestResult testResult, Microcontroller mc);
}