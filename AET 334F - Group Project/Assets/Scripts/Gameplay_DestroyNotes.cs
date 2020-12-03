using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Gameplay_DestroyNotes : MonoBehaviour
{
    // Gameplay variable so we can change the player's health
    [SerializeField] private Input_Gameplay currentHealth;

    // When an object exits the screen and is going to be destroyed
    void OnTriggerEnter2D(Collider2D other)
    {
        // If this object is a note, we are going to deduct the player's health and destroy the note
        if (other.gameObject.tag == "Note")
        {
            currentHealth.health--;
            Destroy(other.gameObject);
        }
    }
}