using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class HUD_DisplayScore : MonoBehaviour
{
    private Text myText;
    [SerializeField] private Stats_CurrentScore score;
    [SerializeField] private GameObject player;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        if (player.name == "Player 1")
            if (myText.text != score.score1.ToString())
                myText.text = score.score1.ToString();
        if (player.name == "Player 2")
            if (myText.text != score.score2.ToString())
                myText.text = score.score2.ToString();
    }
}