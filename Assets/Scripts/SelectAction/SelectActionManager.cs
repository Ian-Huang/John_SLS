using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectActionManager : MonoBehaviour
{
    public int CurrentPage;
    public List<GameObject> PageCollection;

    public static SelectActionManager script;


    void Awake()
    {
        script = this;
    }

    // Use this for initialization
    void Start()
    {
        this.CheckPageState();
    }

    public void PreviousPage()
    {
        this.CurrentPage--;
        if (this.CurrentPage < 0)
            this.CurrentPage = this.PageCollection.Count - 1;

        this.CheckPageState();
    }

    public void NextPage()
    {
        this.CurrentPage++;
        if (this.CurrentPage >= this.PageCollection.Count)
            this.CurrentPage = 0;

        this.CheckPageState();
    }

    void CheckPageState()
    {
        for (int i = 0; i < this.PageCollection.Count; i++)
        {
            if (i == this.CurrentPage)
                this.PageCollection[i].SetActive(true);
            else
                this.PageCollection[i].SetActive(false);
        }
    }
}
