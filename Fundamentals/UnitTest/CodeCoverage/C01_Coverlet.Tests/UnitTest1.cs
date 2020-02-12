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
