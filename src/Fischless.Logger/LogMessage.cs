namespace Fischless.Logger;

public sealed class LogMessage(string message)
{
    public string Message { get; set; } = message;

    public override string ToString() => Message;
}
