using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIDieOff : MonoBehaviour
{

    public bool isImgOn;
    public Image img;

    void Start()
    {

        img.enabled = true;
        isImgOn = true;
    }

    void Update()
    {

        if (BadTimeTimer.DieTime == true)
        {
            img.enabled = false;
            isImgOn = false;
        }
        else
        {
            img.enabled = true;
            isImgOn = true;
        }
    }
}