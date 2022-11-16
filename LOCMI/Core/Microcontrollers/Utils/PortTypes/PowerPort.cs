namespace LOCMI.Core.Microcontrollers.Utils.PortTypes;

public sealed class PowerPort : Port
{
    public PowerPort(double voltage)
    {
        Voltage = voltage;
    }

    public double Voltage { get; }
}