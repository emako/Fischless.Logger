namespace Fischless.Logger.Test;

internal class Program
{
    static void Main(string[] args)
    {
        Log.Logger = LoggerConfiguration.CreateDefault()
                .UseType(LoggerType.Async)
                .UseLevel(LogLevel.Trace)
                .WriteToFile(
                    logFolder: Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @$"Fischless.Logger.Test\log"),
                    fileName: $"Fischless_{DateTime.Now:yyyyMMdd}.log"
                )
                .CreateLogger();

        Log.Information("Hello, World!");
        Log.CloseAndFlush();

        Console.ReadLine();
    }
}
