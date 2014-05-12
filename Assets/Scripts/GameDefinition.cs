using UnityEngine;
using System.Collections;

public class GameDefinition
{
    public const int Animation_NormalSpeed = 4;
    public const int Animation_HalfSpeed = 2;
    public const int Animation_QuaterSpeed = 1;

    public enum ButtonEvent
    {
        None = -1,
        Start_Home = 0, Exit_Home = 1,
        足內側向上踢 = 2, 足背向上踢 = 3, 足內側發球 = 4, 足背高腳掃踢發球 = 5, 下壓攻踢 = 6, 倒鉤攻踢 = 7,
        PreviousPage = 8, NextPage = 9,
        GoHomeScene = 10,
        NormalSpeed = 11, HalfSpeed = 12, QuaterSpeed = 13,
        ShowSelectView = 14, CloseSelectView = 20,
        PlayAnimation = 15, StopAnimation = 16, RePlayAnimation = 17,
        ZoomIn = 18, ZoomOut = 19,
        動畫側視圖 = 21, 動畫正視圖 = 22, 動畫透視圖 = 23, 影片側視圖 = 24, 影片正視圖 = 25,
        上轉 = 26, 下轉 = 27, 左轉 = 28, 右轉 = 29
    }

    public enum SpeakInstruction
    {
        放大 = 0, 縮小 = 1,
        重播 = 2, 停止 = 3, 播放 = 4, 暫停 = 5,
        二分之一速 = 6, 四分之一速 = 7,
        切換視角 = 8, 取消 = 19,
        離開 = 9,
        動畫側視圖 = 10, 動畫正視圖 = 11, 動畫透視圖 = 12, 影片側視圖 = 13, 影片正視圖 = 14,
        上轉 = 15, 下轉 = 16, 左轉 = 17, 右轉 = 18
    }
}