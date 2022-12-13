using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTimeTimer : MonoBehaviour
{
    public float countdown = 10;
    public static bool DieTime = false;
    void Update()
    {
        if(countdown > 0)
        {
            countdown -=Time.deltaTime;
        }
        if(countdown < 0)
        {
            Debug.Log("DieTIme");
            DieTime = true;
        }
    }
}
