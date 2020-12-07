using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class HUD_ExitSong : MonoBehaviour
{
    [SerializeField] private Input_Gameplay singlePlayer;
    [SerializeField] private Input_Gameplay playerOne;
    [SerializeField] private Input_Gameplay playerTwo;
    [SerializeField] private Config_Info configInfo;

    [SerializeField] private GameObject exitSong;

    // If all players health is below zero, show the quit button and allow them to exit the song
    void Update()
    {
        if (configInfo.isMulti == false)
        {
            if (singlePlayer.health <= 0)
                exitSong.SetActive(true);
            else
                exitSong.SetActive(false);
        }
        else
            if ((playerOne.health <= 0) && (playerTwo.health <= 0))
                exitSong.SetActive(true);
            else
                exitSong.SetActive(false);
    }
}
