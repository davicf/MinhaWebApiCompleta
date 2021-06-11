using Elmah.Io.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Elmah.Io.Extensions.Logging;
using System;

namespace DevIO.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfiguration(this IServiceCollection services)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "a075657d3f064e3a86c52294aaed2e58";
                o.LogId = new Guid("debf17dc-dc3d-42c1-a0a3-bf6fc461c05d");
            });

            //services.AddLogging(builder =>
            //{
            //    builder.Services.AddElmahIo(o =>
            //    {
            //        o.ApiKey = "a075657d3f064e3a86c52294aaed2e58";
            //        o.LogId = new Guid("debf17dc-dc3d-42c1-a0a3-bf6fc461c05d");
            //    });
            //    builder.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Warning);
            //});

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}
