using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    public GameDefinition.ButtonEvent buttonEvent;

    void OnMouseUpAsButton()
    {
        switch (this.buttonEvent)
        {
            case GameDefinition.ButtonEvent.Start_Home:
                Application.LoadLevel("SelectAction");
                break;
            case GameDefinition.ButtonEvent.Exit_Home:
                Application.Quit();
                break;
            case GameDefinition.ButtonEvent.足內側向上踢:
            case GameDefinition.ButtonEvent.足背向上踢:
            case GameDefinition.ButtonEvent.足內側發球:
            case GameDefinition.ButtonEvent.足背高腳掃踢發球:
            case GameDefinition.ButtonEvent.下壓攻踢:
            case GameDefinition.ButtonEvent.倒鉤攻踢:
                print(this.buttonEvent);
                Application.LoadLevel("MainScene");
                break;
            case GameDefinition.ButtonEvent.PreviousPage:
                SelectActionManager.script.PreviousPage();
                break;
            case GameDefinition.ButtonEvent.NextPage:
                SelectActionManager.script.NextPage();
                break;
            default:
                break;
        }
    }
}