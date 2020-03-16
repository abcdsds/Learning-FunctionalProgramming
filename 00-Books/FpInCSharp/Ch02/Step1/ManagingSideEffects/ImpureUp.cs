using System;
using System.Diagnostics.Contracts;

// ===================================================
// using static directive 
// ===================================================
//
// 1. 참고 URL
// https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/using-static
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static
// 
// 2. 문법
// using static <fully-qualified-type-name>;
//
// 3. 예
// Math.PI;
//  vs.
// using static System.Math;
// PI;
//
// 4. 가치
// 순수 함수는 기본적으로 정적 함수로 개발한다.
//
using static System.Console;

namespace ManagingSideEffects
{
    public class ImpureUp
    {
        public void SideEffects()
        {
            WriteLine("Enter your name:");
            var name = ReadLine();
            WriteLine(GreetingFor(name));
        }

        // ===================================================
        // 순수 함수
        // ===================================================
        //
        // 1. 참고 URL
        // https://docs.microsoft.com/ko-kr/dotnet/api/system.diagnostics.contracts.pureattribute?view=netframework-4.8
        //
        // 2. 개요
        // 클래스: PureAttribue
        // 네임스페이스: System.Diagnostics.Contracts
        [Pure]
        public string GreetingFor(string name) =>
            $"Hello {name}";
    }
}