using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Config_Info : MonoBehaviour
{
    // Keeping track of whether the game has started or if the multiplayer option is toggled
    public bool isMulti;
    public bool isPlaying;

    void Start()
    {
        isMulti = false;
        isPlaying = false;
    }
}
