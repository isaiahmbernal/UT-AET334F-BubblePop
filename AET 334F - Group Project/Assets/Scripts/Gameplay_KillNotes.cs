using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Gameplay_KillNotes : MonoBehaviour
{
    // Variables to check if multiplayer is toggled and the current health of players
    [SerializeField] private Config_Info configInfo;
    [SerializeField] private Input_Gameplay singleplayer;
    [SerializeField] private Input_Gameplay playerOne;
    [SerializeField] private Input_Gameplay playerTwo;
    private GameObject[] notes;

    // If all players' health is below zero, we're going to find all of the notes on the screen and destroy them
    // so they don't reappear when you player plays a song again
    void Update()
    {
        if (configInfo.isMulti == false)
        {
            if (singleplayer.health <= 0)
                {
                    notes = GameObject.FindGameObjectsWithTag("Note");
                    foreach(GameObject note in notes)
                        Destroy(note);
                }
        }
        else if ((playerOne.health <= 0) && (playerTwo.health <= 0))
        {
            notes = GameObject.FindGameObjectsWithTag("Note");
            foreach(GameObject note in notes)
                Destroy(note);
        }
    }
}
