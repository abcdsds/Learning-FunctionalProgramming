using Microsoft.AspNetCore.Mvc;
using OpenTracing;
using System.Collections.Generic;

namespace ServerWebapi.Controllers
{
    [Route("api/format")]
    public class FormatController : Controller
    {
        private readonly ITracer _tracer;

        public FormatController(ITracer tracer)
        {
            _tracer = tracer;
        }

        // GET: api/format
        [HttpGet]
        public string Get()
        {
            return "Hello!";
        }

        // GET: api/format/helloTo
        [HttpGet("{helloTo}", Name = "GetFormat")]
        public string Get(string helloTo)
        {
            using (var scope = _tracer.BuildSpan("format-controller").StartActive(true))
            {
                //
                // GetBaggageItem
                //
                //var greeting = scope.Span.GetBaggageItem("greeting") ?? "Hello";

                var greeting = "Greeting";
                var formattedHelloString = $"Hello, {helloTo}, {greeting}!";
                // scope.Span.Log(new Dictionary<string, object>
                // {
                //     [LogFields.Event] = "string-format",
                //     ["value"] = formattedHelloString
                // });
                return formattedHelloString;
            }
        }
    }
}