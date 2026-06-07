<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Entry 入口组件

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## 项目简介

**Entry 入口组件** 是 Game Frame X 的核心入口点。它提供 `GameEntry` 单例和 `GameApp` 静态门面类，用于快速访问所有框架组件。

### GameApp 快捷调用

`GameApp` 是静态门面类，映射规则：`GameApp.{Name}` = `GameEntry.GetComponent<{Name}Component>()`。示例：

| GameApp | 等价调用 |
|---|---|
| `GameApp.Event` | `GameEntry.GetComponent<EventComponent>()` |
| `GameApp.UI` | `GameEntry.GetComponent<UIComponent>()` |
| `GameApp.Asset` | `GameEntry.GetComponent<AssetComponent>()` |

命名规律：属性名 = 组件名去掉 `Component` 后缀（特殊情况：`FUI`=`FairyGUIComponent`、`GUI`=`UGUIComponent`）。

## 快速开始

### 安装方式（任选其一）

1. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.entry": "https://github.com/AlianBlank/com.gameframex.unity.entry.git"
   }
   ```
2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/AlianBlank/com.gameframex.unity.entry.git`
3. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。

## 使用示例

```csharp
// 标准方式：通过 GameEntry（不依赖 com.gameframex.unity.entry）
var component = GameEntry.GetComponent<EventComponent>();

// 快捷方式：通过 GameApp（需要 com.gameframex.unity.entry）
GameApp.Event.Subscribe(eventId, handler);
```

## 文档与资源

- [文档](https://gameframex.doc.alianblank.com)

## 社区与支持

- QQ群: 467608841 / 233840761

## 更新日志

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.entry/releases) 了解更新日志。

## 开源协议

本项目基于 [MIT 协议](https://github.com/gameframex/com.gameframex.unity.entry/blob/main/LICENSE) 开源。
