using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class Stats_Nuke : MonoBehaviour
{
    private Button myButton;
    [SerializeField] private AudioSource nukeSound;
    [SerializeField] private Stats_HiScore hiScore;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(ResetStats);
    }

    // Sets hi-scores to zero
    void ResetStats()
    {
        hiScore.HiScore1 = 0;
        hiScore.HiScore2 = 0;
        PlayerPrefs.SetInt("HiScore1", 0);
        PlayerPrefs.SetInt("HiScore2", 0);
        nukeSound.Play();
    }
}
