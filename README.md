# 해커그라운드 Blazor 부트캠프

해커그라운드 Blazor 앱 만들기 부트캠프에 오신 것을 환영합니다! [Blazor](https://blazor.net)는 .NET과 웹어셈블리를 이용하여 클라이언트 웹 앱을 만들기 위한 단일 페이지 앱 프레임워크입니다. 이 워크샵에서 여러분은 C# 기반 Blazor 프레임워크를 배우면서 피자 주문 웹앱 만들기를 진행합니다.

![Blazing Pizza](https://user-images.githubusercontent.com/1874516/77244515-c889ce00-6bd2-11ea-9a45-47452c084464.png)

## 갓벽한 부트캠프 함께하기

원하는 경로에 현재 레포지토리를 복사하고

```bash
$ git clone https://github.com/hackersground-kr/blazor-workshop-prototype.git
```

[첫 세션을 시작](/docs/00-get-started.md)해보세요!

## 세션(Sessions)

| 세션                                                                      | 내용                        |
| ------------------------------------------------------------------------- | --------------------------- |
| [세션 #0](/docs/00-get-started.md)                                        | 시작하기                    |
| [세션 #1](/docs/01-components-and-layout.md)                              | 컴포넌트와 레이아웃         |
| [세션 #2](/docs/02-customize-a-pizza.md)                                  | 내 피자 만들기              |
| [세션 #3](/docs/03-show-order-status.md)                                  | 주문 상태 표시하기          |
| [세션 #4](/docs/04-refactor-state-management.md)                          | 상태 관리의 리펙터링        |
| [세션 #5](/docs/05-checkout-with-validation.md)                           | 입력값 확인                 |
| [세션 #6](/docs/06-authentication-and-authorization.md)                   | 인증                        |
| [세션 #7](/docs/07-javascript-interop.md)                                 | 자바스크립트 상호운용성     |
| [세션 #8](/docs/08-templated-components.md)                               | 템플릿 컴포넌트             |
| [세션 #9](/docs/09-progressive-web-app.md)                                | 프로그레시브 웹앱(PWA) 기능 |
| [세션 #10](/docs/10-publish-and-deploy.md)                                | 게시 및 배포                |
| [더 공부하기](/edu-matarials/Blazor-for-ASP-NET-Web-Forms-Developers.pdf) | Blazor pdf로 공부하기       |

## 시작하기

다음 세션 - [첫 세션 시작하기](/docs/00-get-started.md)

[해커스그라운드 깃헙](https://github.com/hackersground-kr/blazor-workshop-prototype/blob/ko/docs/00-get-started.md)

# Blazor 란?

[Blazor 란?](https://learn.microsoft.com/ko-kr/training/modules/blazor-introduction/2-what-is-blazor)

Blazor는 애플리케이션을 빌드하는 데 사용할 수 있는 .NET용 사용자 인터페이스 프레임워크입니다.
Blazor는 .NET 및 Razor를 기반으로 하는 사용자 인터페이스 프레임워크입니다.

## .NET이란?

.NET는 데스크톱, 모바일 디바이스, 클라우드 및 IoT 장치용 애플리케이션을 개발하고 배포하기 위한 완벽한 에코시스템입니다.

## Razor란?

Razor는 HTML과 같은 텍스트 기반 콘텐츠를 생성하는 형식입니다. Razor 파일은 cshtml 또는 razor 파일 확장명을 가지며 HTML과 함께 C# 코드를 혼합하여 포함합니다.

# 설치

## C# Dev Kit 익스텐션 설치하기

## .NET SDK 7.0 설치하기

https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/install

## The template "Blazor Server App" 생성하기

`dotnet`

설치 성공 확인을 합니다.

`dotnet new blazorserver -o BlazorApp --no-https -f net7.0`

이 명령은 새 Blazor 앱 프로젝트를 만들고 현재 위치 내의 BlazorApp라는 새 디렉터리에 배치합니다.

`cd BlazorApp`

이전 명령으로 만든 새 BlazorApp 디렉터리로 이동합니다.

`dotnet watch`

dotnet watch 명령은 앱을 빌드 및 시작한 다음 코드를 변경할 때마다 앱을 업데이트합니다.
첫 번째 Blazor 앱을 성공적으로 실행되었습니다.

- [블레이저 앱의 프로젝트 구조](https://learn.microsoft.com/ko-kr/dotnet/architecture/blazor-for-web-forms-developers/project-structure)

- [블레이저 Razor 파일에 대해 알아보자](https://learn.microsoft.com/ko-kr/dotnet/architecture/blazor-for-web-forms-developers/components)
  UI 구성 요소에서 구성 요소 상태로 양방향 데이터 바인딩을 만들려면 @bind 지시문 특성을 사용합니다.
  Blazor 코드 내에서 @ 는 c# 과 바인딩 시켜주는 역할으로 리엑트처럼 한 공간 안에서 html javascript c# 을 한번에 쉽게 불러와 사용할수가 있습니다.

`dotnet dev-certs https --trust`

개발에서 HTTPS를 사용할 수 있도록 자체 서명된 인증서를 생성합니다.
가상으로 인증서를 만들어서 신뢰하게 해줍니다.

https://learn.microsoft.com/ko-kr/dotnet/core/tools/dotnet-dev-certs

서버를 열기위해 해당 파일 경로로 cd 이동 한 후 dotnet watch 를 실행 시켜줍니다.

수정 후 terminal 에서 `ctl + R `으로 재실행 하면 화면에 반영됩니다.
