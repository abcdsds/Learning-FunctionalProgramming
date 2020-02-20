using System;
using Microsoft.Extensions.Logging;     // ILoggerFactory
using OpenTracing;                      // ITracer, ISpan
//using OpenTracing.Util;
using System.Collections.Generic;


namespace Step3
{
    public class Hello
    {
        private readonly ITracer _tracer;
        private readonly ILogger<Hello> _logger;

        public Hello(ITracer tracer, ILoggerFactory loggerFactory)
        {
            _tracer = tracer;
            _logger = loggerFactory.CreateLogger<Hello>();
        }

        public void SayHello(string helloTo)
        {
            ISpan span = _tracer.BuildSpan("say-hello").Start();

            var msg = HelloFor(helloTo);
            _logger.LogInformation(msg);

            // Span - Tag
            span.SetTag("hello-to", helloTo);

            // Span - Log 사용자 정의
            span.Log(new Dictionary<string, object>
                {
                    [LogFields.Event] = "string.Format",
                    ["value"] = msg
                }
            );

            // Span - Log
            span.Log("WriteLine");

            span.Finish();
        }

        private string HelloFor(string helloTo)
        {
            return $"Hello, {helloTo}!";
        }
    }
}