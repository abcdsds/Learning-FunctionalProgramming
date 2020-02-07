# Visual Studio Code

## 단축키

- 참조 자료: https://code.visualstudio.com/docs/editor/codebasics
- Ctrl + Shift + P : Command Palette
- Ctrl + Shift + Alt + 방향키/페이지키 : Column Selection
- Shift + Alt + 마우스 : Column Box Selection

## VSCode Settings

1. 폴더 제외 시키기
   - Ctrl + Shift + P > "Preferences: Open Workspace Settins"
   - Workspace > Text Editor > Files
     - Files: Excluede

       ```json
        {
            "files.exclude": {
                "**/bin": true,
                "**/obj": true
            }
        }
       ```

1. settins.json 파일
   - VSCode 설정 파일이다.
1. launch.json 파일
   - VSCode "Debug and Run" 운영을 위한 설정 파일이다.
   - "${workspaceFolder}"은 솔루션 파일이 있는 경로다.
1. tasks.json 파일

### C# 언어

#### 사용 중

1. Auto-Using for C#
   - using 구문을 자동 생성해 준다.
1. C# Extensions
   - 인터페이스와, 클래스 기본 코드를 자동 생성해 준다.
1. .NET Core Extension Pack  
   - https://marketplace.visualstudio.com/items?itemName=doggy8088.netcore-extension-pack
1. Awesome DotNetCore Pack
   - C# and DotNetCore
     - [x] C# for Visual Studio Code (powered by OmniSharp)
     - [x] C# Extensions
     - [ ] C# Snippets
     - [ ] Super Sharp (C# extensions)
     - [ ] Paste JSON as Code
     - [ ] Dotnet Core Essentials
     - [ ] Essential ASP.NET Core Snippets
   - Code formatting and comments
     - [ ] EditorConfig
     - [ ] XML Documentation Comments Support for Visual Studio Code
   - Dev Tools
     - [ ] IL Viewer for Visual Studio Code
     - [ ] .NET Core Test Explorer
     - [ ] GitLens
     - [ ] Path Intellisense
     - [ ] Todo Tree
     - [ ] Copy text
1. Dev Tools
   - [ ] Output Colorizer
   - [ ] Todo+
   - [ ] VS Live Share
   - [ ] GitLab Workflow
   - [ ] Remote – Containers
   - [ ] Path Intellisence
   - [ ] Visual Studio IntelliCode
   - [ ] GitHub Extension
   - [ ] Docker
   - [ ] Code Spell Checker
   - [ ] Markdown PDF
   - [ ] Color Picker
1. Icons
   - [x] Studio Icons

#### 검토 대상

1. C# FixFormat??
1. C# Namespace Autocompletion??
1. C# Model to Builder??
1. 코드 분석관련 Roslynator
   - TODO: Nullable 결과를 Editor에서 확인할 수 있는 것 찾기
1. 솔루션 관리
   - .NET Core Tools
     - Build, Run, Execute Context 메뉴을 제공한다.
   - vscode-solution-explorer
     - 메뉴 사용성이 어색하다.
1. Dotnet core commands, dotnet
   - dotnet Command 명령어을 Palette에서 처리한다.
1. .NET Core Add Reference
   - 프로젝트 참조를 .csproj 파일의 Context 메뉴로 제공한다.  
1. C# Snippet 생성 및 관리 관련??
1. 단위 테스트 관련??

### Markdown

1. [Markdown All in One](https://marketplace.visualstudio.com/items?itemName=yzhang.markdown-all-in-one) 설치
   - 미리보기: Ctrl + Shift + V
1. [markdownlint](https://marketplace.visualstudio.com/items?itemName=DavidAnson.vscode-markdownlint) 설치
   - Markdown 작성 코멘트

### Diagram

1. [PlantUmlClassDiagramGenerator](https://github.com/pierre3/PlantUmlClassDiagramGenerator)
   - dotnet tool을 이용하여 설치한다.

     ```shell
     dotnet tool install --global PlantUmlClassDiagramGenerator --version 1.2.0
     ```

   - 프로젝트 단위로 PlantUML 파일 만들기
   
     ```shell
     puml-gen 입력경로 출력경로 -dir -excludePaths bin,obj -allInOne
     puml-gen .\01 .\01\UMLs -dir -excludePaths bin,obj -allInOne
     ```

2. PlantUML
   - [PlantUML](https://github.com/qjebbs/vscode-plantuml) 설치
   - [Graphviz](https://graphviz.gitlab.io/_pages/Download/Download_windows.html) 다운로드 및 설치
   - VS Code 환경 설정
     - [PlantUML extension for Visual Studio Code on Windows only working with sequence diagrams](https://stackoverflow.com/questions/53856294/plantuml-extension-for-visual-studio-code-on-windows-only-working-with-sequence)

     ```config
     {
         "plantuml.commandArgs": [
             "-DGRAPHVIZ_DOT=C:/Program Files (x86)/Graphviz2.38/bin/dot.exe"
         ]
     }  
     ```

   - 미리보기: Alt + D
