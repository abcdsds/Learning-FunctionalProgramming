# Lession1 > Step1

## 목표
- .NET Core Console 프로그램을 개발한다.

## 배움
- dotnet 명령어을 이용한 솔루션/프로젝트 만들기

1. .NET Core Console 프로젝트 만들기 & 실행하기
   ```shell
    C:\PoC\Tutorial> dotnet new sln -n Tutorial                     // 솔루션 파일 만들기
    C:\PoC\Tutorial> dotnet new console -o .\Lesson1\Step1          // Console 프로젝트 만들기
    C:\PoC\Tutorial> dotnet sln add .\Lesson1\Step1\                // Step1 프로젝트 추가하기
    C:\PoC\Tutorial> dotnet build                                   // 솔루션 빌드하기
    C:\PoC\Tutorial> dotnet run --project .\Lesson1\Step1\ Foo      // Step1 프로젝트 실행하기
    Hello, Foo!
   ```
1. 만들기   
   - dotnet new [sln | console] -n 이름 -o 경로