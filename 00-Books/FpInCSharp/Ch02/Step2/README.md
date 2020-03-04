## 따라하기
1. 프로젝트 만들기
   - ```dotnet new console -o .\Ch02\Step1\ManagingSideEffectsCalc```
   - ```dotnet new xunit -o.\Ch02\Step1\ManagingSideEffectsCalc.Tests```
1. 프로젝트 참조하기
   - ```dotnet add .\Ch02\Step2\ManagingSideEffectsCalc.Tests reference .\Ch02\Step2\ManagingSideEffectsCalc```
3. 프로젝트 추가하기
   - ```dotnet sln add .\Ch02\Step1\ManagingSideEffectsCalc```
   - ```dotnet sln add .\Ch02\Step1\ManagingSideEffectsCalc.Tests```
4. 패키지 참조하기
   - ```dotnet add .\Ch02\Step1\ManagingSideEffectsCalc.Tests package FluentAssertions```