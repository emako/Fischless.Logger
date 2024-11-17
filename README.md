[![NuGet](https://img.shields.io/nuget/v/Fischless.Logger.svg)](https://nuget.org/packages/Fischless.Logger) [![GitHub license](https://img.shields.io/github/license/emako/Fischless.Logger)](https://github.com/emako/Fischless.Logger/blob/master/LICENSE) [![Actions](https://github.com/emako/Fischless.Logger/actions/workflows/library.nuget.yml/badge.svg)](https://github.com/emako/Fischless.Logger/actions/workflows/library.nuget.yml)

# Fischless.Logger

A simple logger library used for [Fischless](https://github.com/GenshinMatrix/Fischless).

## Usage

```c#
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
```

