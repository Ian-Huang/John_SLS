using UnityEngine;
using System.Collections;

public class ModelAnimationController : MonoBehaviour
{
    private bool isPlaying;
    private Animator animator;
    public static ModelAnimationController script;

    void Awake()
    {
        script = this;
    }

    // Use this for initialization
    void Start()
    {
        this.animator = this.GetComponent<Animator>();
        this.Stop();
    }

    public void SetAnimationSpeed(float speed)
    {
        this.animator.speed = speed;
    }

    /// <summary>
    /// 回到0，停止
    /// </summary>
    public void Stop(int speed = GameDefinition.Animation_NormalSpeed)
    {
        this.isPlaying = false;
        this.animator.StartPlayback();
        this.animator.Play("Action", 0, 0);
        this.SetAnimationSpeed(speed);
    }

    /// <summary>
    /// 暫停
    /// </summary>
    public void Pause()
    {
        this.animator.StartPlayback();
        this.isPlaying = false;
    }

    /// <summary>
    /// 播放or恢復播放
    /// </summary>
    /// <param name="isSpeak">是否來自語音指令</param>
    public void Play(bool isSpeak)
    {
        if (!isSpeak)
        {
            if (!this.isPlaying)
            {
                this.isPlaying = true;
                this.animator.StopPlayback();
            }
            else
            {
                this.isPlaying = false;
                this.animator.StartPlayback();
            }
        }
        else
        {
            this.animator.StopPlayback();
            this.isPlaying = true;
        }
    }

    /// <summary>
    /// 回到0，重新播放
    /// </summary>
    public void RePlay(int speed = GameDefinition.Animation_NormalSpeed)
    {
        this.isPlaying = true;
        this.animator.StopPlayback();
        this.animator.Play("Action", 0, 0);
        this.SetAnimationSpeed(speed);
    }

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(100, 100, 100, 100), "+"))
    //    {
    //        this.speed++;
    //        this.animator.speed = this.speed;
    //    }
    //    if (GUI.Button(new Rect(300, 100, 100, 100), "-"))
    //    {
    //        this.speed--;
    //        this.animator.speed = this.speed;

    //    }

    //    if (GUI.Button(new Rect(100, 300, 100, 100), "Play"))
    //    {

    //        this.animator.StopPlayback();

    //    }
    //    if (GUI.Button(new Rect(300, 300, 100, 100), "Stop"))
    //    {
    //        ////回到0 (重播)
    //        //this.animator.StartPlayback();
    //        this.animator.Play("Action",0,0);
    //        //不回到0 (停播)
    //        //this.animator.StartPlayback();
    //    }
    //}

}
