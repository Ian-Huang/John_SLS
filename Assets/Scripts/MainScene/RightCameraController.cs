using UnityEngine;
using System.Collections;

public class RightCameraController : MonoBehaviour
{
    public GameObject RightWindowNameObject;

    public GameObject 影片位置;
    public GameObject 動畫側視圖位置;
    public GameObject 動畫正視圖位置;
    public GameObject 動畫透視圖位置;

    public static RightCameraController script;

    void Awake()
    {
        script = this;
    }

    public void ChangeRightCameraView(ViewType type)
    {
        switch (type)
        {
            case ViewType.動畫側視圖:
                this.transform.position = this.動畫側視圖位置.transform.position;
                this.transform.rotation = this.動畫側視圖位置.transform.rotation;
                this.RightWindowNameObject.GetComponent<TextMesh>().text = "動畫-側視圖";
                break;
            case ViewType.動畫正視圖:
                this.transform.position = this.動畫正視圖位置.transform.position;
                this.transform.rotation = this.動畫正視圖位置.transform.rotation;
                this.RightWindowNameObject.GetComponent<TextMesh>().text = "動畫-正視圖";
                break;
            case ViewType.動畫透視圖:
                this.transform.position = this.動畫透視圖位置.transform.position;
                this.transform.rotation = this.動畫透視圖位置.transform.rotation;
                this.RightWindowNameObject.GetComponent<TextMesh>().text = "動畫-透視圖";
                break;
            case ViewType.影片側視圖:
                this.transform.position = this.影片位置.transform.position;
                this.transform.rotation = this.影片位置.transform.rotation;
                this.RightWindowNameObject.GetComponent<TextMesh>().text = "影片-側視圖";
                break;
            case ViewType.影片正視圖:
                this.transform.position = this.影片位置.transform.position;
                this.transform.rotation = this.影片位置.transform.rotation;
                this.RightWindowNameObject.GetComponent<TextMesh>().text = "影片-正視圖";
                break;
            default:
                break;
        }
    }

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(100, 50, 50, 50), "影片"))
    //    {
    //        this.camera.orthographic = true;
    //        this.transform.position = this.影片位置.transform.position;
    //        this.transform.rotation = this.影片位置.transform.rotation;
    //    }
    //    if (GUI.Button(new Rect(100, 150, 50, 50), "側視"))
    //    {
    //        this.camera.orthographic = false;
    //        this.transform.position = this.動畫側視圖位置.transform.position;
    //        this.transform.rotation = this.動畫側視圖位置.transform.rotation;
    //    }
    //    if (GUI.Button(new Rect(50, 100, 50, 50), "正視"))
    //    {
    //        this.camera.orthographic = false;
    //        this.transform.position = this.動畫正視圖位置.transform.position;
    //        this.transform.rotation = this.動畫正視圖位置.transform.rotation;

    //    }
    //    if (GUI.Button(new Rect(150, 100, 50, 50), "透視"))
    //    {
    //        this.camera.orthographic = false;
    //        this.transform.position = this.動畫透視圖位置.transform.position;
    //        this.transform.rotation = this.動畫透視圖位置.transform.rotation;
    //    }
    //}

    public enum ViewType
    {
        動畫側視圖 = 1, 動畫正視圖 = 2, 動畫透視圖 = 3, 影片側視圖 = 4, 影片正視圖 = 5
    }
}
