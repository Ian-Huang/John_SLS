using UnityEngine;
using System.Collections;

public class SelectViewController : MonoBehaviour
{
    private MoveState CurrentState;

    public Vector3 StartPosition;
    public Vector3 TargetPosition;
    public float MoveTime;
    public iTween.EaseType easeType;

    public static SelectViewController script;

    void Awake()
    {
        script = this;
    }

    void Start()
    {
        this.CurrentState = MoveState.Back;
    }

    public void ShowSelectView()
    {
        if (this.CurrentState != MoveState.Run)
        {
            this.RunMoveTo(MoveState.Run);
            this.CurrentState = MoveState.Run;
        }
    }
    public void CloseSelectView()
    {
        if (this.CurrentState != MoveState.Back)
        {
            this.RunMoveTo(MoveState.Back);
            this.CurrentState = MoveState.Back;
        }
    }

    void RunMoveTo(Vector3 target)
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", target, "time", this.MoveTime, "easetype", this.easeType));
    }

    void RunMoveTo(MoveState state)
    {
        if (state == MoveState.Run)
        {
            this.transform.position = this.StartPosition;
            iTween.MoveTo(this.gameObject, iTween.Hash("position", this.TargetPosition, "time", this.MoveTime, "easetype", this.easeType));
        }
        else
        {
            this.transform.position = this.TargetPosition;
            iTween.MoveTo(this.gameObject, iTween.Hash("position", this.StartPosition, "time", this.MoveTime, "easetype", this.easeType));
        }
    }

    public enum MoveState
    {
        Run = 1, Back = 2
    }
}