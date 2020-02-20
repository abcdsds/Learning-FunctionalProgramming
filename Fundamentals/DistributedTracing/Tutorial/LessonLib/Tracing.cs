using System;
using Microsoft.Extensions.Logging;     // ILoggerFactory
using Jaeger;                           // Tracer
using Jaeger.Samplers;                  // ConstSampler

namespace LessonLib
{
    public static class Tracing
    {
        public static Tracer Init(string serviceName, ILoggerFactory loggerFactory)  
        {
            var samplerConfiguration = new Configuration.SamplerConfiguration(loggerFactory)
                .WithType(ConstSampler.Type)
                .WithParam(1);


            // https://www.jaegertracing.io/docs/1.16/getting-started/
            // Jaeger 서버 IP을 지정한다.
            // 6831	포트
            //  - Protocal: UDP
            //  - Component: Agent
            //  - Function: Accept "jaeger.thrift" over compact thrift protocol
            var reporterConfiguration = new Configuration.ReporterConfiguration(loggerFactory)
                .WithSender(new Configuration.SenderConfiguration(loggerFactory)

// https://blog.magnusmontin.net/2018/11/05/platform-conditional-compilation-in-net-core/
#if Windows
                    .WithAgentHost("192.168.99.201")
#elif Linux
                     .WithAgentHost("localhost")
#endif

                .WithAgentPort(6831))
                .WithLogSpans(true);

            return (Tracer)new Configuration(serviceName, loggerFactory)
                .WithSampler(samplerConfiguration)
                .WithReporter(reporterConfiguration)
                .GetTracer();
        }
    }
}
