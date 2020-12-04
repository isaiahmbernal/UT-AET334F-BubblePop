using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_ExitSong : MonoBehaviour
{

    [SerializeField] private Input_Gameplay singlePlayer;
    [SerializeField] private Input_Gameplay playerOne;
    [SerializeField] private Input_Gameplay playerTwo;
    [SerializeField] private Config_Multi multiConfig;

    [SerializeField] private GameObject exitSong;

    void Update()
    {
        if (multiConfig.isMulti == false)
        {
            if (singlePlayer.health > 0)
                exitSong.SetActive(false);
            else
                exitSong.SetActive(true);
        }
        else
            if ((playerOne.health > 0) || (playerTwo.health > 0))
                exitSong.SetActive(false);
            else
                exitSong.SetActive(true);
    }
}
