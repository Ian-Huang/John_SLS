using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ModelAnimationController : MonoBehaviour
{
    public ModelData CurrentModelData;
    public List<ModelData> ModelDataList;

    private bool isPlaying;
    private Animator animator;
    public static ModelAnimationController script;

    void Awake()
    {
        script = this;
    }

    void Update()
    {
        if (isPlaying)
        {
            if (this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                print(this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
                switch ((int)this.animator.speed)
                {
                    case GameDefinition.Animation_NormalSpeed:
                        ModelAnimationController.script.RePlay((int)this.animator.speed);
                        MovieController.script.RePlayMovie(MovieController.MovieSpeedType.NormalSpeed);
                        break;
                    case GameDefinition.Animation_HalfSpeed:
                        ModelAnimationController.script.RePlay((int)this.animator.speed);
                        MovieController.script.RePlayMovie(MovieController.MovieSpeedType.HalfSpeed);
                        break;
                    case GameDefinition.Animation_QuaterSpeed:
                        ModelAnimationController.script.RePlay((int)this.animator.speed);
                        MovieController.script.RePlayMovie(MovieController.MovieSpeedType.QuaterSpeed);
                        break;
                }
            }
        }

    }

    // Use this for initialization
    void Start()
    {
        this.CurrentModelData = this.ModelDataList.Find((ModelData data) =>
         {
             if (data.ActionType == GameDefinition.ActionType)
             {
                 data.ModelObject.SetActive(true);
                 return true;
             }
             else
             {
                 data.ModelObject.SetActive(false);
                 return false;
             }
         });

        this.animator = this.CurrentModelData.ModelObject.GetComponent<Animator>();

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

    [System.Serializable]
    public class ModelData
    {
        public GameDefinition.PlayActionType ActionType;
        public GameObject ModelObject;
    }
}