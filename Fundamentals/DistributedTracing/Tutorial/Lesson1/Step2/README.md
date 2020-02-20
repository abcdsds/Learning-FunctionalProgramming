# Lession1 > Step2

## 목표
- 로그(Microsoft.Extensions.Logging)을 출력한다.

## 배움
- dotnet 패키지 참조 명령어
- Microsoft.Extensions.Logging 로그 출력
- C# 8.0 using 선언

1. .NET Core Console 프로젝트 만들기 & 실행하기
   ```shell
    C:\PoC\Tutorial> dotnet new console -o .\Lesson1\Step2          // Console 프로젝트 만들기
    C:\PoC\Tutorial> dotnet sln add .\Lesson1\Step2\                // Step2 프로젝트 추가하기

    // 솔루션 폴더일 때
    C:\PoC\Tutorial> dotnet add .\Lesson1\Step2\ package Microsoft.Extensions.Logging.Console
    // 프로젝트 폴더일 때
    C:\PoC\Tutorial\Lesson1\Step2> dotnet add package Microsoft.Extensions.Logging.Console

    C:\PoC\Tutorial> dotnet build                                   // 솔루션 빌드하기
    C:\PoC\Tutorial> dotnet run --project .\Lesson1\Step2\ Foo      // Step2 프로젝트 실행하기
    info: Step2.Hello[0]
      Hello, Foo!
   ```
1. .NET Core 패키지 명령어
   - 명령어
     - [dotnet add (프로젝트 경로) package 패키지이름](https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet-add-package)
     - [dotnet remove (프로젝트 경로) package 패키지이름](https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet-remove-package)
     - [dotnet list (프로젝트 경로) package 패키지이름](https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet-list-package)
     - TODO 복수개 패키지 동시에 추가하기
     - TODO 복수개 패키지 동시에 삭제하기
   - 패키지 저장 경로
     - Windows: %userprofile%\.nuget\packages
     - macOS, Linux: ~/.nuget/packages
   - 주요 옵션
     - -v 버전
     - --package-directory 경로
1. Microsoft.Extensions.Logging
   - [로그 팩토리(```ILoggerFactory```)](https://docs.microsoft.com/ko-kr/dotnet/api/microsoft.extensions.logging.iloggerfactory?view=dotnet-plat-ext-3.1)
     ```cs
     using (ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole()))
     ``` 
   - [로거(```ILogger<T>```)](https://docs.microsoft.com/ko-kr/dotnet/api/microsoft.extensions.logging.ilogger-1?view=dotnet-plat-ext-3.1)
     ```cs
      public class Hello
      {
         private readonly ILogger<Hello> _logger;

         public Hello(ILoggerFactory loggerFactory)
         {
               _logger = loggerFactory.CreateLogger<Hello>();
         }
     ```
1. C# 8.0 using 키워드     
   - C# 8.0 언어 버전을 지정한다.
     ```xml
      <PropertyGroup>
        <LagVersion>8.0</LagVersion>
      </PropertyGroup>
     ```
   - using 문(statement) -> using 선언(declation, C# 8.0)
     ```cs
     using var file = new System.IO.StreamWriter("WriteLines2.txt");
     // vs.
     using (var file = new System.IO.StreamWriter("WriteLines2.txt")) { ... }
     ```