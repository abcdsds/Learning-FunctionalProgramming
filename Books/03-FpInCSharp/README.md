# 함수형 프로그래밍 C#, Functional Programming in C#

- 책 정보
  - Book: https://www.manning.com/books/functional-programming-in-c-sharp
  - GitHub: https://github.com/la-yumba/functional-csharp-code
  - NuGet: https://www.nuget.org/packages/LaYumba.Functional

# 목차

1. [Chapter 00. Development Environmet](./Ch00)
1. [Chapter 01. Introducing functional programming](./Ch01)
1. [Chapter 02. Why function purity matters](./Ch02)

# Introducing functional programming

## 1. Functional Programming 정의

1. Functional Programming 정의
   - In computer science, functional programming is a **programming paradigm**—a style of building the structure and elements of computer programs—that treats computation as the evaluation of **mathematical functions** and **avoids changing-state and mutable data**. 
   - It is a **declarative programming paradigm** in that programming is done with **expressions or declarations** instead of statements. 
   - In functional code, the output value of a function **depends only on its arguments**, so calling a function with the same value for an argument always produces the same result. 
   - This is in contrast to **imperative programming** where, in addition to a function's arguments, global program state can affect a function's resulting value. 
   - One of the key motivations for the development of functional programming is making **a program easier to understand** by eliminating changes in state that do not depend on function inputs which are called **side effects**.
   - 함수형 프로그래밍(functional programming)은 자료 처리를 **수학적 함수**의 계산으로 취급하고 **상태와 가변 데이터를 멀리**하는 **프로그래밍 패러다임**의 하나이다.
   - **명령형 프로그래밍**에서는 상태를 바꾸는 것을 강조하는 것과는 달리, 함수형 프로그래밍은 **함수의 응용**을 강조한다. 
   - 프로그래밍이 **문**이 아닌 **식이나 선언**으로 수행되는 **선언형 프로그래밍 패러다임**을 따르고 있다.
1. Functional Programming 주요 키워드
   - functional programming vs. imperative programming
   - 기대효과: 패러다임
     - declarative programming paradigm
   - 방법
     - mathematical functions
       - depends only on its arguments vs. side effects
       - expressions(declarations) vs. statements
     - mutable data(avoids changing-state)

<br/>

1. 특징
   - Functionas as first-class values

     ```cs
     Func<int, int> triple = x => x * 3;   // 함수을 값으로 처리한다.
     var range = Enumerable.Range(1, 3);
     var triples = range.Select(triple);
     ```

   - Avoiding state mutation

<br/>

## 참고 자료

- [함수형 프로그래밍](https://ko.wikipedia.org/wiki/%ED%95%A8%EC%88%98%ED%98%95_%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%98%EB%B0%8D)
- [Functional Programming](https://en.wikipedia.org/wiki/Functional_programming)