<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Entry 入口組件

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

**Entry 入口組件** 是 Game Frame X 的核心入口點。它提供 `GameEntry` 單例和 `GameApp` 靜態門面類別，用於快速存取所有框架組件。

### GameApp 快捷呼叫

`GameApp` 是靜態門面類別，映射規則：`GameApp.{Name}` = `GameEntry.GetComponent<{Name}Component>()`。示例：

| GameApp | 等價呼叫 |
|---|---|
| `GameApp.Event` | `GameEntry.GetComponent<EventComponent>()` |
| `GameApp.UI` | `GameEntry.GetComponent<UIComponent>()` |
| `GameApp.Asset` | `GameEntry.GetComponent<AssetComponent>()` |

命名規律：屬性名 = 組件名去掉 `Component` 後綴（特殊情況：`FUI`=`FairyGUIComponent`、`GUI`=`UGUIComponent`）。

## 快速開始

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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
  ]
}
```

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.entry": "1.2.1"
  }
}
```

## 使用範例

```csharp
// 標準方式：透過 GameEntry（不依賴 com.gameframex.unity.entry）
var component = GameEntry.GetComponent<EventComponent>();

// 快捷方式：透過 GameApp（需要 com.gameframex.unity.entry）
GameApp.Event.Subscribe(eventId, handler);
```

## 文檔與資源

- [文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

- QQ群: 467608841 / 233840761

## 更新日誌

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.entry/releases) 了解更新日誌。


## 依賴

| 套件 | 說明 |
|------|------|
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
## 開源協議

詳見 [LICENSE.md](LICENSE.md) 檔案。
