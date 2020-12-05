using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class Stats_Nuke : MonoBehaviour
{
    private Button myButton;
    [SerializeField] private AudioSource nukeSound;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(ResetStats);
    }

    void ResetStats()
    {
        PlayerPrefs.SetInt("HiScore1", 0);
        PlayerPrefs.SetInt("HiScore2", 0);
        nukeSound.Play();
    }
}
