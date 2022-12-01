namespace LOCMI.Core.Microcontrollers.Utils.PortTypes;

using System.Text.Json.Serialization;

[JsonDerivedType(typeof(DataPort), "data")]
[JsonDerivedType(typeof(GroundPort), "ground")]
[JsonDerivedType(typeof(PowerPort), "power")]
[JsonDerivedType(typeof(OtherPort), "other")]
public abstract class Port
{
}