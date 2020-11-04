using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_DestroyNotes : MonoBehaviour
{
    public Input_Gameplay currentHealth;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Destroyed Note");
        if (other.gameObject.tag == "Note")
        {
            currentHealth.health--;
            Destroy(other.gameObject);
        }
    }
}