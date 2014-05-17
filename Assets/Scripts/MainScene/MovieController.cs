using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovieController : MonoBehaviour
{
    public MovieSpeedType CurrentSpeedType;
    public MovieDirectionType CurrentDirectionType;

    public MovieData Moviedata;
    public MovieTexture CurrentMovieTexture;
    public List<MovieData> MovieDataList;

    private bool isPlaying;

    public static MovieController script;

    void Awake()
    {
        script = this;
    }

    // Use this for initialization
    void Start()
    {
        this.Moviedata = this.MovieDataList.Find((MovieData data) => { if (data.ActionType == GameDefinition.ActionType) return true; else return false; });
        this.isPlaying = false;

        this.CurrentMovieTexture = this.Moviedata.NormalFrontMovie;
        this.CurrentMovieTexture.loop = GameDefinition.ActionLoop;

        this.renderer.material.mainTexture = this.CurrentMovieTexture;
    }

    /// <summary>
    /// 變換材質貼圖
    /// </summary>
    /// <param name="speedType">變換速度</param>
    public void ChangeMovieTexture(MovieSpeedType speedType)
    {
        //if (speedType == this.CurrentSpeedType)
        //    return;

        int speed = 0;
        this.CurrentMovieTexture.Stop();
        this.CurrentSpeedType = speedType;

        if (this.CurrentDirectionType == MovieDirectionType.Front)
        {
            switch (speedType)
            {
                case MovieSpeedType.NormalSpeed:
                    this.CurrentMovieTexture = this.Moviedata.NormalFrontMovie;
                    speed = GameDefinition.Animation_NormalSpeed;
                    break;
                case MovieSpeedType.HalfSpeed:
                    this.CurrentMovieTexture = this.Moviedata.HalfFrontMovie;
                    speed = GameDefinition.Animation_HalfSpeed;
                    break;
                case MovieSpeedType.QuaterSpeed:
                    this.CurrentMovieTexture = this.Moviedata.QuaterFrontMovie;
                    speed = GameDefinition.Animation_QuaterSpeed;
                    break;
            }
        }
        else
        {
            switch (speedType)
            {
                case MovieSpeedType.NormalSpeed:
                    this.CurrentMovieTexture = this.Moviedata.NormalSideMovie;
                    speed = GameDefinition.Animation_NormalSpeed;
                    break;
                case MovieSpeedType.HalfSpeed:
                    this.CurrentMovieTexture = this.Moviedata.HalfSideMovie;
                    speed = GameDefinition.Animation_HalfSpeed;
                    break;
                case MovieSpeedType.QuaterSpeed:
                    this.CurrentMovieTexture = this.Moviedata.QuaterSideMovie;
                    speed = GameDefinition.Animation_QuaterSpeed;
                    break;
            }
        }

        this.CurrentMovieTexture.loop = GameDefinition.ActionLoop;
        this.renderer.material.mainTexture = this.CurrentMovieTexture;

        if (this.isPlaying)
        {
            this.CurrentMovieTexture.Play();
            ModelAnimationController.script.RePlay(speed);
        }
        else
        {
            ModelAnimationController.script.Stop(speed);
        }
    }

    /// <summary>
    /// 變換材質貼圖
    /// </summary>
    /// <param name="DirectionType">變換視角</param>
    public void ChangeMovieTexture(MovieDirectionType DirectionType)
    {
        //if (DirectionType == this.CurrentDirectionType)
        //    return;

        int speed = 0;
        this.CurrentMovieTexture.Stop();
        this.CurrentDirectionType = DirectionType;

        if (CurrentDirectionType == MovieDirectionType.Front)
        {
            switch (this.CurrentSpeedType)
            {
                case MovieSpeedType.NormalSpeed:
                    this.CurrentMovieTexture = this.Moviedata.NormalFrontMovie;
                    speed = GameDefinition.Animation_NormalSpeed;
                    break;
                case MovieSpeedType.HalfSpeed:
                    this.CurrentMovieTexture = this.Moviedata.HalfFrontMovie;
                    speed = GameDefinition.Animation_HalfSpeed;
                    break;
                case MovieSpeedType.QuaterSpeed:
                    this.CurrentMovieTexture = this.Moviedata.QuaterFrontMovie;
                    speed = GameDefinition.Animation_QuaterSpeed;
                    break;
            }
        }
        else
        {
            switch (this.CurrentSpeedType)
            {
                case MovieSpeedType.NormalSpeed:
                    this.CurrentMovieTexture = this.Moviedata.NormalSideMovie;
                    speed = GameDefinition.Animation_NormalSpeed;
                    break;
                case MovieSpeedType.HalfSpeed:
                    this.CurrentMovieTexture = this.Moviedata.HalfSideMovie;
                    speed = GameDefinition.Animation_HalfSpeed;
                    break;
                case MovieSpeedType.QuaterSpeed:
                    this.CurrentMovieTexture = this.Moviedata.QuaterSideMovie;
                    speed = GameDefinition.Animation_QuaterSpeed;
                    break;
            }
        }

        this.CurrentMovieTexture.loop = GameDefinition.ActionLoop;
        this.renderer.material.mainTexture = this.CurrentMovieTexture;

        if (this.isPlaying)
        {
            this.CurrentMovieTexture.Play();
            ModelAnimationController.script.RePlay(speed);
        }
        else
        {
            ModelAnimationController.script.Stop(speed);
        }
    }

    /// <summary>
    /// 播放or恢復播放
    /// </summary>
    /// <param name="isSpeak">是否來自語音指令</param>
    public void PlayMovie(bool isSpeak)
    {
        if (!isSpeak)
        {
            if (!this.isPlaying)
            {
                this.CurrentMovieTexture.Play();
                this.isPlaying = true;
            }
            else
            {
                this.isPlaying = false;
                this.CurrentMovieTexture.Pause();
            }
        }
        else
        {
            this.CurrentMovieTexture.Play();
            this.isPlaying = true;
        }
    }

    public void RePlayMovie(MovieSpeedType speedType = MovieSpeedType.NormalSpeed)
    {
        this.CurrentMovieTexture.Stop();
        this.CurrentMovieTexture.Play();
        this.isPlaying = true;
        this.ChangeMovieTexture(speedType);
    }

    public void PauseMovie()
    {
        this.CurrentMovieTexture.Pause();
        this.isPlaying = false;
    }

    public void StopMovie()
    {
        this.CurrentMovieTexture.Stop();
        this.isPlaying = false;
        this.ChangeMovieTexture(MovieSpeedType.NormalSpeed);
    }

    [System.Serializable]
    public class MovieData
    {
        public GameDefinition.PlayActionType ActionType;
        public MovieTexture NormalFrontMovie;
        public MovieTexture HalfFrontMovie;
        public MovieTexture QuaterFrontMovie;
        public MovieTexture NormalSideMovie;
        public MovieTexture HalfSideMovie;
        public MovieTexture QuaterSideMovie;
    }

    public enum MovieSpeedType
    {
        NormalSpeed = 0,
        HalfSpeed,
        QuaterSpeed
    }

    public enum MovieDirectionType
    {
        Front = 0, Side
    }
}