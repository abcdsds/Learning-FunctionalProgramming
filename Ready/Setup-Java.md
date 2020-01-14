# Java 개발 환경 구축하기
## 개발 환경 구성하기
1. JDK 최신 버전 설치하기.
   - [JDK 최신 버전](https://www.oracle.com/technetwork/java/javase/downloads/index.html)을 다운로드 받는다.
   - 2020-01-11(토) 기준으로 13.0.1이 최신 버전이다.
   - 기본 설치 경로: C:\Program Files\Java\jdk-13.0.1\
1. Maven 최신 버전 설치하기
   - [Maven 치신 버전](https://maven.apache.org/download.cgi)을 다운로드 받는다.
   - 2020-01-11(토) 기준으로 3.6.3이 최신 버전이다.
   - "C:\Apache\apache-maven-3.6.3" 경로에 압축을 해제한다(경로에 공백이 없어야 한다).
   ```
   C:\Apache\apache-maven-3.6.3\bin\mvn.cmd
   ```
1. "환경 변수 > 시스템 변수" 추가하기
   - JAVA_HOME: C:\Program Files\Java\jdk-13.0.1
   - JDK_HOME: C:\Program Files\Java\jdk-13.0.1
   - Path: ... ;%JAVA_HOME%\bin;C:\Apache\apache-maven-3.6.3\bin
1. Java 버전 확인하기
   - java -version
   ```shell
   C:\Users\HyungHo.Ko>java -version
   java version "13.0.1" 2019-10-15
   Java(TM) SE Runtime Environment (build 13.0.1+9)
   Java HotSpot(TM) 64-Bit Server VM (build 13.0.1+9, mixed mode, sharing)
   ```
1. Maven 버전 확인하기
   - mvn -version
   ```shell
   C:\Users\HyungHo.Ko>mvn -version
   Apache Maven 3.6.3 (cecedd343002696d0abb50b32b541b8a6ba2883f)
   Maven home: C:\Apache\apache-maven-3.6.3\bin\..
   Java version: 13.0.1, vendor: Oracle Corporation, runtime: C:\Program Files\Java\jdk-13.0.1
   Default locale: ko_KR, platform encoding: MS949
   OS name: "windows 10", version: "10.0", arch: "amd64", family: "windows"
   ```
1. VS Code 설치하기   
   - https://code.visualstudio.com/ 사이트를 방문하여 최신 버전을 설치한다.
   - 기본 옵션으로 설치한다.
1. VS Code 확장 도구 설치하기
   - 단축키: Ctrl + Shift + X
   - "Java Extention Pack"을 설치한다(추가적으로 5개 확장 도구가 함께 설치된다).
     - Java Dependensy Viewer
     - Language Support for Java(TM) by Red Hat
     - Debugger for Java
     - Java Test Runner
     - Maven for Java
1. VS Code 환경 변수 설정하기
   - 단축키: Ctrl + ,
   - Maven과 Java 경로를 추가한다.
   ```
   {
       "maven.executable.path": "C:/Apache/apache-maven-3.6.3/bin/mvn.cmd",
       "java.home": "C:/Program Files/Java/jdk-13.0.1"
   }
   ```
## hello 프로젝트 만들기
1. Palette로 프로젝트 만들기
   - Ctrl + Shift + P
   - Maven: Create Maven Project  
   - maven-archetype-quickstart  
   - 1.4  
   - 프로젝트를 생성할 상위 폴더을 선택한다.  
   - (Maven 시작)  
   - groupId 입력 요구에 "hello"을 입력한다.  
   - artifactId 입력 요구에 "hello"을 입력한다.  
   - version' 1.0-SNAPSHOT와 package 입력 요구는 Enter로 기본값을 사용한다.  
   - (Maven 완료)  
1. App.java 파일 열기
   - "./src/main/java/hello/App.java" 파일을 연다.
1. hello 프로젝트 실행하기
   - Visual Studio Code
     - F5 또는 Ctrl + F5
   - 콘솔
     - -cp <class search path of directories and zip/jar files>
     ```shell
     java -cp .\target\classes hello.App
     ```
   - 콘솔 & Maven
     ```shell
     mvn install
     java -cp .\target\hello-1.jar hello.App
     ```
## 의존성 있는 프로젝트 만들기
1. 의존성 추가하기
   - 단축키: Ctrl + Shift + P
   - Maven: Add a dependency
   - 추가할 프로젝트를 선택한다(예. hello).
   - 추가할 의존성을 검색한다(예. commons-codec).
   - 검색된 의존성을 선택한다(예. commons-codec commons-codec).
   - 의존성이 추가된다.
   - pom.xml 파일에서 의존성을 확인한다.
     ```xml
     <project ...>
       <dependencies>
         <dependency>
           <groupId>commons-codec</groupId>
           <artifactId>commons-codec</artifactId>
           <version>20041127.091804</version>
         </dependency>
       </dependencies>
     </project>
     ```
   - verion을 "20041127.091804"에서 "1.13"으로 변경한다.
     ```xml
     <version>1.13</version>
     ```
1. Maven 의존성 설치하기
   - 의존성 설치하기
     ```xml
     mvn install
     ```
   - 의존성 확인하기
     - Maven 경로
       - %USERPROFILE%\.m2\repository
       - 예. C:\Users\Hyungho.Ko\.m2\repository
     - 의존성 경로 
       - 예. C:\Users\Hyungho.Ko\.m2\repository\commons-codec\commons-codec\1.13
   - 의존성을 출력 경로에 포함 시키기(안됨)
        <plugin>
          <artifactId>maven-dependency-plugin</artifactId>
          <executions>
            <execution>
              <phase>process-sources</phase>
              <goals>
                <goal>copy-dependencies</goal>
              </goals>
              <configuration>
                <outputDirectory>${targetdirectory}</outputDirectory>
              </configuration>
            </execution>
          </executions>
        </plugin>
    - 의존성을 jar 파일에 포함 시키기
      ```xml
<plugin>
    <artifactId>maven-assembly-plugin</artifactId>
    <version>3.1.1</version>
    <configuration>
        <descriptorRefs>
            <descriptorRef>jar-with-dependencies</descriptorRef>
        </descriptorRefs>
    </configuration>
    <executions>
        <execution>
            <id>make-assembly</id>                        <!-- this is used for inheritance merges -->
            <phase>package</phase>                        <!-- bind to the packaging phase -->
            <goals>
                <goal>single</goal>
            </goals>
        </execution>
    </executions>
</plugin>
      ```

## Reference URLs
- [Java Project Management in VS Code](https://code.visualstudio.com/docs/java/java-project)
- [Visual Studio Code 에 Java 개발 환경 만들기](https://soolper.tistory.com/6)
- [Visual Studio Code 에서의 Java 한글 인코딩 문제](https://soolper.tistory.com/7?category=768175)
- [Visual Studio Code의 Java 확장을 이용한 간단한 프로젝트 구축](https://www.sysnet.pe.kr/Default.aspx?mode=2&sub=0&detail=1&pageno=0&wid=11980&rssMode=1&wtype=0)

## TODO
1. hello 예제 작성하여 추가하기
1. 의존성 예제 작성하여 추가하기
