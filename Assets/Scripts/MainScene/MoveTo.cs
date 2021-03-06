﻿using UnityEngine;
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

    }

    public void RunMoveTo(Vector3 target)
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("position", target, "time", this.MoveTime, "easetype", this.easeType));
    }

    public void RunMoveTo(MoveState state)
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

    // Update is called once per frame
    void Update()
    {

    }

    public enum MoveState
    {
        Run = 1, Back = 2
    }
}
