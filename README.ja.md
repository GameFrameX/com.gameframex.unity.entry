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

### インストール方法（いずれかを選択）

1. `manifest.json` の `dependencies` に以下を追加：
   ```json
   {
      "com.gameframex.unity.entry": "https://github.com/AlianBlank/com.gameframex.unity.entry.git"
   }
   ```
2. Unity の `Packages Manager` で `Git URL` を使用して追加：`https://github.com/AlianBlank/com.gameframex.unity.entry.git`
3. リポジトリを直接ダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置すると、自動的に読み込まれます。

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

## ライセンス

このプロジェクトは [MIT ライセンス](https://github.com/gameframex/com.gameframex.unity.entry/blob/main/LICENSE) の下で公開されています。
