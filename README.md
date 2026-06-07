<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Entry Component

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Project Overview

The **Entry Component** is the core entry point of Game Frame X. It provides the `GameEntry` singleton and the `GameApp` static facade class for quick access to all framework components.

### GameApp Shortcut

`GameApp` is a static facade class that maps `GameApp.{Name}` to `GameEntry.GetComponent<{Name}Component>()`. Examples:

| GameApp | Equivalent |
|---|---|
| `GameApp.Event` | `GameEntry.GetComponent<EventComponent>()` |
| `GameApp.UI` | `GameEntry.GetComponent<UIComponent>()` |
| `GameApp.Asset` | `GameEntry.GetComponent<AssetComponent>()` |

Naming convention: property name = component name without the `Component` suffix (special cases: `FUI` = `FairyGUIComponent`, `GUI` = `UGUIComponent`).

## Quick Start

### Installation

Choose one of the following methods:

1. Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:
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

   `scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

2. Add to `manifest.json` dependencies:
   ```json
   {
      "com.gameframex.unity.entry": "https://github.com/gameframex/com.gameframex.unity.entry.git"
   }
   ```
3. Use **Package Manager** in Unity with **Git URL**: `https://github.com/gameframex/com.gameframex.unity.entry.git`
4. Clone the repository into your Unity project's `Packages` directory. It will be loaded automatically.
## Usage Examples

```csharp
// Standard: via GameEntry (no dependency on com.gameframex.unity.entry)
var component = GameEntry.GetComponent<EventComponent>();

// Shortcut: via GameApp (requires com.gameframex.unity.entry)
GameApp.Event.Subscribe(eventId, handler);
```

## Documentation & Resources

- [Documentation](https://gameframex.doc.alianblank.com)

## Community & Support

- QQ Group: 467608841 / 233840761

## Changelog

See [Releases](https://github.com/gameframex/com.gameframex.unity.entry/releases) for changelog.


## Dependencies

| Package | Description |
|---------|-------------|
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
## License

See [LICENSE.md](LICENSE.md) for license information.
