# Programming for More Fun with You
- 설렘

## 목차 

* [00-Books](.\00-Books)
  * [Functional Programming in C#](.\00-Books\FpInCSharp)
  * [코틀린으로 배우는 함수형 프로그래밍](.\00-Books\LearnFunctionalProgrammingWithKotlin)
  * [MakingYourCSharpCodeMoreFunctional](.\00-Books\MakingYourCSharpCodeMoreFunctional)
  * [Object](.\00-Books\Object)
* [01-Glossary](.\01-Glossary)
* [02-OS](.\02-OS)
  * [Linux](.\02-OS\Linux)
  * [Windows](.\02-OS\Windows)
  * [chcp_949..png](.\Learning-FunctionalProgramming\02-OS\chcp_949..png)
* [03-IDE](.\03-IDE)
  * [Git](.\03-IDE\Git)
  * [GitHub](.\03-IDE\GitHub)
  * [GitLab](.\03-IDE\GitLab)
  * [VSCode](.\03-IDE\VSCode)
* [04-Runtime](.\04-Runtime)
  * [DotNetCore3](.\04-Runtime\DotNetCore3)
* [05-Container](.\05-Container)
  * [Docker](.\05-Container\Docker)
  * [Kubernetes](.\05-Container\Kubernetes)
* [06-Language](.\06-Language)
  * [CSharp](.\06-Language\CSharp)
  * [FSharp](.\06-Language\FSharp)
  * [Golang](.\06-Language\Golang)
* [07-ActorModel](.\07-ActorModel)
* [08-Network](.\08-Network)
  * [DistributedTracing](.\08-Network\DistributedTracing)
  * [Kafka](.\08-Network\Kafka)
* [09-Design](.\09-Design)
  * [DDD](.\09-Design\DDD)
  * [TDD](.\09-Design\TDD)
* [10-Architecture](.\10-Architecture)
  * [HonstDesign](.\10-Architecture\HonstDesign)
* [11-NoSQL](.\11-NoSQL)
  * [Elaticsearch](.\11-NoSQL\Elaticsearch)
  * [MongoDB](.\11-NoSQL\MongoDB)
  * [Redis](.\11-NoSQL\Redis)


<br/>

## 주요 개념 관계

- 순수 함수(Prue Function) vs. 불수 함수(Impure Function)
  - 조건: Side Effect Free, 참조 투명성(Referential Transparency)
    - 출력은 입력만 의존한다.
  - 결과
    - 격리(Isolation) => 단위 테스트가 쉽다.
    - 격리(Isolation) => 병렬화가 쉽다.
    - 함수 출력 有 => 함수 출력이 있다(식: Expression).
    - 함수 출력 有 => 함수 출력을 다음 함수의 입력으로 연결할 수 있다(합성 함수: Composite Function)
    - 함수 출력 有 => 함수 출력 값을 재사용할 수 있다(치환, 지연 처리: Lazy Evaluation)
    

## 주요 개념

- First-class citizen
  - First-class function, First-class class
- Immutabe vs. Mutable
- Pure Function vs. Impure Function
- Side Effects
- Referential Transparency
- Expression vs. Statement
- Higher Order Function
- Strategy Pattern vs. Template Method Pattern
- Lambda Function
- Closure
- Lazy Evaluation
- Recursive
- Category Theory
- Composite Function
- Functor
- Applicative Functor
- Monoid
- Monad
- Free Monad
- Pattern matching
- Covariance vs. Contravariance
- Currying
- Abstraction
- Morphism
- Identity
- Associated Law
  - 이항연산이 만족하거나 만족하지 않는 성질이다.
  - 한 식에서 연산이 두 번 이상 연속될 때, 앞쪽의 연산을 먼저 계산한 값과 뒤쪽의 연산을 먼저 계산한 결과가 항상 같을 경우 그 연산은 결합법칙을 만족한다고 한다.

## 개발 환경 구성

1. [C# 개발 환경 구축하기](./Environment/Setup-CSharp.md)
1. [F# 개발 환경 구축하기](./Environment/Setup-FSharp.md)
1. [Java 개발 환경 구축하기](./Environment/Setup-Java.md)

## DOING

1. [정직한 설계](./HonstDesign)
1. [F# 기초](./Fundamentals/FSharp/FSharpWorkshop)
1. [용어집](./Glossaries)
1. BOOK - [코틀린으로 배우는 함수형 프로그래밍(조재용님, 우명인님)](./Books/01-LearnFunctionalProgrammingWithKotlin)
1. BOOK - [오브젝트(조영호님)](./Books/02-Object)
1. EDU - [Making Your C# Code More Functional](./Edu/MakingYourCSharpCodeMoreFunctional)
1. Dependency Injection revisited
   - [Dependency Injection revisited - Youtube 2018-05-29](https://www.youtube.com/watch?v=4hvIwRHylj0)
   - [Dependency Injection revisited - Youtube 2018-08-06](https://www.youtube.com/watch?v=qBYVW4ghMi8)
   - [From Dependency injection to dependency rejection - Youtube 2017-04-18](https://www.youtube.com/watch?v=cxs7oLGrxQ4)
   - [Async injection - Youtube 2019-03-29](https://www.youtube.com/watch?v=BsavoQWAVqM)
   - [Dependency Injection revisited - BLOG](https://blog.ploeh.dk/2018/07/24/dependency-injection-revisited/)
   - [Flattening arrow code using a stack of monads - BLOG](https://blog.ploeh.dk/2018/07/30/flattening-arrow-code-using-a-stack-of-monads/)
   - [Dependency Injection revisited - GitHub](https://github.com/ploeh/dependency-injection-revisited)
   - [Asynchronous Injection - GitHub](https://github.com/ploeh/asynchronous-injection)
   - [Visitor as a sum type - BLOG](https://blog.ploeh.dk/2018/06/25/visitor-as-a-sum-type/)
   - [How language features affect OO design - BLOG](https://medium.com/ingeniouslysimple/how-language-features-affect-oo-design-237cfc850752)
   - [Union Types in C# - BLOG](http://boustrophedonic.com/blog/2012/10/21/union-types-in-csharp/)
   - [Functional approaches to dependency injection](https://fsharpforfunandprofit.com/posts/dependency-injection-1/)
   - [Learning Dependency Injection WPF - GitHub](https://github.com/jeremybytes/learning-dependency-injection)

## TODO

1. BOOK - [실전 코드로 배우는 실용주의 디자인 패턴](http://www.yes24.com/Product/goods/34572809)
1. BOOK - [Functional C#](http://www.yes24.com/Product/Goods/69669484?scode=032&OzSrank=20)
1. BOOK - [함수형 사고](http://www.yes24.com/24/UsedShop/Goods/29029252?scode=048_002)
1. BOOK - [Functional Programming in C++](http://www.yes24.com/Product/Goods/77275593?scode=032&OzSrank=16)
1. BOOK - [Go로 배우는 함수형 프로그래밍](http://www.yes24.com/Product/Goods/73293439?scode=032&OzSrank=2)
1. BOOK - [모던 자바 인 액션(자바 8 인 액션)](http://www.yes24.com/Product/Goods/77125987?scode=032&OzSrank=14)
1. BOOK - [함수형 자바스크립트](http://www.yes24.com/24/UsedShop/Goods/58181696?scode=048_002)
1. BOOK - [하스켈로 배우는 함수형 프로그래밍](http://www.yes24.com/Product/Goods/19842361?scode=032&OzSrank=5)
1. BOOK - [Domain Modeling Made Functional](https://pragprog.com/book/swdddf/domain-modeling-made-functional)
1. BOOK - [Functional Programming in C# with Categories](https://leanpub.com/functional-programming-in-cSharp-with-categories)
1. BOOK - [컴퓨터과학이 여는 세계](http://www.yes24.com/Product/Goods/17976737)
1. BLOG - [모노이드](https://sojin.io/article/%EB%AA%A8%EB%85%B8%EC%9D%B4%EB%93%9C/)
1. BLOG - [공변과 반공변](https://sojin.io/article/%EA%B3%B5%EB%B3%80%EA%B3%BC-%EB%B0%98%EA%B3%B5%EB%B3%80)
1. BLOG - [F# David Raab](http://sidburn.github.io/Series)
1. BLOG - [F# for fun and profit - Designing with types](https://fsharpforfunandprofit.com/series/designing-with-types.html)
1. BLOG - [F# for fun and profit - Map and Bind and Apply, Oh my!](https://fsharpforfunandprofit.com/series/map-and-bind-and-apply-oh-my.html)
1. BLOG - [Error handling with Applicative Functors in F# and C#](https://blog.leifbattermann.de/2015/09/12/error-handling-with-applicative-functors-in-f-and-c/)
1. BLOG - [Monads explained in C#](https://mikhail.io/2016/01/monads-explained-in-csharp/)
1. BLOG - [Monads explained in C# (again)](https://mikhail.io/2018/07/monads-explained-in-csharp-again/)
1. BLOG - [Dimitris Papadimitriou - How to reverse a tree in C# the Functional way in 5 lines of code](https://medium.com/@dimpapadim3/how-to-reverse-a-tree-in-c-the-functional-way-in-5-lines-of-code-130c9cddcb5b)
1. BLOG - [Dimitris Papadimitriou - Infinite Data structures in C#](https://medium.com/@dimpapadim3/infinite-data-structures-in-c-b3655386befe)
1. BLOG - [Dimitris Papadimitriou - Async/await - Continuation CoMonad in C#](https://medium.com/@dimpapadim3/async-await-continuation-comonad-in-c-558a644eb4ef)
1. BLOG - [Dimitris Papadimitriou - Either Monad in C#— A Functional approach to error handling](https://medium.com/@dimpapadim3/either-is-a-common-type-in-functional-languages-94b86eea325c)
1. BLOG - [Dimitris Papadimitriou - Functional Linq tips for senior C# developers](https://medium.com/@dimpapadim3/functional-linq-tips-for-senior-c-developers-bfb869547610)
1. BLOG - [Dimitris Papadimitriou - Discovering the Continuation Monad in C#](https://medium.com/@dimpapadim3/deriving-continuation-monad-from-callbacks-23d74e8331d0)
1. BLOG - [Dimitris Papadimitriou - Advance Functors in C#. Beyond lists](https://medium.com/@dimpapadim3/advance-functors-and-design-patterns-with-c-fba9c9cae0f9)
1. BLOG - [Dimitris Papadimitriou - Introduction to Functors in C#](https://medium.com/@dimpapadim3/introduction-to-functors-in-c-1e6b434c85ae)
1. BLOG - [Dimitris Papadimitriou - Monads for object oriented programming with C#](https://medium.com/@dimpapadim3/monads-in-oop-with-c-a4ec11f1f9d9)
1. BLOG - [A Glossary of Functional Programming](http://degoes.net/articles/fp-glossary)
1. BLOG - [The Science Behind Functional Programming](https://www.47deg.com/blog/science-behind-functional-programming/)
1. BLOG - [Functional C#](https://weblogs.asp.net/dixin/Tags/Functional%20C%23)
1. BLOG - [Functional Programming in C#: A Brief Guide](http://hamidmosalla.com/2019/04/25/functional-programming-in-c-sharp-a-brief-guide/)
1. BLOG - [Functional Programming Jargon](https://github.com/hemanth/functional-programming-jargon#arity)
1. BLOG - [Functional Programming (F#) for C# Developers](https://www.dotnetcurry.com/csharp/1384/functional-programming-fsharp-for-csharp-developers)
1. BLOG - [Introduction to functional programming with C#](https://medium.com/@naveenrtr/introduction-to-functional-programming-with-c-b167f15221e1)
1. EDU - [컴퓨터과학이 여는 세계](https://www.youtube.com/watch?v=HTWSPoDLmHI&list=PL0Nf1KJu6Ui7yoc9RQ2TiiYL9Z0MKoggH)
1. EDU - [Functional Programming with C#](https://www.pluralsight.com/courses/functional-programming-csharp)
1. EDU - [Applying Functional Principles in C#](https://www.pluralsight.com/courses/csharp-applying-functional-principles)
1. EDU - [Writing Purely Functional Code in C#](https://www.pluralsight.com/courses/writing-purely-functional-code-csharp)
1. SRC - [CSharpFunctionalExtensions](https://github.com/vkhorikov/CSharpFunctionalExtensions)
1. SRC - [Category Theory for DotNET Programmers](https://github.com/cboudereau/category-theory-for-dotnet-programmers)
1. SRC - [LanguageExt](https://github.com/louthy/language-ext)
1. PPT - [Category Theory for Beginners](https://www.slideshare.net/kenbot/category-theory-for-beginners), [Youtube](https://www.youtube.com/watch?v=jDhMDgU7Koc)
1. MOV - [Algebraic Data Types for C# - John Azariah](https://www.youtube.com/watch?v=CUdp1XGwRng&list=PL03Lrmd9CiGdch9Ul3PynPDZcZ18sz9KV&index=39)
1. MOV - [Functional Programming With C# Workshop](https://www.youtube.com/watch?v=OPxyomlxP4o)
1. MOV - [Functional Programming in C#](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Functional-Programming-in-CSharp)
1. MOV - [Category theory and life](https://www.youtube.com/watch?v=ho7oagHeqNc)
   - [PDF](https://slides.yowconference.com/yowlambdajam2018/Cheng-CategoryTheoryandLife.pdf)

## TODO - gRPC
1. [Produce & Consume a .NET Core 3.0 gRPC Service with Entity Framework](https://www.youtube.com/watch?v=Xh47x_C-aMM)
   - [GrpcWorld - GitHub](https://github.com/medhatelmasry/GrpcWorld)
   - [GrpcWorld - BLOG](http://blog.medhat.ca/2019/10/producing-consuming-net-core-30-grpc-db.html) 
   - .proto 파일
     - build action 
1. [Intro to gRPC in C# - How To Get Started](https://www.youtube.com/watch?v=QyxCX2GYHxk)
   - .proto 파일: stream 
     - Server cs 파일: IServiceStreamWriter
     - Client cs 파일: using, ResponeStream.MoveNext(), .Current 
   - .proto 파일: service X 
     - Server cs 파일: XService : X.XBase
1. [From WCF to gRPC](https://www.youtube.com/watch?v=76X9oo-LlUY)
   - https://github.com/RendleLabs/ndc-london-2020
   - https://github.com/RendleLabs/grpc-for-wcf-developers
   - https://github.com/RendleLabs/grpc-dotnet
1. [WCF 개발자를 위한 ASP.NET Core gRPC](https://docs.microsoft.com/ko-kr/dotnet/architecture/grpc-for-wcf-developers/)
1. [Protocol Buffer Basics: C#](https://developers.google.com/protocol-buffers/docs/csharptutorial) 

