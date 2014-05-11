using UnityEngine;
using System.Collections;

public class AnimationCameraController : MonoBehaviour
{
    public Vector3 ZoomInPosition;
    public Vector3 OriginPosition;
    public Vector3 ZoomOutPosition;

    public float MoveTime;
    public iTween.EaseType easeType;
    public Transform looktarget;

    // Use this for initialization
    void Start()
    {
        //iTween.MoveTo(this.gameObject, iTween.Hash("z", -10, "time", this.MoveTime, "looktarget", this.looktarget, "easetype", this.easeType));
    }

    // Update is called once per frame
    void Update()
    {
        // transform.LookAt(looktarget);
    }

    void CameraPositionMove()
    {

    }

    public enum CameraPosition
    {
        ZoomIn = 1, Normal = 2, ZoomOut = 3
    }
}
