# AutoFixture

## 개요
- [GitHub Link](https://github.com/AutoFixture/AutoFixture)
- AutoFixture is an open source library for .NET designed **to minimize the 'Arrange' phase of your unit tests in order to maximize maintainability.** Its primary goal is to allow developers **to focus on what is being tested rather than how to setup the test scenario**, by making it easier to create object graphs containing test data. 
  - Arrange 단계 코드 최소화를 목표로 설계되었다.
  - Act 단계 수행을 위한 데이터 준비(Setup)을 최소화한다(임의 데이터를 생성한다).
    - Anonymous Test Data vs. Known Test Data
      - Data that is required to be present for the test to be able to execute, but where the value itself is unimportant.