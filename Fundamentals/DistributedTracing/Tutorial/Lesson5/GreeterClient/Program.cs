// Copyright 2015 gRPC authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Helloworld;
using Jaeger;
using LessonLib;
using Microsoft.Extensions.Logging;
using OpenTracing.Contrib.Grpc.Interceptors;

namespace GreeterClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            using ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            using Tracer tracer = Tracing.Init("client", loggerFactory);
            // using OpenTracing.Contrib.Grpc.Interceptors;
            ServerTracingInterceptor tracingInterceptor = new ServerTracingInterceptor(tracer);

            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            // using Grpc.Core.Interceptors;
            //var client = new Greeter.GreeterClient(channel);
            var client = new Greeter.GreeterClient(channel.Intercept(tracingInterceptor));
            // if we want to use the same traced channel for multiple clients, it's better to just get one instance.
            //CallInvoker callInvoker = channel.Intercept(tracingInterceptor);
            //var client = new Greeter.GreeterClient(callInvoker);

            String user = "you";

            var reply = client.SayHello(new HelloRequest { Name = user });
            Console.WriteLine("Greeting: " + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
