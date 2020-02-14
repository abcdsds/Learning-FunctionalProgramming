// TODO
// - [ ] 로컬 빌드, 커멘드로 코드 커버리지 확인하기
// - [ ] 로컬 빌드, VSCode에서 코드 커버리지 확인하기 
// - [ ] 로컬 빌드, 자동화
// - [ ] 서버 빌드, GitLab 빌드 자동화
// - [ ] 서버 빌드, GitLab 빌드와 코드 커버리지 통합
// - [ ] 서버 빌드, 코드 커버리지 확인하기
// - [ ] 서버 빌드, 품질 관문?

using System;
using Xunit;
using FluentAssertions;

// VSCode 도구
// - Coverage Gutters
// - .NET Core Test Explorer

// .NET Core 도구
// - dotnet tool install --global coverlet.console

// NuGet 설치
// - FluentAssertions
// - JunitXml.TestLogger

// .NET Core 명령어
//
// dotnet new classlib -n
// dotnet new xunit -n
// dotnet add 프로젝트명1 reference 프로젝트명2
//      프로젝트명1 <- 프로젝트명2
// dotnet add 프로젝트명1 package 프로젝트명2
// dotnet test
// dotnet test 프로젝트명
//  --collect
//  -r 출력경로
//  --settings 설정파일
//  --test-adapter-path
//  --logger

// coverlet 명령어
//
// coverlet .\bin\Debug\netcoreapp2.1\hanselminutes.core.tests.dll --target "dotnet" --targetargs "test --no-build"

//
// Cross-Platform Unit Testing and Code Coverage with Coverlet - Toni Solarin-Sodara
//  https://www.youtube.com/watch?v=vdAyb4W8gp4
//

// dotnet add package coverlet.msbuild
// dotnet test /p:CollectCoverage=true 
//  코드커버리지 결과 표를 출력한다(coverlet.msbuild가 사전에 설치되어 있어야 한다).
//  coverage.json 파일을 생성한다.
// dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=OpenCover
//  coverage.opencover.xml
// dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov
//  coverage.info
// dotnet test /p:CollectCoverage=true /p:Threshold=100
//  경고들이 출력된다.
//  C:\Users\HyungHo.Ko\.nuget\packages\coverlet.msbuild\2.8.0\build\coverlet.msbuild.targets(36,5): 
//      error : The minimum line coverage is below the specified 100 
//      [C:\Workspace\ ... \C01_Coverlet.Tests\C01_Coverlet.Tests.csproj]
// dotnet test /p:CollectCoverage=true /p:ThresholdType=method
// 
// Vs.
// dotnet tool install --global coverlet.console
// coverlet .dll --target "dotnet" --targetargs "test --no-build"
// coverlet .\bin\Debug\netcoreapp3.1\C01_Coverlet.Tests.dll --target "dotnet" --targetargs "test --no-build"
//  coverage.json 파일을 생성한다.
// GitHub tonerdo/DotnetConf2018Demo
// appveyor.yml 파일 생성
// CodeCoverage 제외
//      using System.Diagnostics.CodeAnalysis
//      [ExcludeFromCodeCoverage]
// dotnet-reportgenerator-globaltool
// dotnet tool install --global dotnet-reportgenerator-globaltool   
// dotnet tool list --global
//

// dotnet add package coverlet.msbuild
// dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=OpenCover
// dotnet tool install --global dotnet-reportgenerator-globaltool   
// reportgenerator "-reports:coverage.opencover.xml" "-targetdir:./report"
//  ./report/
// TODO NuGet dotnet-reportgenerator-globaltool??
// TODO GitHub


