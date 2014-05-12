using UnityEngine;
using System.Collections;

public class AnimationCameraMoveController : MonoBehaviour
{
    public float MinZ;
    public float MaxZ;
    public float MoveDistance;

    public float MoveTime;
    public iTween.EaseType easeType;
    public Transform looktarget;

    public static AnimationCameraMoveController script;

    void Awake()
    {
        script = this;
    }

    public void CameraZoomIn()
    {
        float temp = this.transform.localPosition.z - this.MoveDistance;
        if (temp >= this.MinZ)
            iTween.MoveTo(this.gameObject, iTween.Hash("z", temp, "time", this.MoveTime, "islocal", true, "easetype", this.easeType));
    }

    public void CameraZoomOut()
    {
        float temp = this.transform.localPosition.z + this.MoveDistance;
        if (temp < this.MaxZ)
            iTween.MoveTo(this.gameObject, iTween.Hash("z", temp, "time", this.MoveTime, "islocal", true, "easetype", this.easeType));
    }
}
