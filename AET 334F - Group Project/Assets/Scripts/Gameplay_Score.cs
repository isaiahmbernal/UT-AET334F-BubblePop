using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class Gameplay_Score : MonoBehaviour
{
    // Gameplay variable so we can check the player's current score
    [SerializeField] private Input_Gameplay currentScore;

    // Text variable that we're going to update and assign to the player's current score
    private Text myText;

    void Start()
    {
        // Assigning the text variable to the game object's text component
        myText = GetComponent<Text>();
    }

    void Update()
    {
        // Every frame the score text will be set to the player's current score
        myText.text = currentScore.score.ToString();
    }
}
