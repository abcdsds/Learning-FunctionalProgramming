// 목표
// 1. Binding을 이애한다.
// 2. 타입 추론을 이애한다.
//    - 왜 타입 추론을 사용할까?
//      - 타입은 컴파일러에게 위임하고 도메인 서술(변수 이름, 함수 이름)에 집중에한다.
//      - 간결한 코드를 작성할 수 있다.
 
// 정의
// - 바인딩(Binding)
//   바인딩은 식별자(identifier, 이름)를 값 또는 함수와 연결 합니다. let 키워드를 사용하여 값 또는 함수에 이름(식별자, identifier)을 바인딩합니다.
//   A binding associates an identifier with a value or function. You use the let keyword to bind a name to a value or function.
// TODO?: 식(expression) vs. 본문 식(expressionbody, body-expression)
//   - 식: let
//   - 본문 식: let = let ...

// TODO?
// - 모듈 let 의 최상위 수준 또는 클래스 형식에서 바인딩에는 본문 식이 필요 하지 않지만 다른 범위 수준에는 body 식이 필요 합니다. 
//   A let binding at the top level in a module or in a class type does not need to have a body expression, but at other scope levels, the body expression is required.

//
// let 값 또는 패턴(튜플, 레코드) 바인딩 문법
// https://docs.microsoft.com/ko-kr/dotnet/fsharp/language-reference/functions/let-bindings
//
// let identifier [: type] = expressionbody
// let identifier [: type] = expression
// let pattern [: type] = expressionbody
// let pattern [: type] = expression
//
// 예. let identifier [: type] = expressionbody
// let x = 1004
// let x : int = 1004
//

// 목차
// 1. 값 바인딩
// 2. 식별자(identifier)와 식(expression) 구분
// 3. 패턴 바인딩(튜플)
// 4. 본문 식(Body-Expression)
// 5. 바인딩 이름(the bound name) 라이프사이클

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    //
    // 1. 값 바인딩
    //
    // 암시적 타입 정의(타입 추론)
    let x1 = 1004

    // 명시적 타입 정의
    let x2 : int = 1004;

    // 
    // 2. 식별자(identifier)와 식(expression) 구분: 식을 구분할 때 식의 각 줄은 반드시 들여씁니다(indent).
    //
    let someVeryLongIdentifier = 
        1 + 2 + 3

    //
    // 3. 패턴 바인딩(튜플): 이름을 포함하는 패턴을 지정할 수 있다.
    //
    let i, j, k = (1, 2, 3)

    // 
    // 4. 본문 식(Body-Expression) 바인딩: 이름이 사용되는 식(let을 사용하는 식)을 바인딩한다.
    //
    let result =
        let i, j, k = (1, 2, 3)
        i + 2 * j + 3 * k 

    //
    // 5. 바인딩 이름(the bound name) 라이프사이클: 정의된 이후에 사용할 수 있다.
    //

    // Error: x 정의 전에 사용하고 있다.
    //printfn "%d" x 

    // OK: x 정의 후에 사용하고 있다.
    let x = 100
    printfn "%d" x  

    0 // return an integer exit code
