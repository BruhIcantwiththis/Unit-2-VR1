using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAcorn : MonoBehaviour
{
    public Text AcornText;

    void Update()
    {
        AcornText.text = "Key Bits " + PlayerMove.KeyBits + "/10";
    }
}
