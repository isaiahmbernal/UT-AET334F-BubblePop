using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class HUD_DisplayHighScore : MonoBehaviour
{
    private Text myText;

    [SerializeField] private Stats_HiScore hiScore;
    [SerializeField] private GameObject player;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        if (player.name == "Player 1")
            myText.text = hiScore.HiScore1.ToString();
        else if (player.name == "Player 2")
            myText.text = hiScore.HiScore2.ToString();
    }
}