//=====================================
// Coverlet 정리
// https://github.com/tonerdo/coverlet
//=====================================
// 1. VSTest
//      https://github.com/tonerdo/coverlet/blob/master/Documentation/VSTestIntegration.md
//      dotnet add package coverlet.collector
//      dotnet test --collect:"XPlat Code Coverage"
//          ./TestResults/coverage.cobertura.xml
//      요구사항
//          .NET Core SDK v2.2.401
//          Microsoft.NET.Test.Sdk 16.5.0 
// 2. MSBuild
//      https://github.com/tonerdo/coverlet/blob/master/Documentation/MSBuildIntegration.md
//      dotnet add package coverlet.msbuild
//      dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=OpenCover
//          ./coverage.json               <- /p:CollectCoverage=true
//          ./coverage.opencover.xml      <- /p:CoverletOutputFormat=OpenCover
//      dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info
//      요구사항
//           .NET Standard 2.0
// 3. .NET Core Global Tool
//      https://github.com/tonerdo/coverlet/blob/master/Documentation/GlobalTool.md
//      dotnet tool install --global coverlet.console
//      coverlet /path/to/test-assembly.dll --target "dotnet" --targetargs "test /path/to/test-project --no-build"
//              ex. coverlet .\bin\Debug\netcoreapp3.1\C01_Coverlet.Tests.dll --target "dotnet" --targetargs "test . --no-build"
//          ./coverage.json               <- /p:CollectCoverage=true
//      요구사항
//          .NET Core 2.2

// Coverage Gutters
// https://xpirit.com/netcore-withvscode-should-haveunit-tests/
// lcov.info
// coverage-gutters.showGutterCoverage
// coverage-gutters.showLineCoverage
// Ctrl+Shift+8/9

// DONE Blog - https://www.youtube.com/watch?v=vdAyb4W8gp4
// TODO Blog - https://gunnarpeipman.com/aspnet-core-code-coverage/
// TODO Blog - https://www.dotnetcurry.com/visualstudio/1451/dotnet-core-development-vs-code
// TODO Blog - https://xpirit.com/netcore-withvscode-should-haveunit-tests/
// TODO Blog - https://dev.to/deinsoftware/net-core-unit-test-and-code-coverage-with-visual-studio-code-37bp
// TODO Blog - https://www.hanselman.com/blog/AutomaticUnitTestingInNETCorePlusCodeCoverageInVisualStudioCode.aspx
// TODO Blog - https://www.codeproject.com/Articles/1266146/Code-Coverage-is-Finally-Easy-in-NET-Core
// TODO Blog - https://tattoocoder.com/cross-platform-code-coverage-arrives-for-net-core/
// TODO Blog - https://channel9.msdn.com/Shows/On-NET/Reducing-Bugs-In-Your-Code-with-Coverlet
// TODO Blog - https://dotnetsharing.wordpress.com/2019/03/12/code-coverage-in-net-core-apps/
// TODO Blog - https://geeks.ms/jlguerrero/en/2019/01/13/code-analysis-and-code-coverage-using-netcore-vs-code-publishing-to-sonarqube-sonarcloud-io/
// TODO Blog - https://www.meziantou.net/computing-code-coverage-for-a-dotnet-core-project-with-azure-devops-and-coverlet.htm
// TODO Coverlet - 코드에서 제외 시킨다.
// TODO Coverlet - 명령어에서 제외 시킨다.
// TODO Coverlet - 출력 경로를 변경한다.
// TODO Coverlet - 명령어를 정리한다.
// TODO Coverage Gutters - lcov.info 파일 경로를 변경한다.(./TestResults)
// TODO Coverage Gutters - 기능을 이해한다?.
// TODO .NET Core Test Explorer - 명령어?
// TODO ReportGenerator - dotnet
// TODO .NET Core - dotnet test
// TODO .NET Core - dotnet tool
// TODO .NET Core - dotnet watch
// TODO VSCode - tasks.json
// TODO VSCode - settings.json 전역/개별?
// TODO GitHub - Azure Pipeline(https://www.azuredevopslabs.com/labs/azuredevops/github-integration/)


namespace C01_Coverlet.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 c1 = new Class1();

            int exptected = c1.Add(1, 6);

            exptected.Should().Be(7);
        }
    }
}
