using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{
    public Vector3 StartPosition;
    public Vector3 TargetPosition;
    public float MoveTime;
    public iTween.EaseType easeType;

    // Use this for initialization
    void Start()
    {
        this.RunMoveTo();
    }

    void RunMoveTo()
    {
        this.transform.position = this.StartPosition;
        iTween.MoveTo(this.gameObject, iTween.Hash("position", this.TargetPosition, "time", this.MoveTime, "easetype", this.easeType));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
