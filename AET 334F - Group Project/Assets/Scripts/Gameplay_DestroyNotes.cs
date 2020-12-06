using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Gameplay_DestroyNotes : MonoBehaviour
{
    // Gameplay variable so we can change the player's health
    [SerializeField] private Input_Gameplay currentHealth;
    [SerializeField] private Config_Info configInfo;

    // When an object exits the screen and is going to be destroyed
    void OnTriggerEnter2D(Collider2D other)
    {
        // If this object is a note, we are going to deduct the player's health and destroy the note
        if (other.gameObject.tag == "Note")
        {
            currentHealth.health--;
            if (configInfo.isMulti == false)
            {
                StatsManager.SP_healthLost++;
                Input_Gameplay.currentStreak = 0;
            }
            if (configInfo.isMulti == true && transform.parent.gameObject.tag == "MultiplayerP1")
            {
                StatsManager.MP_healthLostP1++;
                Input_Gameplay.currentStreakP1 = 0;
            }
            if (configInfo.isMulti == true && transform.parent.gameObject.tag == "MultiplayerP2")
            {
                StatsManager.MP_healthLostP2++;
                Input_Gameplay.currentStreakP2 = 0;
            }

            Destroy(other.gameObject);
        }
    }
}