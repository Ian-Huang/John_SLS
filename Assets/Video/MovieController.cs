using UnityEngine;
using System.Collections;

public class MovieController : MonoBehaviour
{
    public MovieTexture movie;
    public static MovieController script;

    void Awake()
    {
        script = this;
    }

    // Use this for initialization
    void Start()
    {
        //this.movie = this.GetComponent<MovieTexture>();
        this.movie.loop = true;

    }

    public void PlayMovie()
    {
        this.movie.Play();
    }

    public void PauseMovie()
    {
        this.movie.Pause();
    }

    public void StopMovie()
    {
        this.movie.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
