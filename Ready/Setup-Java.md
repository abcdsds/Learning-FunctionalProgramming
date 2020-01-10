1. JDK 최신 버전을 설치한다(2020년 1월 7일 기준).
   - [jdk 최신 버전 다운로드](https://www.oracle.com/technetwork/java/javase/downloads/index.html) 
   - 설치 기본 경로: C:\Program Files\Java\jdk-13.0.1\
1. "환경 변수 > 시스템 변수"을 추가한다.
   - JAVA_HOME: C:\Program Files\Java\jdk-13.0.1
   - JDK_HOME: C:\Program Files\Java\jdk-13.0.1
   - Path: ...;%JAVA_HOME%\bin
1. Java 버전을 확인한다.
   - java -version
   ```shell
   C:\Users\HyungHo.Ko>java -version
   java version "13.0.1" 2019-10-15
   Java(TM) SE Runtime Environment (build 13.0.1+9)
   Java HotSpot(TM) 64-Bit Server VM (build 13.0.1+9, mixed mode, sharing)
   ```
1. Visual Studio Code을 설치한다.   
   - https://code.visualstudio.com/

1. Visual Studio Code 확장 도구를 설치한다(단축키: Ctrl + Shift + X).
   - Java Extention Pack
     - Java Dependensy Viewer
     - Language Support for Java(TM) by Red Hat
     - Debugger for Java
     - Java Test Runner
     - Maven for Java
1. Visual Studio Code Java HOME 경로를 입력한다(단축키: Ctrl + ,)
   - User > Extensions > Java configuration - Home(edit in settings.json)
   ```
   {
       "java.home" : "C:/Program Files/Java/jdk-13.0.1"
   }
   ```

"java.home" : "C:/Program Files/Java/jdk-13.0.1"     

## Reference URLs
- [Visual Studio Code 에 Java 개발 환경 만들기](https://soolper.tistory.com/6)
- [Visual Studio Code 에서의 Java 한글 인코딩 문제](https://soolper.tistory.com/7?category=768175)
