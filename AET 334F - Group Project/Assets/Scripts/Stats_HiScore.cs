using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Stats_HiScore : MonoBehaviour
{
    // Variables to check the player(s) scores and whether or not multiplayer is toggled
    [SerializeField] private Input_Gameplay singlePlayer;
    [SerializeField] private Input_Gameplay playerOne;
    [SerializeField] private Input_Gameplay playerTwo;
    [SerializeField] private Config_Info configInfo;

    public int HiScore1;
    public int HiScore2;

    void Start()
    {
        HiScore1 = PlayerPrefs.GetInt("HiScore1");
        HiScore2 = PlayerPrefs.GetInt("HiScore2");
        if (HiScore1 == null)
            HiScore1 = 0;
        if (HiScore2 == null)
            HiScore2 = 0;
    }

    // Depending on whether multiplayer or not, run either method
    void Update()
    {
        if (configInfo.isMulti == false)
            HiScoreSingle();
        else
            HiScoreMulti();
    }

    // If the player is dead and their score is greater than the current high score, save their score as the Hi-Score
    void HiScoreSingle()
    {
        if ((singlePlayer.health <= 0) && (singlePlayer.score > HiScore1))
        {
            HiScore1 = singlePlayer.score;
            PlayerPrefs.SetInt("HiScore1", HiScore1);
        }
    }

    // Same as HiScoreSingle but for multiplayer
    void HiScoreMulti()
    {
        if ((playerOne.health <= 0) && (playerOne.score > HiScore1))
        {
            HiScore1 = playerOne.score;
            PlayerPrefs.SetInt("HiScore1", HiScore1);
        }
        if ((playerTwo.health <= 0) && (playerTwo.score > HiScore2))
        {
            HiScore2 = playerTwo.score;
            PlayerPrefs.SetInt("HiScore2", HiScore1);
        }
    }
}
