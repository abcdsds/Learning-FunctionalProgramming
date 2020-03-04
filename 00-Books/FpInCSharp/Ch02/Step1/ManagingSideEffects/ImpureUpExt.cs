// 목표
//
// 1. 순수 함수와 불순 함수를 구분한다.
// 2. 순수 함수는 [Pure] 속성을 사용한다.
// 3. 확장 메서드를 이용하여 함수를 연속 호출한다(Fluent Interface). 

using System;
using System.Diagnostics.Contracts;
using static System.Console;

namespace ManagingSideEffects
{
    public class ImpureUpExt
    {
        public void SideEffects()
        {
            WriteLine("Enter your name:");

            ReadLine()
                .GreetingFor()
                .Print();
        }
    }

    public static class StringExt
    {
        [Pure]
        public static string GreetingFor(this string self) =>
            $"Hello {self}";

        public static void Print(this string self) => 
            WriteLine(self);
    }
}