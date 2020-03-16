- TODO OS Bit 확인하기
- Git 설치하기
  - https://git-scm.com/download/win
  - Windows 32bit일 때: Git-2.25.1-32-bit.exe
  - Windows 64bit일 때: Git-2.25.1-64-bit.exe
  - TODO 설치 옵션
- Go 설치 파일 다운로드
  - https://golang.org/dl/
  - Windows 32bit일 때: go1.14.windows-386.msi
  - Windows 64bit일 때: go1.14.windows-amd64.msi
- Go 설치하기
  - 설치 기본 경로: C:\Go
  - 설치 환경 변수: 
    - GOPATH: %USERPROFILE%\go
    - Path: ;%USERPROFILE%\go\bin
    - "%USERPROFILE%"는 계정 폴더이다. 예. C:\User\Hyungho.Ko
- Go 버전 확인하기
  ```shell
  C:\>go version
  go version go1.14 windows/amd64
  ```
- Go 환경 변수 확인하기
  ```shell
  C:\>go env
  set GOPATH=C:\Users\Hyungho.Ko\go
  set GOROOT=c:\go
  ```
- VS Code Go 확장 도구 설치하기
  - Go 
  - go-outline
    - The "go-outline" command is not available. Run "go get -v github.com/ramya-rao-a/go-outline" to install.
    ```
    go.toolsGopath setting is not set. Using GOPATH C:\Users\Hyungho.Ko\go
    Installing 1 tool at C:\Users\Hyungho.Ko\go\bin in module mode.
      go-outline

    Installing github.com/ramya-rao-a/go-outline SUCCEEDED

    All tools successfully installed. You are ready to Go :).
    ```
    The "gocode" command is not available. Run "go get -v github.com/mdempsky/gocode" to install.
    The "gopkgs" command is not available. Run "go get -v github.com/uudashr/gopkgs/v2/cmd/gopkgs" to install.
    The "goreturns" command is not available. Run "go get -v github.com/sqs/goreturns" to install.

- gocode 설치하기
```shell
PS C:\LearningGo> go get -v github.com/mdempsky/gocode
github.com/mdempsky/gocode (download)
get "golang.org/x/tools/go/gcexportdata": found meta tag get.metaImport{Prefix:"golang.org/x/tools", VCS:"git", RepoRoot:"https://go.googlesource.com/tools"} at //golang.org/x/tools/go/gcexportdata?go-get=1
get "golang.org/x/tools/go/gcexportdata": verifying non-authoritative meta tag
golang.org/x/tools (download)
github.com/mdempsky/gocode/internal/lookdot
golang.org/x/tools/go/internal/gcimporter
github.com/mdempsky/gocode/internal/suggest
golang.org/x/tools/go/gcexportdata
github.com/mdempsky/gocode/internal/cache
github.com/mdempsky/gocode/internal/gbimporter
github.com/mdempsky/gocode
```
- gopkgs 설치하기
```shell
PS C:\LearningGo> go get -v github.com/uudashr/gopkgs/v2/cmd/gopkgs
github.com/uudashr/gopkgs (download)
github.com/karrick/godirwalk (download)
github.com/pkg/errors (download)
github.com/pkg/errors
github.com/karrick/godirwalk
github.com/uudashr/gopkgs/v2
github.com/uudashr/gopkgs/v2/cmd/gopkgs
```
- go 설치하기
```shell
PS C:\LearningGo> go get -v github.com/sqs/goreturns
github.com/sqs/goreturns (download)
get "golang.org/x/mod/module": found meta tag get.metaImport{Prefix:"golang.org/x/mod", VCS:"git", RepoRoot:"https://go.googlesource.com/mod"} at //golang.org/x/mod/module?go-get=1
get "golang.org/x/mod/module": verifying non-authoritative meta tag
golang.org/x/mod (download)
get "golang.org/x/mod/semver": found meta tag get.metaImport{Prefix:"golang.org/x/mod", VCS:"git", RepoRoot:"https://go.googlesource.com/mod"} at //golang.org/x/mod/semver?go-get=1
get "golang.org/x/mod/semver": verifying non-authoritative meta tag
get "golang.org/x/xerrors": found meta tag get.metaImport{Prefix:"golang.org/x/xerrors", VCS:"git", RepoRoot:"https://go.googlesource.com/xerrors"} at //golang.org/x/xerrors?go-get=1
golang.org/x/xerrors (download)
golang.org/x/mod/semver
golang.org/x/xerrors/internal
golang.org/x/tools/go/ast/astutil
github.com/sqs/goreturns/returns
golang.org/x/tools/internal/gocommand
golang.org/x/xerrors
golang.org/x/tools/internal/fastwalk
golang.org/x/mod/module
golang.org/x/tools/internal/gopathwalk
golang.org/x/tools/internal/imports
golang.org/x/tools/imports
github.com/sqs/goreturns
```


PS C:\Repo_GitHub\Learning-FunctionalProgramming\Fundamentals\Golang\Lesson0> go get -v github.com/mdempsky/gocode
github.com/mdempsky/gocode (download)
go: missing Git command. See https://golang.org/s/gogetcmd
package github.com/mdempsky/gocode: exec: "git": executable file not found in %PATH%
PS C:\Repo_GitHub\Learning-FunctionalProgramming\Fundamentals\Golang\Lesson0> 
