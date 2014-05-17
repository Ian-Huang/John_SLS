using UnityEngine;
using System.Collections;

public class AnimationCameraRotateController : MonoBehaviour
{
    public float MinX_Angle;
    public float MaxX_Angle;
    public float RotateScale;

    public float MoveTime;
    public iTween.EaseType easeType;

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
}