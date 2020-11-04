using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_CheckArrow : MonoBehaviour
{
    public bool isTriggeredA = false;
    public bool isTriggeredB = false;
    public bool isTriggeredC = false;
    public GameObject bubble;

    void OnTriggerEnter2D(Collider2D other)
    {
        bubble = other.gameObject;
        isTriggeredA = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isTriggeredA = false;
    }
}
