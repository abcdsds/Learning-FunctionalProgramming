# 정직한 설계 for C#

1. 타입(표현)
   - Make illegal state unrepresentable
   - Product 타입(and), Sum 타입(or)
   - 구별된 공용 구조체(Discriminated Unions) and Visitor 패턴
   - Enum 타입 -> 객체화
2. 객체
   - 정적 생성 메서드
   - Builder 패턴(생성자 매개변수)
   - 의존성 주입
   - 의존성 전파 차단 Factory 패턴
   - 비교(iequatable)
   - 불변(With)
3. 객체 메서드
   - 순수 함수
   - 예외
   - NULL
   - 비동기
   - 로그
4. 단위 테스트
   - 용어
   - Moq
   - 생성자 변화 흡수하기
   - 랜덤 데이터 생성
5. 성능 단위 테스트
6. Designing with types 예제
