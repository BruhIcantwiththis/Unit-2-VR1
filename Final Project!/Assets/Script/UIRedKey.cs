using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRedKey : MonoBehaviour
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
        if (PlayerMove.RedKey == 1)
        {
            img.enabled = false;
            isImgOn = false;
        }
        if (BadTimeTimer.DieTime == true)
        {
            img.enabled = false;
            isImgOn = false;
        }
        if(BadTimeTimer.DieTime == false)
        {
            if (PlayerMove.RedKey == 1)
            {
                img.enabled = true;
                isImgOn = true;
            }
        }
    }
}
