using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_CheckArrow : MonoBehaviour
{
    public bool isTriggeredA = false;
    // public bool isTriggeredB = false;
    // public bool isTriggeredC = false;

    // This gets assigned to the bubble that touches the Trigger Volume so we can destroy it
    public GameObject bubble;

    // When something enters the trigger volume for the arrow
    void OnTriggerEnter2D ( Collider2D other )
    {

        // Assign "bubble" to whatever entered so we can destroy it if the player presses the button
        bubble = other.gameObject;
        isTriggeredA = true;
    }

    void OnTriggerExit2D ( Collider2D other )
    {
        isTriggeredA = false;
    }
}
