using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_KillNotes : MonoBehaviour
{
    [SerializeField] private Config_Info configInfo;
    [SerializeField] private Input_Gameplay singleplayer;
    [SerializeField] private Input_Gameplay playerOne;
    [SerializeField] private Input_Gameplay playerTwo;
    private GameObject[] notes;

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
