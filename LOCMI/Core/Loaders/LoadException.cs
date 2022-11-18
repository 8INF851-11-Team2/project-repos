namespace LOCMI.Core.Loaders;

public sealed class LoadException : Exception
{
    public LoadException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}