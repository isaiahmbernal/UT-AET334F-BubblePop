using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Stats_HiScore : MonoBehaviour
{
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
    }

    void Update()
    {
        if (configInfo.isMulti == false)
            HiScoreSingle();
        else
            HiScoreMulti();
    }

    void HiScoreSingle()
    {
        if ((singlePlayer.health < 0) && (singlePlayer.score > HiScore1))
        {
            PlayerPrefs.SetInt("HiScore1", singlePlayer.score);
            HiScore1 = PlayerPrefs.GetInt("HiScore1");
        }
    }

    void HiScoreMulti()
    {
        if ((playerOne.health < 0) && (playerOne.score > HiScore1))
        {
            PlayerPrefs.SetInt("HiScore1", playerOne.score);
            HiScore1 = PlayerPrefs.GetInt("HiScore1");
        }
        if ((playerTwo.health < 0) && (playerTwo.score > HiScore2))
        {
            PlayerPrefs.SetInt("HiScore2", playerTwo.score);
            HiScore2 = PlayerPrefs.GetInt("HiScore2");
        }
    }
}
