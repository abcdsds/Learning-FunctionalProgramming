using System;
using Microsoft.Extensions.Logging;

namespace Step2
{
    public class Hello
    {
        private readonly ILogger<Hello> _logger;

        public Hello(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Hello>();
        }

        public void SayHello(string helloTo)
        {
            var msg = HelloFor(helloTo);
            _logger.LogInformation(msg);
        }

        private string HelloFor(string helloTo)
        {
            return $"Hello, {helloTo}!";
        }
    }
}