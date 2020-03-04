# F# 워크숍

- https://github.com/jorgef/fsharpworkshop
- 함수형 주요 개념
  - Immutability
    - Side Effects(대입, 함수) -> Referential Transparency(치환) => **Pure Function** -> Lazy Evaluation
  - Declarative Style
  - Separation of Data and Behaviour

## Module 1.

1. Binding: let
1. Record: { }, { = ; }, { with }, let
   - 정의하기: type ... = { ... }
   - 생성하기: let ... = { ... = ...; }
   - 변경(불변)하기: { ... with ... = ... }
1. Functions: let
   - 정의하기: let ... ... = ...
1. Tuple: ( , )
   - 매개변수로 받기: let ..., ... = ...
   - 정의하기: (..., ...)

### 추가 학습

1. module/open

### 환경 구성하기

1. Visual Studio Code
   - Ionide-fsharp
   - .NET Core Test Explorer
1. 단위 테스트 NuGet
   - Unquote

### TODO

- ".NET Core Test Explorer"에서 F# 단위 테스트 코드을 열지 못한다(링크가 안된다).
- Code Coverage 결과 확인하기
- Code Coverage 코드 확인하기
- F# -> C# 코드로 변경하기

## Module 2.