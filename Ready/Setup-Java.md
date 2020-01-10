1. JDK 최신 버전을 설치한다.
   - [jdk 최신 버전 다운로드](https://www.oracle.com/technetwork/java/javase/downloads/index.html) 
   - 설치 기본 경로: C:\Program Files\Java\jdk-13.0.1\
1. Maven 최신 버전을 설치한다.
   - [apache-maven-3.6.3-bin.zip](https://maven.apache.org/download.cgi) 최신 버전 압축 파일을 다운로드 받는다.
   - "C:\Apache\apache-maven-3.6.3" 경로에 압축을 해제한다.
   - Maven 경로는 공백이 없어야 한다.
   ```
   C:\Apache\apache-maven-3.6.3\bin\mvn.cmd
   ```
1. "환경 변수 > 시스템 변수"을 추가한다.
   - JAVA_HOME: C:\Program Files\Java\jdk-13.0.1
   - JDK_HOME: C:\Program Files\Java\jdk-13.0.1
   - Path: ...;%JAVA_HOME%\bin;C:\Apache\apache-maven-3.6.3\bin
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
       "maven.executable.path": "C:/Apache/apache-maven-3.6.3/bin/mvn.cmd",
       "java.home": "C:/Program Files/Java/jdk-13.0.1"
   }
   ```
 1. Maven 프로젝트를 만든다.
   - Ctrl + Shift + P
     -> Maven: Create Maven Project  
     -> maven-archetype-quickstart  
     -> 1.4  
     -> 프로젝트를 생성할 상위 폴더을 선택한다.  
     -> (Maven 시작)  
     -> groupId 입력 요구에 "hello"을 입력한다.  
     -> artifactId 입력 요구에 "hello"을 입력한다.  
     -> version' 1.0-SNAPSHOT와 package 입력 요구는 Enter로 기본값을 사용한다.  
     -> (Maven 완료)
   - "./src/main/java/hello/App.java" 파일을 연다.
   - 실행하기
     - Visual Studio Code: F5 또는 Ctrl + F5
     - 콘솔: java -cp .\target\classes hello.App
     - Maven
       - mvn install
       - java -cp .\target\hello-1.jar hello.App
   

## Reference URLs
- [Visual Studio Code 에 Java 개발 환경 만들기](https://soolper.tistory.com/6)
- [Visual Studio Code 에서의 Java 한글 인코딩 문제](https://soolper.tistory.com/7?category=768175)
