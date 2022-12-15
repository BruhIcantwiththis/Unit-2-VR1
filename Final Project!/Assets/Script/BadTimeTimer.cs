using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTimeTimer : MonoBehaviour
{
    public float countdown = 240;
    public static bool DieTime = false;
    public float BadTimeLeft = 0;
    void Update()
    {
        if(countdown > 0)
        {
            countdown -=Time.deltaTime;
        }
        if(countdown < 0)
        {
            DieTime = true;
            BadTimeLeft = 30;
        }
        if(BadTimeLeft > 0)
        {
            BadTimeLeft -= Time.deltaTime*90;
        }
    }
}
