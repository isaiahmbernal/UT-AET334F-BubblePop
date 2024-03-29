﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author: Isaiah Bernal
public class Config_ToggleMulti : MonoBehaviour
{
    [SerializeField] private Config_Info configInfo;
    private Button myButton;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(ToggleMulti);
    }

    // If the button is pressed, the multiplayer config option is toggled, either on or off
    void ToggleMulti()
    {
        if (configInfo.isMulti == false)
            configInfo.isMulti = true;
        else if (configInfo.isMulti == true)
            configInfo.isMulti = false;
    }
}