<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X Entry 入口組件

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.entry)](https://github.com/gameframex/com.gameframex.unity.entry/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.entry)](https://github.com/gameframex/com.gameframex.unity.entry/releases)
[![Documentation](https://img.shields.io/badge/Documentation-文檔-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · [QQ群](https://qm.qq.com/q/5kbDVBdUeS) · **語言**

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

---

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

### 安裝方式（任選其一）

1. 直接在 `manifest.json` 的 `dependencies` 節點下新增以下內容：
   ```json
   {
      "com.gameframex.unity.entry": "https://github.com/AlianBlank/com.gameframex.unity.entry.git"
   }
   ```
2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式新增庫，地址為：`https://github.com/AlianBlank/com.gameframex.unity.entry.git`
3. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動載入識別。

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

- [QQ群](https://qm.qq.com/q/5kbDVBdUeS)

## 更新日誌

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.entry/releases) 了解更新日誌。

## 開源協議

本專案基於 [MIT 協議](https://github.com/gameframex/com.gameframex.unity.entry/blob/main/LICENSE) 開源。
