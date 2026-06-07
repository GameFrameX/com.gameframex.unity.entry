<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Entry 엔트리 컴포넌트

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

**Entry 엔트리 컴포넌트** 는 Game Frame X의 핵심 진입점입니다. `GameEntry` 싱글톤과 `GameApp` 정적 파사드 클래스를 제공하여 모든 프레임워크 컴포넌트에 빠르게 접근할 수 있습니다.

### GameApp 단축 호출

`GameApp`은 정적 파사드 클래스로, `GameApp.{Name}`을 `GameEntry.GetComponent<{Name}Component>()`에 매핑합니다. 예시:

| GameApp | 동등한 호출 |
|---|---|
| `GameApp.Event` | `GameEntry.GetComponent<EventComponent>()` |
| `GameApp.UI` | `GameEntry.GetComponent<UIComponent>()` |
| `GameApp.Asset` | `GameEntry.GetComponent<AssetComponent>()` |

명명 규칙: 속성 이름 = 컴포넌트 이름에서 `Component` 접미사 제거 (특수 경우: `FUI`=`FairyGUIComponent`, `GUI`=`UGUIComponent`).

## 빠른 시작

### 설치

다음 방법 중 하나를 선택하세요:

1. Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.entry": "1.2.1"
     }
   }
   ```

   `scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

2. `manifest.json`의 `dependencies`에 직접 추가:
   ```json
   {
      "com.gameframex.unity.entry": "https://github.com/gameframex/com.gameframex.unity.entry.git"
   }
   ```
3. Unity의 **Package Manager**에서 **Git URL**을 사용하여 추가: `https://github.com/gameframex/com.gameframex.unity.entry.git`
4. 리포지토리를 Unity 프로젝트의 `Packages` 디렉토리에 클론하세요. 자동으로 로드됩니다.
## 사용 예시

```csharp
// 표준: GameEntry를 통해 (com.gameframex.unity.entry 비의존)
var component = GameEntry.GetComponent<EventComponent>();

// 단축: GameApp을 통해 (com.gameframex.unity.entry 필요)
GameApp.Event.Subscribe(eventId, handler);
```

## 문서 및 자료

- [문서](https://gameframex.doc.alianblank.com)

## 커뮤니티 및 지원

- QQ 그룹: 467608841 / 233840761

## 변경 로그

변경 로그는 [Releases](https://github.com/gameframex/com.gameframex.unity.entry/releases)에서 확인하세요.


## 의존성

| 패키지 | 설명 |
|--------|------|
| `com.gameframex.unity.asset` | 2.5.0 |
| `com.gameframex.unity.config` | 1.1.3 |
| `com.gameframex.unity.coroutine` | 1.0.1 |
| `com.gameframex.unity.download` | 1.1.0 |
| `com.gameframex.unity.entity` | 2.4.1 |
| `com.gameframex.unity.event` | 1.1.0 |
| `com.gameframex.unity.fsm` | 1.0.3 |
| `com.gameframex.unity.globalconfig` | 1.3.0 |
| `com.gameframex.unity.localization` | 2.2.1 |
| `com.gameframex.unity.mono` | 1.1.0 |
| `com.gameframex.unity.network` | 2.5.1 |
| `com.gameframex.unity.procedure` | 1.1.0 |
| `com.gameframex.unity.scene` | 2.2.0 |
| `com.gameframex.unity.setting` | 1.5.0 |
| `com.gameframex.unity.sound` | 1.1.1 |
| `com.gameframex.unity.timer` | 1.1.0 |
| `com.gameframex.unity.ui` | 2.10.0 |
| `com.gameframex.unity.ui.fairygui` | 3.3.0 |
| `com.gameframex.unity.web` | 1.3.3 |
| `com.gameframex.unity.web.protobuff` | 1.1.1 |
## 라이선스

자세한 내용은 [LICENSE.md](LICENSE.md) 파일을 참조하세요.
