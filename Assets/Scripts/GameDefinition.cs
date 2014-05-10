using UnityEngine;
using System.Collections;

public class GameDefinition
{
    public enum ButtonEvent
    {
        Start_Home = 0, Exit_Home = 1,
        足內側向上踢 = 2, 足背向上踢 = 3, 足內側發球 = 4, 足背高腳掃踢發球 = 5, 下壓攻踢 = 6, 倒鉤攻踢 = 7,
        PreviousPage = 8, NextPage = 9
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