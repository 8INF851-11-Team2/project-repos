namespace LOCMI.Core.Certificates.Printers;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

public sealed class PrinterTxt : IPrinter
{
    /// <inheritdoc />
    public async Task Print(Certificate certificate, string path)
    {
        if (!certificate.IsSuccess)
        {
            return;
        }

        await using StreamWriter file = new (path, true);

        await file.WriteLineAsync($"""
                Certificate : {certificate.Name}
                Date : {DateTime.Now}
                Is success : {certificate.IsSuccess}
                Tests : {certificate.Test}
                """);

        if (certificate.Microcontroller == null)
        {
            await file.WriteLineAsync("Microcontroller: null");
        }
        else
        {
            await file.WriteAsync(MicrocontrollerToString(certificate.Microcontroller));
        }
    }

    private static string MicrocontrollerToString(Microcontroller microcontroller)
    {
        var specifications = string.Empty;

        if (microcontroller.Connectors != null)
        {
            specifications += $"Connectors: [{string.Join(", ", microcontroller.Connectors.Select(static c => c.Name))}]";
        }

        if (microcontroller.Dimension != null)
        {
            specifications += $"""
                    {"\n"}    Dimension: [
                            Height: {microcontroller.Dimension.Value.Height}
                            Length: {microcontroller.Dimension.Value.Length}
                            Width: {microcontroller.Dimension.Value.Width}
                            Weight: {microcontroller.Dimension.Value.Weight}
                        ]
                    """;
        }

        if (microcontroller.ExternalHardDisk != null)
        {
            specifications += $"\n    External hard disk: {microcontroller.ExternalHardDisk.Value.Name}";
        }

        specifications += $"\n    Has integrated hard disk: {microcontroller.HasIntegratedHardDisk}";

        if (microcontroller.Identification != null)
        {
            specifications += $"""
                    {"\n"}    Identification: [
                            Brand: {microcontroller.Identification.Value.Brand}
                            Model: {microcontroller.Identification.Value.Model}
                        ]
                    """;
        }

        specifications += $"\n    Is maintainable: {microcontroller.IsMaintainable}";

        if (microcontroller.Languages != null)
        {
            specifications += $"\n    Languages: [{string.Join(", ", microcontroller.Languages.Select(static c => $"{c.Name} (version: {c.Version})"))}]";
        }

        if (microcontroller.OS != null)
        {
            specifications += $"\n    OS: {microcontroller.OS.Value.Name}";
        }

        if (microcontroller.Ports != null)
        {
            specifications += "\n    Ports: [";

            for (var i = 1; i <= microcontroller.Ports.Count; i++)
            {
                Port? port = microcontroller.Ports[i];

                if (port != null)
                {
                    specifications += "\n        " + i + ": " + port switch
                    {
                        DataPort => "data",
                        PowerPort powerPort => $"power ({powerPort.Voltage}V)",
                        GroundPort => "ground",
                        _ => "other",
                    };
                }
            }
        }

        return $"""
                Microcontroller: [
                    Name: {microcontroller.Name}
                    {specifications}
                ]
                """;
    }
}