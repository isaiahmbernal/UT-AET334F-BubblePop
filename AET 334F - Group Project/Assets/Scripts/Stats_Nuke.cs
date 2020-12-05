using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Stats_Nuke : MonoBehaviour
{
    [SerializeField] private bool nukeStats;

    void Start()
    {
        nukeStats = false;
    }

    void Update()
    {
        if (nukeStats == true)
        {
            PlayerPrefs.SetInt("HiScore1", 0);
            PlayerPrefs.SetInt("HiScore2", 0);
        }
    }
}
