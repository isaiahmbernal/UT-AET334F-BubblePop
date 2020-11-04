using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_CheckArrow : MonoBehaviour
{
    public bool isTriggeredA = false;
    public bool isTriggeredB = false;
    public bool isTriggeredC = false;

    void OnTriggerEnter2D()
    {
        isTriggeredA = true;
    }

    void OnTriggerExit2D()
    {
        isTriggeredA = false;
    }
}
