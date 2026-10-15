## [2.0.2](https://github.com/gameframex/com.gameframex.unity.entry/compare/2.0.1...2.0.2) (2026-10-15)


### Bug Fixes

* **dependencies:** asset 依赖升至 5.0.0 ([68cdd87](https://github.com/gameframex/com.gameframex.unity.entry/commit/68cdd877f1dc1d611c1121c8a7fef0254371ef64))

## [2.0.1](https://github.com/gameframex/com.gameframex.unity.entry/compare/2.0.0...2.0.1) (2026-10-15)


### Bug Fixes

* **dependencies:** 对齐依赖至实际发布版本 ([0b42705](https://github.com/gameframex/com.gameframex.unity.entry/commit/0b42705a1b2a3873ba9a2455416033f9269cada9))

# [2.0.0](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.3.2...2.0.0) (2026-10-15)


* feat(entry)!: GameApp 核心访问器改为模块接口直达 ([945384f](https://github.com/gameframex/com.gameframex.unity.entry/commit/945384f06c572f37fed785ad59b9ec103c7bccc8))


### Features

* **entry:** 登录访问面收敛为单一 GameApp.Login ([be3171c](https://github.com/gameframex/com.gameframex.unity.entry/commit/be3171c60b66bc7a95239dd915cd926604dcbd87))


### BREAKING CHANGES

* GameApp 六个访问器返回类型由组件改为模块接口。

## [Unreleased]

### ⚠ BREAKING CHANGES

* **entry:** `GameApp` 六个访问器（`Timer` / `Event` / `Fsm` / `Mono` / `Config` / `ObjectPool`）返回类型由组件改为模块接口，取值改经 `GameFrameworkEntry.GetModule<T>()` 直达

**访问器迁移对照：**

| 旧访问器 | 新访问器 |
|---|---|
| `GameApp.Timer`（`TimerComponent`） | `GameApp.Timer`（`ITimerManager`） |
| `GameApp.Event`（`EventComponent`） | `GameApp.Event`（`IEventManager`） |
| `GameApp.Fsm`（`FsmComponent`） | `GameApp.Fsm`（`IFsmManager`） |
| `GameApp.Mono`（`MonoComponent`） | `GameApp.Mono`（`IMonoManager`） |
| `GameApp.Config`（`ConfigComponent`） | `GameApp.Config`（`IConfigManager`） |
| `GameApp.ObjectPool`（`ObjectPoolComponent`） | `GameApp.ObjectPool`（`IObjectPoolManager`） |

### Features

* **entry:** 新增会话感知模块缓存（`GameAppModuleCache<TModule>`）：以 `GameFrameworkEntry.SessionVersion` 检测会话重建，`Shutdown` 后访问器自动重新解析模块实例，无需手动清缓存
* **entry:** 新增 Tests 程序集（`GameFrameX.Entry.Tests`），覆盖访问器会话重解析行为

## [1.3.2](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.3.1...1.3.2) (2026-09-13)


### Bug Fixes

* **entry:** 触发补丁版本发布 ([962b2ad](https://github.com/gameframex/com.gameframex.unity.entry/commit/962b2ad2789b5c9c679b93f09c4ed1e9391d3d16))

## [1.3.1](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.3.0...1.3.1) (2026-07-22)


### Bug Fixes

* **entry:** 升级依赖版本并移除 fairygui 依赖 ([b9d469b](https://github.com/gameframex/com.gameframex.unity.entry/commit/b9d469b17ac290830f3def2556ac53efae9b8c04))

# [1.3.0](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.2.2...1.3.0) (2026-07-03)


### Features

* **entry:** 移除 GameApp.FairyGUI 快捷访问扩展 ([7012d29](https://github.com/gameframex/com.gameframex.unity.entry/commit/7012d296ebf8108d728b7c09751e555dc7ee2f1d))
* **entry:** 移除 GameApp.ShareSDK 快捷访问扩展 ([1815679](https://github.com/gameframex/com.gameframex.unity.entry/commit/1815679d5eb04bbce3cbf2ccbb3729581782188b))

## [1.2.2](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.2.1...1.2.2) (2026-06-07)


### Bug Fixes

* 补全包规范文件（LICENSE/CHANGELOG/URL 字段/unity 字段） ([142ffe6](https://github.com/gameframex/com.gameframex.unity.entry/commit/142ffe61a633f3550d4937cc336929c66871b4f9))

## [1.2.1](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.2.0...1.2.1) (2026-05-28)


### Bug Fixes

* **ci:** 统一 .github 工作流配置 ([d0dba22](https://github.com/gameframex/com.gameframex.unity.entry/commit/d0dba22feab6516beb95b2264058d541146d036e))
* **deps:** 补充 package.json 中缺失的包依赖 ([8009592](https://github.com/gameframex/com.gameframex.unity.entry/commit/80095922435af9bfec05d0159727968361d90e1b))

# [1.2.0](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.1.0...1.2.0) (2026-03-05)


### Features

* **GUI:** 添加UGUI组件支持到GameApp ([a91b270](https://github.com/gameframex/com.gameframex.unity.entry/commit/a91b270ae4c4099ad8ddb40e2a119dc4bd7fbc44))

# [1.1.0](https://github.com/gameframex/com.gameframex.unity.entry/compare/1.0.6...1.1.0) (2025-12-23)


### Features

* **ci:** change ci ([b73e941](https://github.com/gameframex/com.gameframex.unity.entry/commit/b73e941b8b760d54c5fbf740f46c219ddec6ba49))
* **ci:** change ci ([041f5d5](https://github.com/gameframex/com.gameframex.unity.entry/commit/041f5d52426af445e57ad157297988080129990b))
* **ShareSDK:** 添加MobShareSDK组件支持 ([d890c89](https://github.com/gameframex/com.gameframex.unity.entry/commit/d890c89e5bbf56eb8ccbd6c1af23978d493aacde))
* **Web:** 添加Web ProtoBuff组件支持 ([76893d9](https://github.com/gameframex/com.gameframex.unity.entry/commit/76893d9f17c709d135cc7f4c156f59bb11b68431))

# Changelog

## [1.0.5](https://github.com/GameFrameX/com.gameframex.unity.entry/tree/1.0.5) (2025-05-31)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.entry/compare/1.0.4...1.0.5)

## [1.0.4](https://github.com/GameFrameX/com.gameframex.unity.entry/tree/1.0.4) (2025-05-19)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.entry/compare/1.0.3...1.0.4)

## [1.0.3](https://github.com/GameFrameX/com.gameframex.unity.entry/tree/1.0.3) (2024-10-12)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.entry/compare/1.0.2...1.0.3)

## [1.0.2](https://github.com/GameFrameX/com.gameframex.unity.entry/tree/1.0.2) (2024-09-26)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.entry/compare/45e5cdf267e84ce20bd5acf961a2f73cefb6deba...1.0.2)



\* *This Changelog was automatically generated by [github_changelog_generator](https://github.com/github-changelog-generator/github-changelog-generator)*
