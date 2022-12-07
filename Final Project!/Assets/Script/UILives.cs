using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILives : MonoBehaviour
{
    public Text LivesText;

    void Update()
    {
        LivesText.text = "Health " + PlayerMove.Lives;
    }
}
