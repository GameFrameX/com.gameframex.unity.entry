﻿#if ENABLE_GAME_FRAME_X_FAIYGUI
using GameFrameX.FairyGUI.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取UI组件。
    /// </summary>
    public static FairyGUIComponent FUI
    {
        get
        {
            if (_fairyGUI == null)
            {
                _fairyGUI = GameEntry.GetComponent<FairyGUIComponent>();
            }

            return _fairyGUI;
        }
    }

    private static FairyGUIComponent _fairyGUI;


    /// <summary>
    /// 获取UI包管理组件。
    /// </summary>
    public static FairyGUIPackageComponent FUIPackage
    {
        get
        {
            if (_fUIPackage == null)
            {
                _fUIPackage = GameEntry.GetComponent<FairyGUIPackageComponent>();
            }

            return _fUIPackage;
        }
    }

    private static FairyGUIPackageComponent _fUIPackage;
}
#endif