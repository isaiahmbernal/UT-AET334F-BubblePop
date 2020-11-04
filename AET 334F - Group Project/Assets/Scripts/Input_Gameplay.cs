using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Gameplay : MonoBehaviour
{
    public Input_CheckArrow arrowUp;
    public Input_CheckArrow arrowDown;
    public Input_CheckArrow arrowLeft;
    public Input_CheckArrow arrowRight;

    public Image testLight;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (arrowUp.isTriggeredA == true)
                testLight.color = Color.green;
            else
                testLight.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (arrowDown.isTriggeredA == true)
                testLight.color = Color.green;
            else
                testLight.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (arrowLeft.isTriggeredA == true)
                testLight.color = Color.green;
            else
                testLight.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (arrowRight.isTriggeredA == true)
                testLight.color = Color.green;
            else
                testLight.color = Color.red;
        }
    }
}
