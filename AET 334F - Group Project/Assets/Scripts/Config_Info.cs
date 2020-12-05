using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Config_Info : MonoBehaviour
{
    public bool isMulti;
    public bool isPlaying;

    void Start()
    {
        isMulti = false;
        isPlaying = false;
    }
}
