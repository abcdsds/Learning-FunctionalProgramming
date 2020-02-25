// 클라이언트
dotnet sln add .\Lesson5\Step1\ClientConsole\
dotnet add .\Lesson5\Step1\ClientConsole\ reference .\LessonLib\

dotnet add .\Lesson5\Step1\ClientConsole\ package Microsoft.Extensions.Logging.Console
dotnet add .\Lesson5\Step1\ClientConsole\ package Jaeger
dotnet add .\Lesson5\Step1\ClientConsole\ package OpenTracing

<LagVersion>8.0</LagVersion>

// 서버

dotnet new webapi -o .\Lesson5\Step1\ServerWebapi
dotnet sln add -o .\Lesson5\Step1\ServerWebapi  
dotnet sln add .\Lesson5\Step1\ServerWebapi
dotnet add .\Lesson5\Step1\ServerWebapi reference .\LessonLib\

dotnet add .\Lesson5\Step1\ServerWebapi package Microsoft.Extensions.Logging.Console
dotnet add .\Lesson5\Step1\ServerWebapi package Jaeger
dotnet add .\Lesson5\Step1\ServerWebapi package OpenTracing.Contrib.NetCore

<LagVersion>8.0</LagVersion>