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
                GameDefinition.ActionType = GameDefinition.PlayActionType.足內側向上踢;
                Application.LoadLevel("MainScene");
                break;
            case GameDefinition.ButtonEvent.足背向上踢:
                GameDefinition.ActionType = GameDefinition.PlayActionType.足背向上踢;
                Application.LoadLevel("MainScene");
                break;
            case GameDefinition.ButtonEvent.足內側發球:
                GameDefinition.ActionType = GameDefinition.PlayActionType.足內側發球;
                Application.LoadLevel("MainScene");
                break;
            case GameDefinition.ButtonEvent.足背高腳掃踢發球:
                GameDefinition.ActionType = GameDefinition.PlayActionType.足背高腳掃踢發球;
                Application.LoadLevel("MainScene");
                break;
            case GameDefinition.ButtonEvent.下壓攻踢:
                GameDefinition.ActionType = GameDefinition.PlayActionType.下壓攻踢;
                Application.LoadLevel("MainScene");
                break;
            case GameDefinition.ButtonEvent.倒鉤攻踢:
                GameDefinition.ActionType = GameDefinition.PlayActionType.倒鉤攻踢;
                Application.LoadLevel("MainScene");
                break;
            case GameDefinition.ButtonEvent.PreviousPage:
                SelectActionManager.script.PreviousPage();
                break;
            case GameDefinition.ButtonEvent.NextPage:
                SelectActionManager.script.NextPage();
                break;
            case GameDefinition.ButtonEvent.GoHomeScene:
                Application.LoadLevel("Home");
                break;
            case GameDefinition.ButtonEvent.NormalSpeed:
                ModelAnimationController.script.SetAnimationSpeed(GameDefinition.Animation_NormalSpeed);
                MovieController.script.ChangeMovieTexture(MovieController.MovieSpeedType.NormalSpeed);
                break;
            case GameDefinition.ButtonEvent.HalfSpeed:
                ModelAnimationController.script.SetAnimationSpeed(GameDefinition.Animation_HalfSpeed);
                MovieController.script.ChangeMovieTexture(MovieController.MovieSpeedType.HalfSpeed);
                break;
            case GameDefinition.ButtonEvent.QuaterSpeed:
                ModelAnimationController.script.SetAnimationSpeed(GameDefinition.Animation_QuaterSpeed);
                MovieController.script.ChangeMovieTexture(MovieController.MovieSpeedType.QuaterSpeed);
                break;
            case GameDefinition.ButtonEvent.ShowSelectView:
                SelectViewController.script.ShowSelectView();
                break;
            case GameDefinition.ButtonEvent.CloseSelectView:
                SelectViewController.script.CloseSelectView();
                break;
            case GameDefinition.ButtonEvent.PlayAnimation:
                ModelAnimationController.script.Play(false);
                MovieController.script.PlayMovie(false);
                break;
            case GameDefinition.ButtonEvent.StopAnimation:
                ModelAnimationController.script.Stop();
                MovieController.script.StopMovie();
                break;
            case GameDefinition.ButtonEvent.RePlayAnimation:
                ModelAnimationController.script.RePlay();
                MovieController.script.RePlayMovie();
                break;
            case GameDefinition.ButtonEvent.ZoomIn:
                AnimationCameraMoveController.script.CameraZoomIn();
                break;
            case GameDefinition.ButtonEvent.ZoomOut:
                AnimationCameraMoveController.script.CameraZoomOut();
                break;
            case GameDefinition.ButtonEvent.動畫側視圖:
                RightCameraController.script.ChangeRightCameraView(RightCameraController.ViewType.動畫側視圖);
                break;
            case GameDefinition.ButtonEvent.動畫正視圖:
                RightCameraController.script.ChangeRightCameraView(RightCameraController.ViewType.動畫正視圖);
                break;
            case GameDefinition.ButtonEvent.動畫透視圖:
                RightCameraController.script.ChangeRightCameraView(RightCameraController.ViewType.動畫透視圖);
                break;
            case GameDefinition.ButtonEvent.影片側視圖:
                RightCameraController.script.ChangeRightCameraView(RightCameraController.ViewType.影片側視圖);
                MovieController.script.ChangeMovieTexture(MovieController.MovieDirectionType.Side);
                break;
            case GameDefinition.ButtonEvent.影片正視圖:
                RightCameraController.script.ChangeRightCameraView(RightCameraController.ViewType.影片正視圖);
                MovieController.script.ChangeMovieTexture(MovieController.MovieDirectionType.Front);
                break;
            case GameDefinition.ButtonEvent.上轉:
                AnimationCameraRotateController.script.CameraRotateUp();
                break;
            case GameDefinition.ButtonEvent.下轉:
                AnimationCameraRotateController.script.CameraRotateDown();
                break;
            case GameDefinition.ButtonEvent.左轉:
                AnimationCameraRotateController.script.CameraRotateLeft();
                break;
            case GameDefinition.ButtonEvent.右轉:
                AnimationCameraRotateController.script.CameraRotateRight();
                break;
            default:
                break;
        }
    }
}