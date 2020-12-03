using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Input_CheckArrow : MonoBehaviour
{
    // This becomes true if there is a note within the trigger volume
    public bool isTriggeredA = false;

    // This gets assigned to the bubble that touches the trigger volume so we can destroy it
    public GameObject bubble;

    // When something enters the trigger volume
    void OnTriggerEnter2D(Collider2D other)
    {
        // Assign "bubble" to whatever entered so we can destroy it if the player presses the button
        bubble = other.gameObject;
        isTriggeredA = true;
    }

    // When something leaves the trigger volume, isTriggeredA is no longer true
    void OnTriggerExit2D(Collider2D other)
    {
        isTriggeredA = false;
    }
}
