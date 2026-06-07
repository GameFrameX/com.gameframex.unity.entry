<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Entry エントリコンポーネント

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.entry)](https://github.com/GameFrameX/com.gameframex.unity.entry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

**Entry エントリコンポーネント** は Game Frame X のコアエントリポイントです。`GameEntry` シングルトンと `GameApp` 静的ファサードクラスを提供し、すべてのフレームワークコンポーネントに素早くアクセスできます。

### GameApp ショートカット

`GameApp` は静的ファサードクラスで、`GameApp.{Name}` を `GameEntry.GetComponent<{Name}Component>()` にマッピングします。例：

| GameApp | 等価な呼び出し |
|---|---|
| `GameApp.Event` | `GameEntry.GetComponent<EventComponent>()` |
| `GameApp.UI` | `GameEntry.GetComponent<UIComponent>()` |
| `GameApp.Asset` | `GameEntry.GetComponent<AssetComponent>()` |

命名規則：プロパティ名 = コンポーネント名から `Component` サフィックスを削除（特殊ケース：`FUI`=`FairyGUIComponent`、`GUI`=`UGUIComponent`）。

## クイックスタート

### インストール

Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：

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

`scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.entry": "1.2.1"
  }
}
```

## 使用例

```csharp
// 標準: GameEntry 経由（com.gameframex.unity.entry 非依存）
var component = GameEntry.GetComponent<EventComponent>();

// ショートカット: GameApp 経由（com.gameframex.unity.entry が必要）
GameApp.Event.Subscribe(eventId, handler);
```

## ドキュメントとリソース

- [ドキュメント](https://gameframex.doc.alianblank.com)

## コミュニティとサポート

- QQグループ: 467608841 / 233840761

## 変更履歴

変更履歴は [Releases](https://github.com/gameframex/com.gameframex.unity.entry/releases) をご覧ください。


## 依存関係

| パッケージ | 説明 |
|----------|------|
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
## ライセンス

詳しくは [LICENSE.md](LICENSE.md) をご参照ください。
