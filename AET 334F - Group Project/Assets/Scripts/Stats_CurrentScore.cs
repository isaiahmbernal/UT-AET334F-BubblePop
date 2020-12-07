using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Stats_CurrentScore : MonoBehaviour
{
    [SerializeField] private Input_Gameplay singleplayer;
    [SerializeField] private Input_Gameplay playerOne;
    [SerializeField] private Input_Gameplay playerTwo;

    [SerializeField] private Config_Info configInfo;

    public int score1;
    public int score2;

    // Keeping track of the current scores, and only updating them if the player's health goes below zero
    void Update()
    {
        if ((configInfo.isMulti == false) && (singleplayer.health <= 0) && (score1 != singleplayer.score))
            score1 = singleplayer.score;
        if ((configInfo.isMulti == true) && (playerOne.health <= 0) && (score1 != playerOne.score))
            score1 = playerOne.score;
        if ((configInfo.isMulti == true) && (playerTwo.health <= 0) && (score2 != playerTwo.score))
            score2 = playerTwo.score;
    }
}
