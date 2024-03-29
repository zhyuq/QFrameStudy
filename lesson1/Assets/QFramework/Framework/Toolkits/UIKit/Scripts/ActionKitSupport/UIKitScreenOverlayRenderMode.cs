﻿/****************************************************************************
 * Copyright (c) 2021.8 liangxiegame Under MIT Lisence
 * 
 * https://qframework.cn
 * https://github.com/liangxiegame/QFramework
 * https://gitee.com/liangxiegame/QFramework
 ****************************************************************************/

namespace QFramework
{
    [ActionGroup("UIKit")]
    public class UIKitScreenOverlayRenderMode : ActionKitVisualAction
    {
        protected override void OnBegin()
        {
            UIKit.Root.ScreenSpaceOverlayRenderMode();
            
            Finish();
        }
    }
}