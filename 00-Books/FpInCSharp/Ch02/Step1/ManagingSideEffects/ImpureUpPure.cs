// 목표
//
// 1. 순수 함수와 불순 함수를 구분한다.
// 2. 순수 함수는 [Pure] 속성을 사용한다.

using System;
using System.Diagnostics.Contracts;

// ===================================================
// using static directive 
// ===================================================
//
// 1. 가치
// 순수 함수는 기본적으로 정적 함수로 개발한다.
// "using static directive"을 이용하여 정적 함수 호출를 간결하게 한다.
//
// 2. 참고 URL
// https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/using-static
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static
// 
// 3. 문법
// using static <fully-qualified-type-name>;
//
// 4. 예
// using static System.Math;
// PI;
// Math.PI;
//
using static System.Console;

namespace ManagingSideEffects
{
    public class ImpureUpPure
    {
        public void SideEffects()
        {
            WriteLine("Enter your name:");

            var name = ReadLine();
            var greet = GreetingFor(name);

            WriteLine(greet);
        }

        // ===================================================
        // 순수 함수
        // ===================================================
        //
        // 1. 가치
        // 입력 값만 의존하여 출력 값을 만든다.
        //
        // 2. 참고 URL
        // https://docs.microsoft.com/ko-kr/dotnet/api/system.diagnostics.contracts.pureattribute?view=netframework-4.8
        //
        // 3. 개요
        // 클래스: PureAttribue
        // 네임스페이스: System.Diagnostics.Contracts
        //
        [Pure]
        public string GreetingFor(string name) =>
            $"Hello {name}";
    }
}