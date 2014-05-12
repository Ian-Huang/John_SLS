using UnityEngine;
using System.Collections;

public class AnimationCameraRotateController : MonoBehaviour
{
    public float MinX_Angle;
    public float MaxX_Angle;
    public float RotateScale;

    public float MoveTime;
    public iTween.EaseType easeType;
    public Transform looktarget;

    public static AnimationCameraRotateController script;

    void Awake()
    {
        script = this;
    }
    
    public void CameraRotateUp()
    {
        float temp;
        if (this.transform.eulerAngles.x > 180)
            temp = this.transform.eulerAngles.x - 360 - this.RotateScale;
        else
            temp = this.transform.eulerAngles.x - this.RotateScale;
        print(temp);
        if (temp >= this.MinX_Angle)
            iTween.RotateTo(this.gameObject, iTween.Hash("x", temp, "time", this.MoveTime, "easetype", this.easeType));
    }

    public void CameraRotateDown()
    {
        float temp;
        if (this.transform.eulerAngles.x > 180)
            temp = this.transform.eulerAngles.x - 360 + this.RotateScale;
        else
            temp = this.transform.eulerAngles.x + this.RotateScale;
        print(temp);
        if (temp < this.MaxX_Angle)
            iTween.RotateTo(this.gameObject, iTween.Hash("x", temp, "time", this.MoveTime, "easetype", this.easeType));
    }

    public void CameraRotateRight()
    {
        iTween.RotateTo(this.gameObject, iTween.Hash("y", this.transform.eulerAngles.y - this.RotateScale, "time", this.MoveTime, "easetype", this.easeType));
    }

    public void CameraRotateLeft()
    {
        iTween.RotateTo(this.gameObject, iTween.Hash("y", this.transform.eulerAngles.y + this.RotateScale, "time", this.MoveTime, "easetype", this.easeType));
    }

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(100, 50, 50, 50), "上"))
    //    {
    //        this.CameraRotateUp();
    //    }
    //    if (GUI.Button(new Rect(100, 150, 50, 50), "下"))
    //    {
    //        this.CameraRotateDown();
    //    }
    //    if (GUI.Button(new Rect(50, 100, 50, 50), "左"))
    //    {
    //        this.CameraRotateLeft();

    //    }
    //    if (GUI.Button(new Rect(150, 100, 50, 50), "右"))
    //    {
    //        this.CameraRotateRight();
    //    }
    //}
}
