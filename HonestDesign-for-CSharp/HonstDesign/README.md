# 정직한 설계

## 강좌

- [Advanced Defensive Programming Techniques](https://app.pluralsight.com/library/courses/advanced-defensive-programming-techniques)
- [Tactical Design Patterns in .NET: Creating Objects](https://app.pluralsight.com/library/courses/tactical-design-patternsdot-net)
- [Specification Pattern in C#](https://app.pluralsight.com/library/courses/csharp-specification-pattern)
- [C# Extension Methods](https://app.pluralsight.com/library/courses/c-sharp-extension-methods)

## 주요 키워드

- 일관성 Consistent
- 완전성 Complete
  
## 패턴

- Factory
- Template Method
- Builder
- Fluent Builder
- Specification

## NuGet

- [LanguageExt](https://github.com/louthy/language-ext)

## 목차

1. 타입(표현)
   - Make illegal state unrepresentable
   - Product 타입(and), Sum 타입(or)
   - 구별된 공용 구조체(Discriminated Unions) and Visitor 패턴
   - Enum 타입 -> 객체화
   - Sum 타입
2. 객체 생성
   - 생성자 예외: Validation
   - 정적 생성 메서드
   - Builder 패턴(생성자 매개변수)
     - 객체 생성자 접근 차단하기
       - 빌더와 객체을 네임스페이스로 분리
       - 빌더와 같은 네임스페이스에 객체 인터페이스 추가
     - 생성 전에 성공/실패을 판단할 수 있다.
     - Func<IXyz> CreateFactory() { ... return _.Build; } 지연 생성할 수 있다.
   - FluentBuilder 패턴
   - Factory
     - 생성자
     - 정적 함수
   - Specification Pattern
3. 객체
   - 의존성 주입
   - 의존성 전파 차단 Factory 패턴
   - 비교(iequatable)
   - 불변(With)
   - Deep Copy
4. 객체 메서드
   - 순수 함수
   - 예외
   - NULL
   - 비동기
   - 로그
5. 단위 테스트
   - 용어
   - Moq
   - 생성자 변화 흡수하기
   - 랜덤 데이터 생성
6. 성능 단위 테스트
7. Designing with types 예제
   - 상태 머신

## 설계 규칙

1. Creation
   - Define one factory function per class.
     - No multiple constructors for a class.
     - They indicate multiple responsibilities.
   - Have no discrete parameters(no enums, booleans, etc.).
   - Existential Precondition
     - A rule which must be satisfied before an object can be constructed.
2. Object
   - If you have the object, then it is fine.
   - No defense after construction.
3. Method arguments
   - Naver accept null argument value.