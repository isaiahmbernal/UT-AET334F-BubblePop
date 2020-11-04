using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay_Score : MonoBehaviour
{
    public Input_Gameplay input;
    private Text myText;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        myText.text = input.score.ToString();
    }
}
