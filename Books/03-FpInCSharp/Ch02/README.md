# Chapter 02. Why function purity matters

## 1. 용어
- 순수 함수(Pure Function)
  - The output depends entirely on the input arguments.
  - Cause no side effects.
- 불순 함수(Impure Function)
  - Factors other than input arguments may affect the output.
  - May cause side effects.
- Parallelization
  - Different threads carry out tasks in parallel
- Lazy evaluation
  - Only evaluate values as needed
- Memoization
  - Cache the result of a function so it’s only computed once