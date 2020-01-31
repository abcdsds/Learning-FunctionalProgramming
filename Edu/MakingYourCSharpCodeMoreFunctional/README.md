# More Functional

## VS Code 확장 도구 설치

### C# 언어

1. Auto-Using for C#
1. C# FixFormat??

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

2. PlantUML
   - [PlantUML](https://github.com/qjebbs/vscode-plantuml) 설치
   - [Graphviz](https://graphviz.gitlab.io/_pages/Download/Download_windows.html) 다운로드 및 설치
   - VS Code 환경 설정
     - [PlantUML extension for Visual Studio Code on Windows only working with sequence diagrams](https://stackoverflow.com/questions/53856294/plantuml-extension-for-visual-studio-code-on-windows-only-working-with-sequence)

     ```config
     {
         "plantuml.commandArgs": [
             "-DGRAPHVIZ_DOT=C:/Program Files (x86)/Graphviz2.38/bin/dot.exe"
         ],
         "files.exclude": {
             "**/obj": true
         }
     }  
     ```

   - 미리보기: Alt + D
