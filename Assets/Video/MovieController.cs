using UnityEngine;
using System.Collections;

public class MovieController : MonoBehaviour
{
    private bool isPlaying;
    public MovieTexture movie;
    public static MovieController script;

    void Awake()
    {
        script = this;
    }

    // Use this for initialization
    void Start()
    {
        this.isPlaying = false;
        this.movie.loop = true;
        this.renderer.material.mainTexture = this.movie;
    }

    /// <summary>
    /// 播放or恢復播放
    /// </summary>
    /// <param name="isSpeak">是否來自語音指令</param>
    public void PlayMovie(bool isSpeak)
    {
        this.movie.Play();

        if (!isSpeak)
        {
            if (!this.isPlaying)
            {
                this.isPlaying = true;
                this.movie.Play();
            }
            else
            {
                this.isPlaying = false;
                this.movie.Pause();
            }
        }
        else
        {
            this.movie.Play();
            this.isPlaying = true;
        }
    }

    public void RePlayMovie()
    {
        this.movie.Stop();
        this.movie.Play();
        this.isPlaying = true;
    }

    public void PauseMovie()
    {
        this.movie.Pause();
        this.isPlaying = false;
    }

    public void StopMovie()
    {
        this.movie.Stop();
        this.isPlaying = false;
    }
}