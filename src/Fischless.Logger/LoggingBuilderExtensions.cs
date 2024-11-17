#if NETSTANDARD2_1 && false
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Fischless.Logger;

/// <summary>
/// Extends <see cref="ILoggingBuilder"/> with configuration methods.
/// </summary>
public static class LoggingBuilderExtensions
{
    public static ILoggingBuilder AddLogger(this ILoggingBuilder builder, ILogger? logger = null)
    {
        _ = builder ?? throw new ArgumentNullException(nameof(builder));
        if (logger != null)
        {
            builder.Services.AddSingleton(logger);
        }
        return builder;
    }
}
#endif
