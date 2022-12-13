using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIDie : MonoBehaviour
{

    public bool isImgOn;
    public Image img;

    void Start()
    {

        img.enabled = false;
        isImgOn = false;
    }

    void Update()
    {

        if (BadTimeTimer.DieTime == true)
        {
         img.enabled = true;
         isImgOn = true;
        }
        else
        {
                img.enabled = false;
                isImgOn = false;
        }
    }
}