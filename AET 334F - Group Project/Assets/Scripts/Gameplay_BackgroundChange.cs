using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class Gameplay_BackgroundChange : MonoBehaviour
{
    // Gameplay variable so we can check the score, as well as a background that we can change the color of
    [SerializeField] private Input_Gameplay gameplay;
    private Image background;

    void Start()
    {
        background = GetComponent<Image>();
    }
    void Update()
    {
        // Essentially, the background's brightness will be 100th of what the player's score is
        background.color = new Color(gameplay.score/100f, gameplay.score/100f, gameplay.score/100f);
    }
}
