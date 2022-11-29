namespace LOCMI.Core.Loaders;

using System.Text.Json;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using Newtonsoft.Json.Linq;

public sealed class JsonLoader<T> : ILoader<T> where T : class
{
    /// <inheritdoc />
    public T? Load(string path)
    {
        try
        {
            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(json);
        }
        catch (Exception ex)
        {
            throw new LoadException("Unable to load this object", ex);
        }
    }

    public Certificate LoadCertificate(string path, Microcontroller microcontroller)
    {
        string json = File.ReadAllText(path);

        JObject jObject = JObject.Parse(json);

        string name = jObject.SelectToken("Name").Value<string>();

        TestSuite testSuite = new TestSuite();

        IEnumerable<JToken> list = jObject.SelectToken("Tests").Values();

        foreach (JToken token in list)
        {
            if ((token.SelectToken("Present").Value<bool>()))
            {
                JTokenReader reader = new JTokenReader(token);
                string tokenPath = reader.Path;
                string tokenName = tokenPath.Substring(tokenPath.LastIndexOf('.') + 1);
                JToken param = token.SelectToken("Param");
                testSuite.Add(GetTest(tokenName, param));
            }
        }

        Certificate certificate = new Certificate(testSuite, microcontroller, name);

        return certificate;
    }


    private ITest GetTest(string name, JToken param)
    {
        ITest test;

        switch (name)
        {
            case "ConnectorSpecificationTest":
                IEnumerable<string> listName = param.Values<string>();
                test = new ConnectorSpecificationTest();

                foreach (string nameConnector in listName)
                {
                    ((ConnectorSpecificationTest) test).Add(nameConnector);
                }
                break;
            case "ElectronicVersatilityTest":
                IEnumerable<double> listDouble = param.Values<double>();
                test = new ElectronicVersatilityTest();

                foreach (double value in listDouble)
                {
                    ((ElectronicVersatilityTest) test).Add(value);
                }
                break;
            case "FirmwareTest":
                test = new FirmwareTest();
                break;
            case "GeneralInformationTest":
                string brand = param.SelectToken("brand").Value<string>();
                string model = param.SelectToken("model").Value<string>(); ;

                Identification identification = new Identification(brand, model);
                test = new GeneralInformationTest(identification);
                break;
            case "GPIOTest":
                int maxDataPort = param.SelectToken("maxDataPort").Value<int>();
                int minDataPort = param.SelectToken("minDataPort").Value<int>(); 
                int maxGround = param.SelectToken("maxGround").Value<int>();
                int minGround = param.SelectToken("minGround").Value<int>();
                int maxOtherPort = param.SelectToken("maxOtherPort").Value<int>();
                int minOtherPort = param.SelectToken("minOtherPort").Value<int>();
                int maxPowerPort = param.SelectToken("maxPowerPort").Value<int>();
                int minPowerPort = param.SelectToken("minPowerPort").Value<int>();

                test = new GPIOTest
                {
                    MaxDataPort = maxDataPort,
                    MinDataPort = minDataPort,
                    MaxGround = maxGround,
                    MinGround = minGround,
                    MaxOtherPort = maxOtherPort,
                    MinOtherPort = minOtherPort,
                    MaxPowerPort = maxPowerPort,
                    MinPowerPort = minPowerPort,
                };
                break;
            case "HasHardDiskTest":
                test = new HasHardDiskTest();
                break;
            case "IsMaintainableTest":
                test = new IsMaintainableTest();
                break;
            case "OperatingSystemTest":
                string osName = param.SelectToken("name").Value<string>();
                OS os = new OS(osName);
                test = new OperatingSystemTest(os);
                break;
            case "PhysicalSpecificationTest":
                List<double> listMax = param.SelectToken("maxDimension").Values<double>().ToList();
                List<double> listMin = param.SelectToken("minDimension").Values<double>().ToList();

                Dimension maxDimension = new Dimension(listMax[0], listMax[1], listMax[2], listMax[3]);
                Dimension minDimension = new Dimension(listMin[0], listMin[1], listMin[2], listMin[3]);

                test = new PhysicalSpecificationTest()
                {
                    MaxDimension = maxDimension,
                    MinDimension = minDimension,
                };
                break;
            case "ProgrammingLanguageTest":
                test = new ProgrammingLanguageTest();
                foreach (JToken token in param) {
                    List<string> l = token.Values<string>().ToList();
                    Language language = new Language(l[0], l[1]);
                    ((ProgrammingLanguageTest) test).Add(language);
                }

                break;
            default:
                throw new LoadException("Unable to load this object", null);
        }


        return test;
    }
}