﻿using UnityEngine;
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
            case GameDefinition.ButtonEvent.GoHomeScene:
                Application.LoadLevel("Home");
                break;
            case GameDefinition.ButtonEvent.NormalSpeed:
                ModelAnimationController.script.SetAnimationSpeed(GameDefinition.Animation_NormalSpeed);
                break;
            case GameDefinition.ButtonEvent.HalfSpeed:
                ModelAnimationController.script.SetAnimationSpeed(GameDefinition.Animation_HalfSpeed);
                break;
            case GameDefinition.ButtonEvent.QuaterSpeed:
                ModelAnimationController.script.SetAnimationSpeed(GameDefinition.Animation_QuaterSpeed);
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
                break;
            case GameDefinition.ButtonEvent.影片正視圖:
                RightCameraController.script.ChangeRightCameraView(RightCameraController.ViewType.影片正視圖);
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